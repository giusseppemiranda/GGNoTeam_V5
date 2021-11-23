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
        public frmTareasPendientes(frmPrincipal ventana, LoginWS.persona persona)
        {
            InitializeComponent();
            cargarCombo();
            cambiarTema();
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);

            _daoTareasDiarias = new TareasDiariasWS.TareasDiariasWSClient();
            _daoPersona = new LoginWS.LoginWSClient();
            persona = _daoPersona.listarPorCodExacto(Int32.Parse(persona.codigo))[0];
            user = persona;
            accionAdmin = true;

            cargarLabelInicial();
            cargarDatosPorTipoUsuario();
            pintarDGVInicial();
            colocarEnDGV(user.itinerario.listaTarea);
        }

        public frmTareasPendientes(LoginWS.persona persona)
        {
            InitializeComponent();
            cargarCombo();
            cambiarTema();
            btnSalir.Visible = true;
            user = persona;

            _daoTareasDiarias = new TareasDiariasWS.TareasDiariasWSClient();
            _daoPersona = new LoginWS.LoginWSClient();

            colocarEnDGV(persona.itinerario.listaTarea);
            cargarLabelInicial();
            pintarDGVInicial();
            cargarSubTema();
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

        private void colocarEnDGV(LoginWS.tarea[] lista)
        {
            dgvTareasPendientes.Rows.Clear();
            if (lista != null)
            {
                for (int i = 0; i < lista.Length; i++)
                {
                    if (lista[i].estado == true)
                    {
                        //dgvTareasPendientes.Rows.Add(lista[i].idTarea, lista[i].descripcion, lista[i].horaEst, lista[i].plazo, "Completo");
                        dgvTareasPendientes.Rows.Add(lista[i].idTarea, "Completo", lista[i].descripcion);
                    }
                    else
                    {
                        //dgvTareasPendientes.Rows.Add(lista[i].idTarea, lista[i].descripcion, lista[i].horaEst, lista[i].plazo, "Incompleto");
                        dgvTareasPendientes.Rows.Add(lista[i].idTarea, "Incompleto", lista[i].descripcion);
                    }
                }
            }
        }

        public void actualizarDGV()
        {
            user = _daoPersona.listarPorCodExacto(Int32.Parse(user.codigo))[0];
            dgvTareasPendientes.Rows.Clear();
            colocarEnDGV(user.itinerario.listaTarea);
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

        private void dgvTareasPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            frmEditarTarea ventanaAgregar = new frmEditarTarea(this, user.itinerario.idItineraio, accionAdmin);
            ventanaAgregar.ShowDialog();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmTareasPendientes_Load(object sender, EventArgs e)
        {

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
                        this.actualizarDGV();
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
            if (dgvTareasPendientes.CurrentRow != null)
            {
                frmEditarTarea ventanaModificar = new frmEditarTarea(this, user.itinerario.listaTarea[dgvTareasPendientes.CurrentRow.Index], accionAdmin);
                ventanaModificar.ShowDialog();
            }
        }

        public void enviarNotificacionCorreo(System.Net.Mail.MailMessage msg)
        {
            msg.To.Add(user.correo);
            servidorCliente server = new servidorCliente();
            server.sendMessage(msg);
        }

        private void btnListarPorTipo_Click(object sender, EventArgs e)
        {

            dgvTareasPendientes.Rows.Clear();
            if (listarCompletos)
            {
                user = _daoPersona.listarPorCodExacto_TareasCompletas(Int32.Parse(user.codigo))[0];
                if (user.itinerario.listaTarea != null)
                {
                    for (int i = 0; i < user.itinerario.listaTarea.Length; i++)
                    {
                        dgvTareasPendientes.Rows.Add(user.itinerario.listaTarea[i].idTarea, "Completo", user.itinerario.listaTarea[i].descripcion);
                    }                    
                }
                listarCompletos = false;
                btnListarPorTipo.Text = "Listar Incompletos";
                btnListarPorTipo.IconChar = FontAwesome.Sharp.IconChar.Times;
            }
            else
            {
                user = _daoPersona.listarPorCodExacto_TareasInompletas(Int32.Parse(user.codigo))[0];
                if (user.itinerario.listaTarea != null)
                {
                    for (int i = 0; i < user.itinerario.listaTarea.Length; i++)
                    {
                        dgvTareasPendientes.Rows.Add(user.itinerario.listaTarea[i].idTarea, "Incompleto", user.itinerario.listaTarea[i].descripcion);
                    }                    
                }
                listarCompletos = true;
                btnListarPorTipo.Text = "Listar Completos";
                btnListarPorTipo.IconChar = FontAwesome.Sharp.IconChar.Check;
            }

        }

        private void btnListarCompletos_Click(object sender, EventArgs e)
        {
            user = _daoPersona.listarPorCodExacto(Int32.Parse(user.codigo))[0];
            colocarEnDGV(user.itinerario.listaTarea);
        }
        private void ActualizarPerdidas()
        {
            //listar tareas segun usuario, no conectar al dgv, revisar fecha y comparar con fecha actual, cambiar estado segun fecha
        }
        void comboEstadoTarea_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
