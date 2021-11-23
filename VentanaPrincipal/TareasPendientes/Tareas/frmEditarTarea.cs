using GGNoTeam_V5.Recursos.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.TareasPendientes.Tareas
{
    public partial class frmEditarTarea : Form
    {
        private bool casoEdicion = false;
        private TareasDiariasWS.TareasDiariasWSClient _daoTareas;
        private frmTareasPendientes ventanaTareas;
        private bool accionComoAdministrador = false;
        private TareasDiariasWS.tarea tareaAux;
        private int idAux;

        //Agregar tarea
        public frmEditarTarea(frmTareasPendientes ventana, int fidItinerario, LoginWS.persona admin)
        {
            InitializeComponent();
            cambiarTema();

            tareaAux = new TareasDiariasWS.tarea();
            tareaAux.fidItinerario = fidItinerario;
            tareaAux.fidAutor = admin.idPersona;
            ventanaTareas = ventana;
            //accionComoAdministrador = accionAdmin;
            cargarComboBox();
            comboBoxEstado.Visible = false;
            lblEstado.Visible = false;
            dateFechaCreacion.Enabled = false;
            cargarDatosTipoAccion_Agregar();
        }

        //Modificar tarea
        public frmEditarTarea(frmTareasPendientes ventana, LoginWS.tarea task, LoginWS.persona admin)
        {
            InitializeComponent();
            cambiarTema();
            cargarComboBox();
            tareaAux = new TareasDiariasWS.tarea();
            tareaAux.idTarea = task.idTarea;
            //tareaAux.fechaCreacion = task.fechaCreacion;
            //tareaAux.fechaLimite = task.fechaLimite;
            //tareaAux.descripcion = task.descripcion;
            tareaAux.fidItinerario = task.fidItinerario;
            tareaAux.fidAutor = task.fidAutor;
            tareaAux.fechaCreacion = task.fechaCreacion;
            tareaAux.fechaLimite = task.fechaLimite;
            tareaAux.descripcion = task.descripcion;
            casoEdicion = true;
            ventanaTareas = ventana;
            comboBoxEstado.Visible = true;
            lblEstado.Visible = true;
            dateFechaCreacion.Enabled = false;
            //accionComoAdministrador = accionAdmin;
            cargarDatosTipoAccion_Modificar();
        }

        private void cargarDatosTipoAccion_Modificar()
        {
            lblTitulo.Text = "MODIFICAR TAREA";
            btnSiguiente.Text = "Actualizar";
            dateFechaCreacion.Value = DateTime.Parse(tareaAux.fechaCreacion.Replace("-", "/"));
            dateFechaLimite.Value = DateTime.Parse(tareaAux.fechaLimite.Replace("-", "/"));
            boxDescripcion.Texts = tareaAux.descripcion;
            comboBoxEstado.SelectedIndex = tareaAux.estado;
        }

        private void cargarDatosTipoAccion_Agregar()
        {
            lblTitulo.Text = "AGREGAR TAREA";
            btnSiguiente.Text = "Agregar";
            comboBoxEstado.SelectedIndex = 0;
            dateFechaCreacion.Value = DateTime.Now;
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
            //boxID.BackColor = Color.Black;
            //boxID.BorderColor = boxID.BackColor;

            //boxHora.BackColor = boxID.BackColor;
            //boxHora.BorderColor = boxID.BackColor;
            Global.pintarTxtBoxOscuro(ref boxDescripcion);
            //Global.pintarTxtBoxOscuro(ref boxID);
            //Global.pintarTxtBoxOscuro(ref boxPlazo);

        }

        private void activarTemaClaro()
        {
            this.BackColor = Global.FrmClaro_2;
            //boxID.BackColor = Color.DarkGray;
            //boxID.BorderColor = boxID.BackColor;
            //boxHora.BackColor = boxID.BackColor;
            //boxHora.BorderColor = boxID.BackColor;
            Global.pintarTxtBoxClaro(ref boxDescripcion);
            //Global.pintarTxtBoxClaro(ref boxID);
            //Global.pintarTxtBoxClaro(ref boxPlazo);
        }

        private void cargarComboBox()
        {
            comboBoxEstado.Items.Add("Pendientes");
            comboBoxEstado.Items.Add("Completadas");
            comboBoxEstado.SelectedIndex = 0;
        }

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
            if (DateTime.Compare(dateFechaCreacion.Value, dateFechaLimite.Value) > 0)
            {
                MessageBox.Show("La fecha limite debe ser mayor a la fecha de creacion. Intente nuevamente");
                return;
            }
            _daoTareas = new TareasDiariasWS.TareasDiariasWSClient();
            switch (btnSiguiente.Text)
            {
                case "Actualizar":
                    modificarTarea();
                    break;
                case "Agregar":
                    agregarTarea();
                    break;
            }
            this.Dispose();
        }

        private void modificarTarea()
        {
            if (_daoTareas.modificarTarea(tareaAux) >0)
            {
                MessageBox.Show("La tarea ha sido modificada con éxito");
                //if (accionComoAdministrador)
                    notificacion("ACTUALIZACIÓN DE TAREA", "Estimado (a),\n El sistema de Gestión de Riesgos e Inversiones le informa que se ha modificado la tarea con ID " + tareaAux.idTarea + " : " + tareaAux.descripcion + " . De encontrar algún error en lo comentado escriba un correo a AFPIntegralp2@gmail.com");
                //ventanaTareas.actualizarDGV();
            }
            else
            {
                MessageBox.Show("La tarea no se ha modificado");
            }
        }

        private void agregarTarea()
        {
            if (_daoTareas.insertarTarea(tareaAux)>0)
            {
                MessageBox.Show("La tarea ha sido insertada con éxito");
                //if (accionComoAdministrador)
                    notificacion("ACTUALIZACIÓN DE TAREA", "Estimado (a),\n El sistema de Gestión de Riesgos e Inversiones le informa que se ha agregado la tarea con ID " + tareaAux.idTarea + " : " + tareaAux.descripcion + " . De encontrar algún error en lo comentado escriba un correo a AFPIntegralp2@gmail.com");
                //ventanaTareas.actualizarDGV();
            }
            else
            {
                MessageBox.Show("La tarea no se ha insertado");
            }
        }

        private void cargarDatos()
        {
            tareaAux.fechaCreacion = dateFechaCreacion.Value.ToString("yyyy/MM/dd").Replace("/", "-");
            tareaAux.fechaLimite = dateFechaLimite.Value.ToString("yyyy/MM/dd").Replace("/", "-");
            tareaAux.descripcion = boxDescripcion.Texts;
            tareaAux.descripcion = tareaAux.descripcion.Substring(0, 1).ToUpper() + tareaAux.descripcion.Substring(1).ToLower();
            tareaAux.estado = comboBoxEstado.SelectedIndex;
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
