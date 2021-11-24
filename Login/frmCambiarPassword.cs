using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GGNoTeam_V5.Recursos.UserControls;

namespace GGNoTeam_V5.Login
{
    public partial class frmCambiarPassword : Form
    {
        frmCodigoValidacion ventanaPadre;
        LoginWS.persona persona;
        LoginWS.LoginWSClient _daoLogin;

        public frmCambiarPassword(frmCodigoValidacion ventanaAnterior, LoginWS.persona persona)
        {
            InitializeComponent();
            ventanaPadre = ventanaAnterior;
            this.persona = persona;
            _daoLogin = new LoginWS.LoginWSClient();

            cambiarTema();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ventanaPadre.show();
            this.Dispose();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (txtboxPrimeraPassword.Texts == txtboxSegundaPassword.Texts)
            {
                persona.contraseña = txtboxPrimeraPassword.Texts;
                _daoLogin.modificarPersona(persona);
                MessageBox.Show("Contraseña correctamente modificada");

                this.cambioPasswordCorrecto();
            }
            else
            {
                lblPasswordIncorrecto.Visible = true;
            }

            
        }
        private void cambioPasswordCorrecto()
        {
            ventanaPadre.cambioPasswordCorrecto();
            this.Dispose();
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
            Global.pintarTxtBoxOscuro(ref txtboxPrimeraPassword);
            Global.pintarTxtBoxOscuro(ref txtboxSegundaPassword);
            Global.pintarBtnOscuro(ref btnSiguiente);
        }

        private void activarTemaClaro()
        {
            this.BackColor = Global.FrmClaro;
            Global.pintarControlBoxClaro(ref panelControl, ref lblTitulo, ref btnCerrar, ref btnMinimizar, ref btnTemaOscuro);
            Global.pintarTxtBoxClaro(ref txtboxPrimeraPassword);
            Global.pintarTxtBoxClaro(ref txtboxSegundaPassword);
            Global.pintarBtnClaro(ref btnSiguiente);
        }

        private void btnTemaOscuro_Click(object sender, EventArgs e)
        {
            cambiarTema();
        }


        private void txtboxPrimeraPassword__TextChanged(object sender, EventArgs e)
        {
            string pass = txtboxPrimeraPassword.Texts;
            if(txtboxPrimeraPassword.Texts.Length >= 15)
            {
                txtboxPrimeraPassword.Texts = pass;
            }
        }

        private void txtboxSegundaPassword__TextChanged(object sender, EventArgs e)
        {
            string pass = txtboxSegundaPassword.Texts;
            if (txtboxPrimeraPassword.Texts.Length >= 15)
            {
                txtboxSegundaPassword.Texts = pass;
            }
        }
    }
}
