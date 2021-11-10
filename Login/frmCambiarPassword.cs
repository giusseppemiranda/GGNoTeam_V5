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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

                // Se debe colocar AQUI el código para cambiar el password dentro de la base de datos
                //
                //
                //
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

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
