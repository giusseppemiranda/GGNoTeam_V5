using GGNoTeam_V5.Recursos.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.TareasPendientes.Tareas

{
    public partial class frmPropiasTareasPendientes : Form
    {
        private frmPrincipal ventanaPadre = null;
        private LoginWS.persona user;
        private LoginWS.LoginWSClient _daoPersona;
        private TareasDiariasWS.TareasDiariasWSClient _daoTareasDiarias;
        private bool accionAdmin = false;
        private bool listarCompletos = true;
        private TareasDiariasWS.tarea[] tareas;
        private TareasDiariasWS.tarea tareaAux;
        private LoginWS.persona[] personas;
        private LoginWS.persona personaAux;
        private LoginWS.persona adminAux;
        private LoginWS.persona UsuarioAux;
        private TareasDiariasWS.tarea tareaAdmin;
        private TareasDiariasWS.tarea tareaUsuario;
        public frmPropiasTareasPendientes(frmPrincipal ventana, LoginWS.persona persona)
        {
            InitializeComponent();
            cambiarTema();
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);

            _daoTareasDiarias = new TareasDiariasWS.TareasDiariasWSClient();
            _daoPersona = new LoginWS.LoginWSClient();
            tareaAdmin = new TareasDiariasWS.tarea();
            user = _daoPersona.listarPorCodExacto(Int32.Parse(persona.codigo))[0];

            cargarLabelInicial();
            pintarDGVInicial();
            cargarCombo();
            btnRenovarTarea.Visible = false;
            btnEliminar.Visible = false;
            dgvTareasPendientes.AutoGenerateColumns = false;
            ActualizarPerdidas();
        }

        public void cambiarTema()
        {
            if (Global.TemaOscuro)
            {
                activarTemaClaro();
            }
            else
            {
                activarTemaOscuro();
            }
        }

        private void activarTemaOscuro()
        {
            this.BackColor = Global.FrmOscuro;
        }

        private void activarTemaClaro()
        {
            this.BackColor = Global.FrmClaro;
        }

        private void cargarLabelInicial()
        {
            lblNombre.Text = "Gestión de tareas y pendientes de " + user.nombre.ToUpper() + " " + user.apellidos.ToUpper();
            lblNombre.ForeColor = Color.DarkSalmon;
        }

        private void pintarDGVInicial()
        {
            Global.pintarDGV(ref dgvTareasPendientes, Color.DarkSalmon);
        }

        private void cargarCombo()
        {
            comboEstadoTarea.Items.Add("Pendientes");
            comboEstadoTarea.Items.Add("Completadas");
            comboEstadoTarea.Items.Add("Perdidas");
            comboEstadoTarea.SelectedIndex = 0;
        }
        private void actualizarBotones()
        {
            switch (comboEstadoTarea.Texts)
            {
                case "Pendientes":
                    btnEliminar.Visible = false;
                    if (user.tipoUsuario == 1)
                        btnRenovarTarea.Visible = true;
                    btnCompletarTarea.Visible = true;
                    break;
                case "Completadas":
                    btnEliminar.Visible = true;
                    btnEliminar.Location = new Point(830, 486);
                    if (user.tipoUsuario == 1)
                        btnRenovarTarea.Visible = false;
                    btnCompletarTarea.Visible = true;
                    break;
                case "Perdidas":
                    btnEliminar.Visible = true;
                    btnEliminar.Location = new Point(830, 486);
                    if (user.tipoUsuario == 1)
                        btnRenovarTarea.Visible = false;
                    btnCompletarTarea.Visible = false;
                    break;
            }
        }

        private void btnConsultarTareas_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            dgvTareasPendientes.comenzarHilo();
            dgvTareasPendientes.DataSource = null;
            switch (comboEstadoTarea.SelectedItem.ToString())
            {
                case "Pendientes":
                    {
                        actualizarBotones();
                        tareas = _daoTareasDiarias.listarTareasPorEstadoPorItinerario(0, user.itinerario.idItineraio);
                        break;
                    }
                case "Completadas":
                    {
                        actualizarBotones();
                        tareas = _daoTareasDiarias.listarTareasPorEstadoPorItinerario(1, user.itinerario.idItineraio);

                        break;
                    }
                case "Perdidas":
                    {
                        actualizarBotones();
                        tareas = _daoTareasDiarias.listarTareasPorEstadoPorItinerario(2, user.itinerario.idItineraio);

                        break;
                    }
            }
            if (tareas != null)
            {
                dgvTareasPendientes.setDataSource1(new BindingList<TareasDiariasWS.tarea>(tareas.ToList()));
            }
            cargarNombresAutores();
            this.Cursor = Cursors.Default;
        }

        private void ActualizarPerdidas()
        {
            tareas = _daoTareasDiarias.listarTareasPorEstadoPorItinerario(0, user.itinerario.idItineraio);
            DateTime dt;
            if (tareas != null)
            {
                for (int i = 0; i < tareas.Length; i++)
                {
                    dt = Convert.ToDateTime(tareas[i].fechaLimite.Replace("-", "/"));
                    if (DateTime.Compare(dt, DateTime.Now) < 0)
                    {
                        tareas[i].estado = 2;
                        if (!tareas[i].descripcion.Contains("COMPLETO"))
                        {
                            enviarPerdidaAutor(tareas[i]);
                        }
                        _daoTareasDiarias.modificarTarea(tareas[i]);

                    }
                }
            }
        }

        private void btnCompletarTarea_Click(object sender, EventArgs e)
        {

            if (dgvTareasPendientes.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("¿Está seguro que desea marcar la tarea como completa?", "Tarea completa", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    tareaAux = (TareasDiariasWS.tarea)dgvTareasPendientes.CurrentRow.DataBoundItem;
                    tareaAux.estado = 1;
                    _daoTareasDiarias.modificarTarea(tareaAux);
                    if (!tareaAux.descripcion.Contains("COMPLETO"))
                    {
                        enviarConfirmacionAutor();
                    }
                    this.btnConsultarTareas_Click(sender, e);
                }
            }
        }

        private void enviarConfirmacionAutor()
        {
            adminAux = _daoPersona.listarPersonaPorID(tareaAux.fidAutor);
            tareaAdmin.estado = 0;
            tareaAdmin.fechaCreacion = DateTime.Now.ToString("yyyy/MM/dd").Replace("/", "-");
            tareaAdmin.fechaLimite = DateTime.Now.AddDays(7).ToString("yyyy/MM/dd").Replace("/", "-");
            tareaAdmin.fidAutor = user.idPersona;
            tareaAdmin.fidItinerario = adminAux.itinerario.idItineraio;
            tareaAdmin.descripcion = tareaAux.descripcion.Substring(0, 1).ToUpper() + tareaAux.descripcion.Substring(1).ToLower();
            tareaAdmin.descripcion = tareaAux.descripcion + " " + "COMPLETO";
            _daoTareasDiarias.insertarTarea(tareaAdmin);
        }

        private void enviarPerdidaAutor(TareasDiariasWS.tarea tareaPerdida)
        {
            adminAux = _daoPersona.listarPersonaPorID(tareaPerdida.fidAutor);
            tareaAdmin.estado = 0;
            tareaAdmin.fechaCreacion = DateTime.Now.ToString("yyyy/MM/dd").Replace("/", "-");
            tareaAdmin.fechaLimite = DateTime.Now.AddDays(7).ToString("yyyy/MM/dd").Replace("/", "-");
            tareaAdmin.fidAutor = user.idPersona;
            tareaAdmin.fidItinerario = adminAux.itinerario.idItineraio;
            tareaAdmin.descripcion = tareaPerdida.descripcion.Substring(0, 1).ToUpper() + tareaPerdida.descripcion.Substring(1).ToLower();
            tareaAdmin.descripcion = tareaPerdida.descripcion + " " + "INCOMPLETO";
            _daoTareasDiarias.insertarTarea(tareaAdmin);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTareasPendientes.CurrentRow != null)
            {
                var resultado = MessageBox.Show("¿Está seguro que desea elimiar la tarea?", "Eliminar tarea", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    tareaAux = (TareasDiariasWS.tarea)dgvTareasPendientes.CurrentRow.DataBoundItem;
                    _daoTareasDiarias.eliminarTarea(tareaAux.idTarea);
                    this.btnConsultarTareas_Click(sender, e);
                    MessageBox.Show("La tarea se la eliminado con éxito.");
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado el elemento a borrar.");
            }
        }

        private void cargarNombresAutores()
        {
            if (tareas != null)
            {
                for (int i = 0; i < tareas.Length; i++)
                {
                    personaAux = _daoPersona.listarPersonaPorID(tareas[i].fidAutor);
                    dgvTareasPendientes.Rows[i].Cells[4].Value = personaAux.nombre;
                }
            }
        }

        private void dgvTareasPendientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            TareasDiariasWS.tarea tar = (TareasDiariasWS.tarea)dgvTareasPendientes.Rows[e.RowIndex].DataBoundItem;
            dgvTareasPendientes.Rows[e.RowIndex].Cells[0].Value = tar.idTarea;
            dgvTareasPendientes.Rows[e.RowIndex].Cells[1].Value = tar.fechaCreacion;
            dgvTareasPendientes.Rows[e.RowIndex].Cells[2].Value = tar.fechaLimite;
            dgvTareasPendientes.Rows[e.RowIndex].Cells[3].Value = tar.descripcion;
        }

        private void btnRenovarTarea_Click(object sender, EventArgs e)
        {
            if (dgvTareasPendientes.SelectedRows.Count > 0)
            {
                tareaUsuario = (TareasDiariasWS.tarea)dgvTareasPendientes.CurrentRow.DataBoundItem;

                if (tareaUsuario.descripcion.Contains("INCOMPLETO"))
                {
                    //completar tarea para admin
                    tareaUsuario.estado = 1;
                    _daoTareasDiarias.modificarTarea(tareaUsuario);
                    //insertar tarea renovada a usuario
                    UsuarioAux = _daoPersona.listarPersonaPorID(tareaUsuario.fidAutor);
                    tareaUsuario.estado = 0;
                    tareaUsuario.fidItinerario = UsuarioAux.itinerario.idItineraio;
                    tareaUsuario.fidAutor = user.idPersona;
                    tareaUsuario.descripcion = tareaUsuario.descripcion.Replace("INCOMPLETO", "");
                    tareaUsuario.fechaCreacion = DateTime.Now.ToString("yyyy/MM/dd").Replace("/", "-");
                    tareaUsuario.fechaLimite = DateTime.Now.AddDays(7).ToString("yyyy/MM/dd").Replace("/", "-");
                    _daoTareasDiarias.insertarTarea(tareaUsuario);

                }
                else if (tareaUsuario.descripcion.Contains("COMPLETO"))
                {
                    //completar tarea para admin

                    tareaUsuario.estado = 1;
                    _daoTareasDiarias.modificarTarea(tareaUsuario);
                    //insertar tarea renovada a usuario
                    UsuarioAux = _daoPersona.listarPersonaPorID(tareaUsuario.fidAutor);
                    tareaUsuario.estado = 0;
                    tareaUsuario.fidItinerario = UsuarioAux.itinerario.idItineraio;
                    tareaUsuario.fidAutor = user.idPersona;
                    tareaUsuario.descripcion = tareaUsuario.descripcion.Replace("COMPLETO", "");
                    _daoTareasDiarias.insertarTarea(tareaUsuario);
                }
                else MessageBox.Show("Tarea no renovable");
            }

        }
    }
}
