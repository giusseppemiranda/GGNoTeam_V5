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

namespace GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.AssetError.CalculoTrackingError
{
    public partial class frmCalcularTE : Form
    {
        private frmPrincipal ventanaPrincipal = null;
        private TrackingErrorWS.TrackingErrorWSClient _dao;
        private TrackingErrorWS.assetError[] datos;
        private frmTEvsAlpha ventanaPadre = null;
        private string[] fondos;

        public frmCalcularTE(frmPrincipal ventana, frmTEvsAlpha ventana_2)
        {
            InitializeComponent();
            ventanaPrincipal = ventana;
            ventanaPrincipal.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);
            ventanaPadre = ventana_2;

            _dao = new TrackingErrorWS.TrackingErrorWSClient();

            dgvAssetError.AutoGenerateColumns = false;

            cambiarTema();
            cargarFondos();
            Global.pintarDGV(ref dgvAssetError, Color.DarkSalmon);
        }


        private void cargarFondos()
        {
            fondos = _dao.ListarFondos();
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
            cargarDGV();
            cargarTrackingError();
        }

        private void cargarTrackingError()
        {
            TrackingErrorWS.trackingError[] te;

            te = _dao.ListarTrackingError(dateInicial.Value.ToString("yyyy-MM-dd"));

            if (te != null)
            {
                for (int i = 0; i < te.Length; i++)
                {
                    switch (te[i].fidFondo)
                    {
                        case 1:
                            {
                                boxFondo_1.Texts = te[i].trackingerror.ToString();
                                break;
                            }
                        case 2:
                            {
                                boxFondo_2.Texts = te[i].trackingerror.ToString();
                                break;
                            }
                        case 3:
                            {
                                boxFondo_3.Texts = te[i].trackingerror.ToString();
                                break;
                            }
                    }
                }
            }
        }

        private void cargarDGV()
        {
            datos = _dao.ListarAssetErrorXFecha(dateInicial.Value.ToString("yyyy-MM-dd"));
            if (datos != null)
            {
                dgvAssetError.DataSource = datos;
            }
        }

        private void dgvAssetError_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            TrackingErrorWS.assetError asset = (TrackingErrorWS.assetError)dgvAssetError.Rows[e.RowIndex].DataBoundItem;

            dgvAssetError.Rows[e.RowIndex].Cells[0].Value = asset.fecha.ToString("dd/MM/yyyy");
            dgvAssetError.Rows[e.RowIndex].Cells[1].Value = fondos[asset.fidFondo - 1];
            dgvAssetError.Rows[e.RowIndex].Cells[2].Value = asset.nombre;
            dgvAssetError.Rows[e.RowIndex].Cells[3].Value = asset.wgtP;
            dgvAssetError.Rows[e.RowIndex].Cells[4].Value = asset.totalRiskD;
            dgvAssetError.Rows[e.RowIndex].Cells[5].Value = asset.wgtP * asset.totalRiskD;
        }

        private void ggTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFondo_3_Click(object sender, EventArgs e)
        {

        }
    }
}
