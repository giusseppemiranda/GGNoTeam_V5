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
        private TrackingErrorWS.TrackingErrorWSClient _daoTE;
        private TrackingErrorWS.assetError[] listaAsset;

        public frmAssetError(frmPrincipal ventana, frmTEvsAlpha ventana_2)
        {
            InitializeComponent();
            ventanaPrincipal = ventana;
            ventanaPrincipal.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);

            ventanaPadre = ventana_2;
            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();
            dgvAssetError.AutoGenerateColumns = false;

            cargarCombo();
            cambiarTema();
            Global.pintarDGV(ref dgvAssetError, Color.DarkSalmon);
        }

        private void cargarCombo()
        {
            String[] fondos = _daoTE.ListarFondos();
            comboFondo.DataSource = fondos;
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
            listaAsset = _daoTE.ListarPorFechaPorFondoAssetError(dateInicial.Value.ToString("yyyy-MM-dd"), dateFinal.Value.ToString("yyyy-MM-dd"), comboFondo.SelectedIndex + 1);
            if (listaAsset != null)
            {
                dgvAssetError.DataSource = listaAsset;
            }else
            {
                dgvAssetError.DataSource = null;
            }
            
        }

        private void btnAgregarRegistros_Click(object sender, EventArgs e)
        {
            frmEditarRegistroAssetError ventanaAgregar = new frmEditarRegistroAssetError();
            ventanaAgregar.ShowDialog();
            this.btnConsultarRegistros_Click(sender, e);
        }

        private void btnActualizarRegistro_Click(object sender, EventArgs e)
        {
            if (listaAsset != null)
            {
                frmEditarRegistroAssetError ventanaModificar = new frmEditarRegistroAssetError(listaAsset[dgvAssetError.CurrentRow.Index]);
                ventanaModificar.ShowDialog();
                this.btnConsultarRegistros_Click(sender, e);
            }
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            if (listaAsset != null)
            {
                int procesoValido = _daoTE.eliminarAssetError(listaAsset[dgvAssetError.CurrentRow.Index].idAssetError);
                if (procesoValido != 1)
                {
                    MessageBox.Show("No se ha podido eliminar el elemento seleccionado. Intente nuevamente.");
                }
            }
            this.btnConsultarRegistros_Click(sender, e);
        }

        private void btnVerCalculoTE_Click(object sender, EventArgs e)
        {
            ventanaPadre.abrirFormulario(new frmCalcularTE(ventanaPrincipal, ventanaPadre));
        }

        private void comboFondo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnConsultarRegistros_Click(sender, e);
        }

        private void dgvAssetError_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            TrackingErrorWS.assetError dvc = (TrackingErrorWS.assetError)dgvAssetError.Rows[e.RowIndex].DataBoundItem;
            dgvAssetError.Rows[e.RowIndex].Cells[0].Value = dvc.fecha.ToString("dd-MM-yyyy");
            dgvAssetError.Rows[e.RowIndex].Cells[1].Value = comboFondo.SelectedItem.ToString();
            dgvAssetError.Rows[e.RowIndex].Cells[2].Value = dvc.nombre;
            dgvAssetError.Rows[e.RowIndex].Cells[3].Value = dvc.wgtP;
            dgvAssetError.Rows[e.RowIndex].Cells[4].Value = dvc.totalRiskD;            
        }
    }
}
