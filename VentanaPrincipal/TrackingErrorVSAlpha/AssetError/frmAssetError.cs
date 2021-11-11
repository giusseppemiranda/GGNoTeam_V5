using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.AssetError.CalculoTrackingError;
using GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.AssetError.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.AssetError
{
    public partial class frmAssetError : Form
    {
        private frmTEvsAlpha ventanaPadre = null;
        private frmPrincipal ventanaPrincipal = null;

        public frmAssetError(frmPrincipal ventana, frmTEvsAlpha ventana_2)
        {
            InitializeComponent();
            ventanaPrincipal = ventana;
            ventanaPrincipal.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);
            ventanaPadre = ventana_2;
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
            frmEditarRegistroAssetError ventanaAgregar = new frmEditarRegistroAssetError();
            ventanaAgregar.ShowDialog();
        }

        private void btnActualizarRegistro_Click(object sender, EventArgs e)
        {
            frmEditarRegistroAssetError ventanaModificar = new frmEditarRegistroAssetError();
            ventanaModificar.ShowDialog();
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {

        }

        private void dgvAssetError_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVerCalculoTE_Click(object sender, EventArgs e)
        {
            ventanaPadre.abrirFormulario(new frmCalculoTE(ventanaPrincipal));
        }
    }
}
