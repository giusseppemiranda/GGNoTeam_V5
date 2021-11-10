using GGNoTeam_V5.Recursos.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.Bienvenida
{
    public partial class frmImagenAFP : Form
    {
        private frmPrincipal ventanaPadre;
        public frmImagenAFP(frmPrincipal ventana)
        {
            InitializeComponent();
            iniciarTema();
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);
        }

        private void iniciarTema()
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
    }
}
