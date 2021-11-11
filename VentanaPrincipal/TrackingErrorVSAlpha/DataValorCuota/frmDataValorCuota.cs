using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.DataValorCuota.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.DataValorCuota
{
    public partial class frmDataValorCuota : Form
    {
        private frmPrincipal ventanaPadre = null;
        public frmDataValorCuota(frmPrincipal ventana)
        {
            InitializeComponent();
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);
            iniciarTema();
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

        private void btnConsultarRegistros_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarRegistros_Click(object sender, EventArgs e)
        {
            frmEditarRegistroDataValorCuota ventanaAgregar = new frmEditarRegistroDataValorCuota();
            ventanaAgregar.ShowDialog();
        }

        private void btnActualizarRegistro_Click(object sender, EventArgs e)
        {
            //Se le debe colocar el dato a modificar
            frmEditarRegistroDataValorCuota ventanaModificar = new frmEditarRegistroDataValorCuota();
            ventanaModificar.ShowDialog();
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {

        }
    }
}
