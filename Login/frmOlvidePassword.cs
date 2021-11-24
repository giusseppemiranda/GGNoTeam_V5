using GGNoTeam_V5.Recursos.sendMail;
using GGNoTeam_V5.Recursos.UserControls;
using System;
using System.Windows.Forms;

namespace GGNoTeam_V5.Login
{
    public partial class frmOlvidePassword : Form
    {
        frmLogin ventanaPadre;
        private LoginWS.LoginWSClient _daoLogin;
        private LoginWS.persona persona;
        private Random codigo;

        public frmOlvidePassword(frmLogin ventanaAnterior)
        {
            InitializeComponent();
            _daoLogin = new LoginWS.LoginWSClient();
            ventanaPadre = ventanaAnterior;
            cambiarTema();
        }        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtboxUser_Enter(object sender, EventArgs e)
        {
            lblIDCorreo.ForeColor = txtboxUser.BorderFocusColor;
        }

        private void txtboxUser_Leave(object sender, EventArgs e)
        {
            lblIDCorreo.ForeColor = txtboxUser.BorderColor;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ventanaPadre.show();
            this.Dispose();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (usuarioExiste(txtboxUser.Texts.ToString()))
            {
                frmCodigoValidacion ventana = new frmCodigoValidacion(txtboxUser.Texts.ToString(), this, persona);
                enviarCorreoUsuario();
                ventana.Show();
                this.Hide();
            }
        }

        private void enviarCorreoUsuario()
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add(persona.correo);
            msg.Subject = "Recuperación de contraseña";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;

            msg.Body = "Para recuperar la contraseña del Sistema de Gestión de Riesgos e Inversión debe ingresar el siguiente código "+persona.validacion+". Si no ha solicitado el código, comuniquese con un administrador";
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new System.Net.Mail.MailAddress("noreply@afpintegra.riesgoseinversion.pe");
                        
            servidorCliente server = new servidorCliente();
            server.sendMessage(msg);
        }

        private bool usuarioExiste(String id)
        {
            bool valido;
            codigo = new Random();

            LoginWS.persona[] usuario = _daoLogin.listarPorCodNom(id);

            if (usuario.Length == 1)
            {
                if (id == usuario[0].codigo)
                {
                    usuario[0].validacion = codigo.Next(1000, 10000).ToString();                                        
                    persona = usuario[0];
                    _daoLogin.modificarPersona(persona);
                    valido = true;
                }
                else
                {
                    lblUsuarioNoEncontrado.Visible = true;
                    valido = false;
                }
            }
            else
            {
                lblUsuarioNoEncontrado.Visible = true;
                valido = false;
            }

            return valido;
        }

        public void cambioPasswordCorrecto()
        {
            ventanaPadre.show();
            this.Dispose();
        }

        public void show()
        {
            this.cambiarTema();
            this.Show();
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
            Global.pintarControlBoxOscuro(ref panelControl, ref lblTitulo, ref btnCerrar, ref btnMinimizar, ref btnTemaOscuro);
            Global.pintarTxtBoxOscuro(ref txtboxUser);
            Global.pintarBtnOscuro(ref btnSiguiente);
        }

        private void activarTemaClaro()
        {
            this.BackColor = Global.FrmClaro;
            Global.pintarControlBoxClaro(ref panelControl, ref lblTitulo, ref btnCerrar, ref btnMinimizar, ref btnTemaOscuro);
            Global.pintarTxtBoxClaro(ref txtboxUser);
            Global.pintarBtnClaro(ref btnSiguiente);
        }
        private void btnTemaOscuro_Click(object sender, EventArgs e)
        {
            cambiarTema();
        }

    }
}
