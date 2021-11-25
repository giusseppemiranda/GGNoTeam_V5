using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GGNoTeam_V5.Recursos.sendMail;
using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.VentanaPrincipal.TareasPendientes.Tareas;

namespace GGNoTeam_V5.VentanaPrincipal
{
    public partial class frmTareasPendientes : Form
    {
        private frmPrincipal ventanaPadre = null;
        private LoginWS.persona user;
        private LoginWS.LoginWSClient _daoPersona;
        private TareasDiariasWS.TareasDiariasWSClient _daoTareasDiarias;
        private bool accionAdmin = false;
        private bool listarCompletos = true;
        private TareasDiariasWS.tarea[] tareas;
        private LoginWS.persona[] personas;
        private LoginWS.persona personaAux;
        private LoginWS.persona adminAux;
        private TareasDiariasWS.tarea tareaAdmin;
        //public frmTareasPendientes(frmPrincipal ventana, LoginWS.persona persona)
        //{
        //    InitializeComponent();
        //    cargarCombo();
        //    cambiarTema();
        //    ventanaPadre = ventana;
        //    ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);

        //    _daoTareasDiarias = new TareasDiariasWS.TareasDiariasWSClient();
        //    _daoPersona = new LoginWS.LoginWSClient();
        //    user = _daoPersona.listarPorCodExacto(Int32.Parse(persona.codigo))[0];
        //    accionAdmin = true;

        //    cargarLabelInicial();
        //    cargarDatosPorTipoUsuario();
        //    pintarDGVInicial();
        //}

        public frmTareasPendientes(LoginWS.persona persona, LoginWS.persona admin)
        {
            InitializeComponent();
            cargarCombo();
            cambiarTema();

            tareaAdmin = new TareasDiariasWS.tarea();
            _daoTareasDiarias = new TareasDiariasWS.TareasDiariasWSClient();
            _daoPersona = new LoginWS.LoginWSClient();

            btnSalir.Visible = true;
            user = persona;            
            adminAux = admin;            
            dgvTareasPendientes.AutoGenerateColumns = false;
            
            cargarLabelInicial();
            pintarDGVInicial();
            cargarSubTema();            
            ActualizarPerdidas();            
        }

        private void cargarSubTema()
        {
            if (!Global.TemaOscuro)
            {
                this.BackColor = Global.FrmOscuro_2;
            }
            else
            {
                this.BackColor = Global.FrmClaro_2;
            }
        }

        private void cargarLabelInicial()
        {
            lblNombre.Text = "Gestión de tareas y pendientes de " + user.nombre.ToUpper() + " " + user.apellidos.ToUpper();
            lblNombre.ForeColor = Color.DarkSalmon;
        }
        private void cargarCombo()
        {
            comboEstadoTarea.Items.Add("Pendientes");
            comboEstadoTarea.Items.Add("Completadas");
            comboEstadoTarea.Items.Add("Perdidas");
            comboEstadoTarea.SelectedIndex = 0;
        }

        private void pintarDGVInicial()
        {
            Global.pintarDGV(ref dgvTareasPendientes, Color.DarkSalmon);
        }

        private void cargarDatosPorTipoUsuario()
        {
            if (user.tipoUsuario == 2)
            {
                btnEliminar.Visible = false;
                btnAgregarTarea.Visible = false;
            }
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


        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            frmEditarTarea ventanaAgregar = new frmEditarTarea(this, user.itinerario.idItineraio,adminAux);
            ventanaAgregar.ShowDialog();
            this.btnConsultarTareas_Click(sender, e);
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTareasPendientes.CurrentRow != null)
            {
                DialogResult r = MessageBox.Show("Está seguro que desea eliminar la tarea seleccionada?", "Eliminar botones", MessageBoxButtons.OKCancel);

                if (r == DialogResult.OK)
                {
                    int idTarea = (int)dgvTareasPendientes.Rows[dgvTareasPendientes.CurrentRow.Index].Cells[0].Value;
                    int validez = _daoTareasDiarias.eliminarTarea(idTarea);
                    if (validez == 1)
                    {
                        MessageBox.Show("La tarea ha sido eliminada con éxito");
                    }
                    else
                    {
                        MessageBox.Show("No se ha eliminado la tarea");
                    }
                }
            }
        }


        private void btnModificarTarea_Click(object sender, EventArgs e)
        {
            if (dgvTareasPendientes.CurrentRow != null )
            {
                if (adminAux.idPersona == user.itinerario.listaTarea[dgvTareasPendientes.CurrentRow.Index].fidAutor)
                {
                    frmEditarTarea ventanaModificar = new frmEditarTarea(this, user.itinerario.listaTarea[dgvTareasPendientes.CurrentRow.Index], adminAux);
                    ventanaModificar.ShowDialog();
                    this.btnConsultarTareas_Click(sender, e);
                }
                else MessageBox.Show("No tiene lo permisos para modifcar esta tarea");

            }
        }

        public void enviarNotificacionCorreo(System.Net.Mail.MailMessage msg)
        {
            msg.To.Add(user.correo);
            servidorCliente server = new servidorCliente();
            server.sendMessage(msg);
        }

        //private void btnListarPorTipo_Click(object sender, EventArgs e)
        //{

        //    dgvTareasPendientes.Rows.Clear();
        //    if (listarCompletos)
        //    {
        //        user = _daoPersona.listarPorCodExacto_TareasCompletas(Int32.Parse(user.codigo))[0];
        //        if (user.itinerario.listaTarea != null)
        //        {
        //            for (int i = 0; i < user.itinerario.listaTarea.Length; i++)
        //            {
        //                dgvTareasPendientes.Rows.Add(user.itinerario.listaTarea[i].idTarea, "Completo", user.itinerario.listaTarea[i].descripcion);
        //            }                    
        //        }
        //        listarCompletos = false;
        //        btnListarPorTipo.Text = "Listar Incompletos";
        //        btnListarPorTipo.IconChar = FontAwesome.Sharp.IconChar.Times;
        //    }
        //    else
        //    {
        //        user = _daoPersona.listarPorCodExacto_TareasInompletas(Int32.Parse(user.codigo))[0];
        //        if (user.itinerario.listaTarea != null)
        //        {
        //            for (int i = 0; i < user.itinerario.listaTarea.Length; i++)
        //            {
        //                dgvTareasPendientes.Rows.Add(user.itinerario.listaTarea[i].idTarea, "Incompleto", user.itinerario.listaTarea[i].descripcion);
        //            }                    
        //        }
        //        listarCompletos = true;
        //        btnListarPorTipo.Text = "Listar Completos";
        //        btnListarPorTipo.IconChar = FontAwesome.Sharp.IconChar.Check;
        //    }

        //}

        private void ActualizarPerdidas()
        {
            //listar tareas segun usuario, no conectar al dgv, revisar fecha y comparar con fecha actual, cambiar estado segun fecha
            tareas = null;
            tareas = _daoTareasDiarias.listarTareasPorEstadoPorItinerario(0, user.itinerario.idItineraio);
            DateTime dt;
            if (tareas!=null) {
                for (int i = 0; i < tareas.Length; i++)
                {
                    dt = Convert.ToDateTime(tareas[i].fechaLimite.Replace("-", "/"));
                    if (DateTime.Compare(DateTime.Now, dt.AddDays(1)) > 0)
                    {
                        tareas[i].estado = 2;
                        _daoTareasDiarias.modificarTarea(tareas[i]);
                        enviarPerdidaAutor(tareas[i]);
                    }
                }
            }
        }

        private void enviarPerdidaAutor(TareasDiariasWS.tarea tareaPerdida)
        {
            adminAux = _daoPersona.listarPersonaPorID(tareaPerdida.fidAutor);
            tareaAdmin.estado = 0;
            tareaAdmin.fechaCreacion = DateTime.Now.ToString("yyyy/MM/dd").Replace("/", "-");
            tareaAdmin.fechaLimite = DateTime.Now.AddDays(7).ToString("yyyy/MM/dd").Replace("/", "-");
            tareaAdmin.fidAutor = user.idPersona;
            tareaAdmin.fidItinerario = adminAux.itinerario.idItineraio;
            tareaAdmin.descripcion = tareaPerdida.descripcion + " " + "INCOMPLETO";
            _daoTareasDiarias.insertarTarea(tareaAdmin);
        }

        private void btnConsultarTareas_Click(object sender, EventArgs e)
        {
            dgvTareasPendientes.DataSource = null;
            switch(comboEstadoTarea.SelectedItem.ToString()){
                case "Pendientes":
                    {
                        tareas = _daoTareasDiarias.listarTareasPorEstadoPorItinerario(0,user.itinerario.idItineraio);
                        actualizarBotones();
                        if(tareas!=null)
                            dgvTareasPendientes.DataSource = new BindingList<TareasDiariasWS.tarea>(tareas.ToList());
                        break;
                    }
                case "Completadas":
                    {
                        tareas = _daoTareasDiarias.listarTareasPorEstadoPorItinerario(1, user.itinerario.idItineraio);
                        actualizarBotones();
                        if (tareas != null)
                            dgvTareasPendientes.DataSource = new BindingList<TareasDiariasWS.tarea>(tareas.ToList());
                        break;
                    }
                case "Perdidas":
                    {
                        tareas = _daoTareasDiarias.listarTareasPorEstadoPorItinerario(2, user.itinerario.idItineraio);
                        actualizarBotones();
                        if (tareas != null)
                            dgvTareasPendientes.DataSource = new BindingList<TareasDiariasWS.tarea>(tareas.ToList());
                        break;
                    }
            }
            cargarNombresAutores();
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

        private void comboEstadoTarea_Load(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void dgvTareasPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void actualizarBotones()
        {
            switch (comboEstadoTarea.Texts)
            {
                case "Pendientes":
                    btnEliminar.Visible = false;
                    btnAgregarTarea.Visible = true;
                    btnModificarTarea.Visible = true;
                    break;
                case "Completadas":
                    btnEliminar.Visible = true;
                    btnEliminar.Location = new Point(846, 487);
                    btnAgregarTarea.Visible = false;
                    btnModificarTarea.Visible = false;
                    break;
                case "Perdidas":
                    btnEliminar.Visible = true;
                    btnEliminar.Location = new Point (846, 487);
                    btnAgregarTarea.Visible = false;
                    btnModificarTarea.Visible = false;
                    break;
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
    }
}
