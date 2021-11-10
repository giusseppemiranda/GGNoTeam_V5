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

namespace GGNoTeam_V5.VentanaPrincipal
{
    public partial class frmBienvenida : Form
    {
        private frmPrincipal ventanaPadre;

        public frmBienvenida(frmPrincipal ventana, LoginWS.persona usuario)
        {
            InitializeComponent();            
            iniciarTema();
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);                        
            lblFecha.Text = DateTime.Now.ToString("dddd d") + " de " + DateTime.Now.ToString("MMMM") + " del " + DateTime.Now.ToString("yyyy");
            lblNombreUsuario.Text = usuario.nombre + " " + usuario.apellidos;
        }

        private void VentanaPadre_eventoCambiarTema()
        {
            throw new NotImplementedException();
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void iniciarTema()
        {
            if (!Global.TemaOscuro)
            {
                activarTemaClaro();                
            }
            else
            {
                activarTemaOscuro();                
            }
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
            Global.pintarBtnOscuro(ref btnContinuar);            
        }

        private void activarTemaClaro()
        {
            this.BackColor = Global.FrmClaro;            
            Global.pintarBtnClaro(ref btnContinuar);           
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            ventanaPadre.mostrarMenu();
            ventanaPadre.mostrarLogo();
            //ventanaPadre.mostrarTareasPendientes();
            this.Close();
        }
    }
}
