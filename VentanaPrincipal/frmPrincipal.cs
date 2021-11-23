using System;
using System.Windows.Forms;
using FontAwesome.Sharp;
using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.VentanaPrincipal.Bienvenida;
using GGNoTeam_V5.VentanaPrincipal.GestionInstrumentosOriginadores;
using GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha;
using GGNoTeam_V5.Recursos.sendMail;
using GGNoTeam_V5.VentanaPrincipal.Bandeja_de_Entrada;
using GGNoTeam_V5.VentanaPrincipal.TareasPendientes.Tareas;

namespace GGNoTeam_V5.VentanaPrincipal
{
    public partial class frmPrincipal : Form
    {

        public static Form frmActivo = null;
        private frmLogin ventanaPadre;
        private IconButton iconoActivo = null;
        private LoginWS.persona usuario;

        public delegate void delegadoCambiarTema();
        public event delegadoCambiarTema eventoCambiarTema;

        public frmPrincipal(frmLogin ventana, LoginWS.persona persona)
        {
            InitializeComponent();
            abrirFormulario(new frmBienvenida(this, persona));
            usuario = persona;
            ventanaPadre = ventana;
            cargarPantallaSegunTipoUsuario();
            cambiarTema();
        }

        private void cargarPantallaSegunTipoUsuario()
        {
            if (usuario.tipoUsuario == 2)
            {
                btnUsuarios.Visible = false;
                btnBandejaEntrada.Visible = false;
                lblUser.Text = "Usuario " + usuario.codigo + ":  " + usuario.nombre + " " + usuario.apellidos;
            }
            else
            {
                lblUser.Text = "Administrador: " + usuario.nombre + " " + usuario.apellidos;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnTemaOscuro_Click(object sender, EventArgs e)
        {
            cambiarTema();
            eventoCambiarTema();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void cambiarTema()
        {
            if (!Global.TemaOscuro)
            {
                activarTemaClaro();
                Global.TemaOscuro = true;
            }
            else
            {
                activarTemaOscuro();
                Global.TemaOscuro = false;
            }
        }
        private void activarTemaOscuro()
        {
            this.BackColor = Global.FrmOscuro;
            this.panelCentral.BackColor = Global.FrmOscuro;
            Global.pintarControlBoxOscuro(ref panelControl, ref lblTitulo, ref btnCerrar, ref btnMinimizar, ref btnTemaOscuro);
            lblUser.ForeColor = lblTitulo.ForeColor;
            Global.pintarMenuNavegacionOscuro(ref panelMenu, ref btnMenu, ref btnSignOut, ref btnUsuarios, ref btnHome, ref btnTEALPHA, ref btnMonitoreoOrdenes, ref btnOriginadorInstrumento, ref btnBandejaEntrada);
            if (iconoActivo != null)
            {
                iconoActivo.BackColor = this.BackColor;
            }
        }

        private void activarTemaClaro()
        {
            this.BackColor = Global.FrmClaro;
            this.panelCentral.BackColor = Global.FrmClaro;
            Global.pintarControlBoxClaro(ref panelControl, ref lblTitulo, ref btnCerrar, ref btnMinimizar, ref btnTemaOscuro);
            lblUser.ForeColor = lblTitulo.ForeColor;
            Global.pintarMenuNavegacionClaro(ref panelMenu, ref btnMenu, ref btnSignOut, ref btnUsuarios, ref btnHome, ref btnTEALPHA, ref btnMonitoreoOrdenes, ref btnOriginadorInstrumento, ref btnBandejaEntrada);
            if (iconoActivo != null)
            {
                iconoActivo.BackColor = this.BackColor;
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            panelCentral.Visible = false;
            panelMenu.Visible = true;
        }

        private void abrirFormulario(Form formulario)
        {
            if (frmActivo != null)
            {
                frmActivo.Dispose();
            }
            frmActivo = formulario;
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(formulario);
            formulario.Show();
        }

        public void mostrarMenu()
        {
            panelMenu.Visible = true;
        }

        public void mostrarLogo()
        {
            abrirFormulario(new frmImagenAFP(this));
        }


        private void btnSignOut_Click(object sender, EventArgs e)
        {

            ventanaPadre.activarTemaClaro();
            ventanaPadre.Show();
            Global.TemaOscuro = false;
            this.Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmGestionUsuarios(this, usuario));
            cambiarTemaIconosMenu(ref iconoActivo);
            iconoActivo = btnUsuarios;
            iconoActivo.BackColor = this.BackColor;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            mostrarTareasPendientes();
            cambiarTemaIconosMenu(ref iconoActivo);
            iconoActivo = btnHome;
            iconoActivo.BackColor = this.BackColor;
        }

        public void mostrarTareasPendientes()
        {
            abrirFormulario(new frmPropiasTareasPendientes(this, usuario));
        }

        private void cambiarTemaIconosMenu(ref IconButton icono)
        {
            if (icono != null)
            {
                if (Global.TemaOscuro)
                {
                    Global.pintarBotonMenuClaro(ref icono);
                }
                else
                {
                    Global.pintarBotonMenuOscuro(ref icono);
                }
            }
        }

        private void btnTEALPHA_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmTEvsAlpha(this));
            cambiarTemaIconosMenu(ref iconoActivo);
            iconoActivo = btnTEALPHA;
            iconoActivo.BackColor = this.BackColor;
        }


        private void btnUsuarios_MouseEnter(object sender, EventArgs e)
        {
            this.panelMenu.Size = new System.Drawing.Size(200, 547);
            btnTEALPHA.Text = btnTEALPHA.Tag.ToString();
            btnUsuarios.Text = btnUsuarios.Tag.ToString();
            btnHome.Text = btnHome.Tag.ToString();
            btnSignOut.Text = btnSignOut.Tag.ToString();
            btnMonitoreoOrdenes.Text = btnMonitoreoOrdenes.Tag.ToString();
            btnOriginadorInstrumento.Text = btnOriginadorInstrumento.Tag.ToString();
            btnBandejaEntrada.Text = btnBandejaEntrada.Tag.ToString();
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            this.panelMenu.Size = new System.Drawing.Size(43, 547);
            btnTEALPHA.Text = "";
            btnUsuarios.Text = "";
            btnHome.Text = "";
            btnSignOut.Text = "";
            btnMonitoreoOrdenes.Text = "";
            btnOriginadorInstrumento.Text = "";
            btnBandejaEntrada.Text = "";

        }

        private void btnMonitoreoOrdenes_Click(object sender, EventArgs e)
        {

            cambiarTemaIconosMenu(ref iconoActivo);
            iconoActivo = btnMonitoreoOrdenes;
            iconoActivo.BackColor = this.BackColor;
        }

        private void btnOriginadorInstrumento_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmGestionOriginadoresInstrumentos(this));
            cambiarTemaIconosMenu(ref iconoActivo);
            iconoActivo = btnOriginadorInstrumento;
            iconoActivo.BackColor = this.BackColor;
        }

        private void btnBandejaEntrada_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmGmail(this));
            cambiarTemaIconosMenu(ref iconoActivo);
            iconoActivo = btnBandejaEntrada;
            iconoActivo.BackColor = this.BackColor;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
