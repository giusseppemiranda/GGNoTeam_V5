using GGNoTeam_V5.Recursos.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.TareasPendientes.Tareas
{
    public partial class frmEditarTarea : Form
    {
        private TareasDiariasWS.tarea tareaModificar;
        private bool casoEdicion = false;
        private TareasDiariasWS.TareasDiariasWSClient _daoTareas;
        private int fidItinerario = -1;
        private frmTareasPendientes ventanaTareas;
        private bool accionComoAdministrador = false;

        //Agregar tarea
        public frmEditarTarea(frmTareasPendientes ventana, int fidItinerario, bool accionAdmin)
        {
            InitializeComponent();
            cambiarTema();

            tareaModificar = new TareasDiariasWS.tarea();
            this.fidItinerario = fidItinerario;
            ventanaTareas = ventana;
            accionComoAdministrador = accionAdmin;

            //cargarComboBox();
            cargarDatosTipoAccion_Agregar();
        }

        //Modificar tarea
        public frmEditarTarea(frmTareasPendientes ventana, LoginWS.tarea task, bool accionAdmin)
        {
            InitializeComponent();
            cambiarTema();
            //cargarComboBox();

            tareaModificar = new TareasDiariasWS.tarea();
            boxID.Texts = task.idTarea.ToString();
            boxDescripcion.Texts = task.descripcion;
            casoEdicion = true;
            ventanaTareas = ventana;
            accionComoAdministrador = accionAdmin;

            cargarDatosTipoAccion_Modificar(true);
        }

        private void cargarDatosTipoAccion_Modificar(bool estado)
        {
            lblTitulo.Text = "MODIFICAR TAREA";
            btnSiguiente.Text = "Actualizar";
            if (estado)
            {
                comboBoxEstado.SelectedIndex = 0;
            }
            else
            {
                comboBoxEstado.SelectedIndex = 1;
            }
        }

        private void cargarDatosTipoAccion_Agregar()
        {
            lblTitulo.Text = "AGREGAR TAREA";
            btnSiguiente.Text = "Agregar";
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
            this.BackColor = Global.FrmOscuro_2;
            boxID.BackColor = Color.Black;
            boxID.BorderColor = boxID.BackColor;

            //boxHora.BackColor = boxID.BackColor;
            //boxHora.BorderColor = boxID.BackColor;
            Global.pintarTxtBoxOscuro(ref boxDescripcion);
            //Global.pintarTxtBoxOscuro(ref boxID);
            //Global.pintarTxtBoxOscuro(ref boxPlazo);

        }

        private void activarTemaClaro()
        {
            this.BackColor = Global.FrmClaro_2;
            boxID.BackColor = Color.DarkGray;
            boxID.BorderColor = boxID.BackColor;
            //boxHora.BackColor = boxID.BackColor;
            //boxHora.BorderColor = boxID.BackColor;
            Global.pintarTxtBoxClaro(ref boxDescripcion);
            //Global.pintarTxtBoxClaro(ref boxID);
            //Global.pintarTxtBoxClaro(ref boxPlazo);
        }

        //private void cargarComboBox()
        //{
        //    comboBoxEstado.Items.Add("Completo");
        //    comboBoxEstado.Items.Add("Incompleto");
        //    comboBoxEstado.SelectedIndex = 1;
        //}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            cargarDatos();
            if (boxDescripcion.Texts == "")
            {
                MessageBox.Show("La descripción de la tarea a insertar no puede encontrarse vacía. Intente nuevamente");
                return;
            } 

            _daoTareas = new TareasDiariasWS.TareasDiariasWSClient();
            if (casoEdicion)
            {
                modificarTarea();
            }
            else
            {
                agregarTarea();
            }
            this.Dispose();
        }

        private void modificarTarea()
        {
            int procesoValido = -1;
            tareaModificar.idTarea = Int32.Parse(boxID.Texts);
            procesoValido = _daoTareas.modificarTarea(tareaModificar);
            if (procesoValido == 1)
            {
                MessageBox.Show("La tarea ha sido modificada con éxito");
                if (accionComoAdministrador)
                    notificacion("ACTUALIZACIÓN DE TAREA", "Estimado (a),\n El sistema de Gestión de Riesgos e Inversiones le informa que se ha modificado la tarea con ID " + tareaModificar.idTarea + " : " + tareaModificar.descripcion + " . De encontrar algún error en lo comentado escriba un correo a AFPIntegralp2@gmail.com");
                //ventanaTareas.actualizarDGV();
            }
            else
            {
                MessageBox.Show("La tarea no se ha modificado");
            }
        }

        private void agregarTarea()
        {
            int procesoValido = -1;
            tareaModificar.fidItinerario = fidItinerario;
            procesoValido = _daoTareas.insertarTarea(tareaModificar);
            if (procesoValido != 0)
            {
                MessageBox.Show("La tarea ha sido insertada con éxito");
                if (accionComoAdministrador)
                    notificacion("ACTUALIZACIÓN DE TAREA", "Estimado (a),\n El sistema de Gestión de Riesgos e Inversiones le informa que se ha agregado la tarea con ID " + tareaModificar.idTarea + " : " + tareaModificar.descripcion + " . De encontrar algún error en lo comentado escriba un correo a AFPIntegralp2@gmail.com");
                //ventanaTareas.actualizarDGV();
            }
            else
            {
                MessageBox.Show("La tarea no se ha insertado");
            }
        }

        private void cargarDatos()
        {
            tareaModificar.fechaCreacion = DateTime.Now.ToString("yyyy-MM-dd");
            tareaModificar.descripcion = boxDescripcion.Texts;
            tareaModificar.estado = comboBoxEstado.SelectedIndex;
        }

        private void notificacion(string ASUNTO, string CUERPO)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.Subject = ASUNTO;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = CUERPO;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;
            ventanaTareas.enviarNotificacionCorreo(msg);
        }

        private void frmEditarTarea_Load(object sender, EventArgs e)
        {

        }
    }
}
