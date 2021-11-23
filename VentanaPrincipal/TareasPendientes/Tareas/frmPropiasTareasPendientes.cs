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
        public frmPropiasTareasPendientes(frmPrincipal ventana, LoginWS.persona persona)
        {
            InitializeComponent();
            cambiarTema();
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);

            _daoTareasDiarias = new TareasDiariasWS.TareasDiariasWSClient();
            _daoPersona = new LoginWS.LoginWSClient();
            user = _daoPersona.listarPorCodExacto(Int32.Parse(persona.codigo))[0];

            cargarLabelInicial();
            pintarDGVInicial();
            cargarCombo();
            btnRenovarTarea.Visible = false;
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
                    btnRenovarTarea.Visible = false;
                    btnCompletarTarea.Visible = true;
                    break;
                case "Completadas":
                    btnEliminar.Visible = true;
                    btnRenovarTarea.Visible = false;
                    btnCompletarTarea.Visible = true;
                    break;
                case "Perdidas":
                    btnEliminar.Visible = true;
                    btnRenovarTarea.Visible = true;
                    btnCompletarTarea.Visible = false;
                    break;
            }
        }

        private void btnConsultarTareas_Click(object sender, EventArgs e)
        {
            ActualizarPerdidas();
            switch (comboEstadoTarea.SelectedItem.ToString())
            {
                case "Pendientes":
                    {
                        actualizarBotones();
                        tareas = _daoTareasDiarias.listarTareasPorEstadoPorItinerario(0, user.itinerario.idItineraio);
                        if (tareas != null)
                        {
                            dgvTareasPendientes.DataSource = new BindingList<TareasDiariasWS.tarea>(tareas.ToList());
                        }
                        break;
                    }
                case "Completadas":
                    {
                        actualizarBotones();
                        tareas = _daoTareasDiarias.listarTareasPorEstadoPorItinerario(1, user.itinerario.idItineraio);
                        if (tareas != null)
                        {
                            dgvTareasPendientes.DataSource = new BindingList<TareasDiariasWS.tarea>(tareas.ToList());
                        }
                        break;
                    }
                case "Perdidas":
                    {
                        actualizarBotones();
                        tareas = _daoTareasDiarias.listarTareasPorEstadoPorItinerario(2, user.itinerario.idItineraio);
                        if (tareas != null)
                        {
                            dgvTareasPendientes.DataSource = new BindingList<TareasDiariasWS.tarea>(tareas.ToList());
                        }
                        break;
                    }
            }
        }

        private void ActualizarPerdidas()
        {
            //listar tareas segun usuario, no conectar al dgv, revisar fecha y comparar con fecha actual, cambiar estado segun fecha
            tareas = _daoTareasDiarias.listarTareasPorEstadoPorItinerario(0, user.itinerario.idItineraio);
            DateTime dt;
            if(tareas != null)
            for (int i = 0; i < tareas.Length; i++)
            {
                dt = Convert.ToDateTime(tareas[i].fechaLimite.Replace("-", "/"));
                if (DateTime.Compare(dt, DateTime.Now) < 0)
                {
                    tareas[i].estado = 2;
                    _daoTareasDiarias.modificarTarea(tareas[i]);
                }
            }
        }

        private void btnCompletarTarea_Click(object sender, EventArgs e)
        {

            if(dgvTareasPendientes.SelectedRows.Count > 0)
            {
                tareaAux = (TareasDiariasWS.tarea)dgvTareasPendientes.CurrentRow.DataBoundItem;
                tareaAux.estado = 1;
                _daoTareasDiarias.modificarTarea(tareaAux);
                this.btnConsultarTareas_Click(sender, e);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTareasPendientes.SelectedRows.Count > 0)
            {
                tareaAux = (TareasDiariasWS.tarea)dgvTareasPendientes.CurrentRow.DataBoundItem;
                _daoTareasDiarias.eliminarTarea(tareaAux.idTarea);
                this.btnConsultarTareas_Click(sender, e);
            }
        }

        private void cargarNombresAutores()
        {
            for (int i = 0; i < tareas.Length; i++)
            {
                personaAux = _daoPersona.listarPersonaPorID(tareas[i].fidAutor);
                dgvTareasPendientes.Rows[i].Cells[4].Value = personaAux.nombre;
            }
        }
    }
}
