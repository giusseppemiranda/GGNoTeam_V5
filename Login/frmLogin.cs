using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.Login;
using GGNoTeam_V5.VentanaPrincipal;
using System.Collections;

namespace GGNoTeam_V5
{
    public partial class frmLogin : Form
    {

        private LoginWS.LoginWSClient _daoLogin;
        private LoginWS.persona persona;

        public frmLogin()
        {            
            InitializeComponent();
            _daoLogin = new LoginWS.LoginWSClient();                        

            this.FormBorderStyle = FormBorderStyle.None;
            lblUser.ForeColor = txtboxUsername.BorderColor;
            lblPassword.ForeColor = txtboxPassword.BorderColor;
            lblCredencialesIncorrectas.Visible = false;
            activarTemaClaro();
        }

        private void txtboxUsername_Enter(object sender, EventArgs e)
        {
            lblUser.ForeColor = txtboxUsername.BorderFocusColor;
        }

        private void txtboxUsername_Leave(object sender, EventArgs e)
        {
            lblUser.ForeColor = txtboxUsername.BorderColor;
        }

        private void txtboxPassword_Enter(object sender, EventArgs e)
        {
            lblPassword.ForeColor = txtboxPassword.BorderFocusColor;
        }

        private void txtboxPassword_Leave(object sender, EventArgs e)
        {
            lblPassword.ForeColor = txtboxPassword.BorderColor;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            String usuario = txtboxUsername.Texts.ToString();
            String password = txtboxPassword.Texts.ToString();

            if (UsuarioAutorizado(usuario, password))
            {
                frmPrincipal pricipal = new frmPrincipal(this,persona);
                pricipal.Show();
                txtboxPassword.Texts = "";
                
                this.Hide();
            }
        }

        private bool UsuarioAutorizado(String user, String password)
        {
            bool usuarioValido = false;
            lblCredencialesIncorrectas.Visible = false;

            //ArrayList datosPersona = new ArrayList();

            LoginWS.persona[] usuario = _daoLogin.listarPorCodNom(user);

            if (usuario!= null)
            {
                if (usuario.Length == 1)
                {
                    if (user == usuario[0].codigo && usuario[0].tipoUsuario != 3)
                    {
                        if (password == usuario[0].contraseña)
                        {
                            persona = usuario[0];                        
                            usuarioValido = true;
                        }
                        else
                        {
                            usuarioValido = false;
                            lblCredencialesIncorrectas.Visible = true;
                        }
                    }
                    else
                    {
                        usuarioValido = false;
                        lblCredencialesIncorrectas.Visible = true;
                    }
                }
            }
            else
            {
                lblCredencialesIncorrectas.Visible = true;
                usuarioValido = false;
            }





            ////////////////////////////////////////////////////////
            // Caso ejemplo utilizado para verificar
            //if (user == "admin" || user == "usuario")
            //{
            //    if (password == "1234")
            //    {
            //        usuarioValido = true;
            //    }
            //    else
            //    {
            //        usuarioValido = false;
            //        lblCredencialesIncorrectas.Visible = true;
            //    }
            //}
            //else
            //{
            //    lblCredencialesIncorrectas.Visible = true;

            //    usuarioValido = false;
            //}
            /////////////////////////////////////////////////////////

            return usuarioValido;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPasswordOlvidada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            frmOlvidePassword ventana = new frmOlvidePassword(this);
            ventana.Show();
            this.Hide();
        }

        private void btnTemaOscuro_Click(object sender, EventArgs e)
        {
            cambiarTema();
        }



        public void cambiarTema()
        {
            if (Global.TemaOscuro)
            {
                activarTemaClaro();
                Global.TemaOscuro = false;
            }
            else
            {
                activarTemaOscuro();
                Global.TemaOscuro = true;
            }
        }

        public void activarTemaOscuro()
        {
            this.BackColor = Global.FrmOscuro;
            Global.pintarControlBoxOscuro(ref panelControl, ref lblTitulo, ref btnCerrar, ref btnMinimizar, ref btnTemaOscuro);
            Global.pintarTxtBoxOscuro(ref txtboxUsername);
            Global.pintarTxtBoxOscuro(ref txtboxPassword);
            Global.pintarBtnOscuro(ref btnIniciarSesion);
            Global.pintarLinkOscuro(ref lblPasswordOlvidada);            
        }

        public void activarTemaClaro()
        {
            this.BackColor = Global.FrmClaro;
            Global.pintarControlBoxClaro(ref panelControl, ref lblTitulo, ref btnCerrar, ref btnMinimizar, ref btnTemaOscuro);
            Global.pintarTxtBoxClaro(ref txtboxUsername);
            Global.pintarTxtBoxClaro(ref txtboxPassword);
            Global.pintarBtnClaro(ref btnIniciarSesion);
            Global.pintarLinkClaro(ref lblPasswordOlvidada);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        public void show()
        {
            this.cambiarTema();
            this.Show();
        }





























        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }


        
    }       
}

