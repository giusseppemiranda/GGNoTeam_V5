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
    public partial class frmCodigoValidacion : Form
    {

        frmOlvidePassword ventanaPadre;        
        LoginWS.LoginWSClient cliente;
        LoginWS.persona[] persona;

        public frmCodigoValidacion(String idUser, frmOlvidePassword ventanaAnterior, LoginWS.persona usuario)
        {
            String descripcion;

            if (idUser.Contains("@"))
            {
                descripcion = "Se ha enviado un correo a " + idUser + " con el código de acceso para reestablecer la contraseña. Si no observa dicho código en su bandeja comuníquese con un administrador";
            }
            else
            {
                descripcion = "Se ha enviado un mensaje a la dirección de correo asociada al usuario " + idUser + " con el código de acceso para reestablecer la contraseña.\n Si no observa dicho código en su bandeja comuníquese con un administrador.";
            }
            InitializeComponent();
            cliente = new LoginWS.LoginWSClient();
            persona = cliente.listarPorCodNom(usuario.codigo);
            lblDescripcion.Text = descripcion;
            ventanaPadre = ventanaAnterior;
            cambiarTema();
        }

        private void frmCodigoValidacion_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ventanaPadre.show();
            this.Dispose();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (codigoValido())
            {
                frmCambiarPassword ventana = new frmCambiarPassword(this,persona[0]);
                ventana.Show();
                this.Hide();
            }
            else
            {
                cod_1.Texts = "";
                cod_2.Texts = "";
                cod_3.Texts = "";
                cod_4.Texts = "";
                lblCodigoIncorrecto.Visible = true;
            }
        }

        private bool codigoValido()
        {
            bool valido = false;
            string codigo;

            codigo = cod_1.Texts + cod_2.Texts + cod_3.Texts + cod_4.Texts;

            // Aqui debería ir el código de validación
            //
            //
            //
            if (codigo == persona[0].validacion)
            {
                valido = true;
            } else
            {
                valido = false;
            }


            ////////////////////////////////////////////////////////
            // Caso ejemplo utilizado para verificar
            //if (codigo == "1234")
            //{
            //    valido = true;
            //}
            //else
            //{
            //    valido = false;
            //}

            /////////////////////////////////////////////////////////
            ///
            return valido;
        }


        private void cod_1_Leave(object sender, EventArgs e)
        {
            if (cod_1.Texts == "")
            {
                cod_1.BorderColor = Global.TxtboxClaro_Border;
            }
            else
            {
                cod_1.BorderColor = Color.ForestGreen;
            }
        }

        private void cod_2_Leave(object sender, EventArgs e)
        {
            if (cod_2.Texts == "")
            {
                cod_2.BorderColor = Global.TxtboxClaro_Border;
            }
            else
            {
                cod_2.BorderColor = Color.ForestGreen;
            }
        }

        private void cod_3_Leave(object sender, EventArgs e)
        {
            if (cod_3.Texts == "")
            {
                cod_3.BorderColor = Global.TxtboxClaro_Border;
            }
            else
            {
                cod_3.BorderColor = Color.ForestGreen;
            }
        }

        private void cod_4_Leave(object sender, EventArgs e)
        {
            if (cod_4.Texts == "")
            {
                cod_4.BorderColor = Global.TxtboxClaro_Border;
            }
            else
            {
                cod_4.BorderColor = Color.ForestGreen;
            }
        }

        private void cod_1__TextChanged(object sender, EventArgs e)
        {
            if (cod_1.Text != "")
            {
                cod_2.Focus();
            }
        }

        private void cod_2__TextChanged(object sender, EventArgs e)
        {
            if (cod_2.Text != "")
            {
                cod_3.Focus();
            }
        }

        private void cod_3__TextChanged(object sender, EventArgs e)
        {
            if (cod_3.Text != "")
            {
                cod_4.Focus();
            }
        }

        private void cod_4__TextChanged(object sender, EventArgs e)
        {

        }

        public void cambioPasswordCorrecto()
        {
            ventanaPadre.cambioPasswordCorrecto();
            this.Dispose();
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
        private void activarTemaOscuro()
        {
            this.BackColor = Global.FrmOscuro;
            Global.pintarControlBoxOscuro(ref panelControl, ref lblTitulo, ref btnCerrar, ref btnMinimizar, ref btnTemaOscuro);
            Global.pintarTxtBoxOscuro(ref cod_1);
            Global.pintarTxtBoxOscuro(ref cod_2);
            Global.pintarTxtBoxOscuro(ref cod_3);
            Global.pintarTxtBoxOscuro(ref cod_4);
            Global.pintarBtnOscuro(ref btnSiguiente);
        }

        private void activarTemaClaro()
        {
            this.BackColor = Global.FrmClaro;
            Global.pintarControlBoxClaro(ref panelControl, ref lblTitulo, ref btnCerrar, ref btnMinimizar, ref btnTemaOscuro);
            Global.pintarTxtBoxClaro(ref cod_1);
            Global.pintarTxtBoxClaro(ref cod_2);
            Global.pintarTxtBoxClaro(ref cod_3);
            Global.pintarTxtBoxClaro(ref cod_4);
            Global.pintarBtnClaro(ref btnSiguiente);
        }

        public void show()
        {
            this.cambiarTema();
            this.Show();
        }

        private void btnTemaOscuro_Click(object sender, EventArgs e)
        {
            cambiarTema();
        }
    }
}
