using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.DataValorCuota.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvAssetError.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (.csv)|.csv";
                sfd.FileName = "DataCriticaTrackingError.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("No fue posible exportar los datos." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dgvAssetError.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dgvAssetError.Rows.Count + 3];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dgvAssetError.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dgvAssetError.Rows.Count - 2; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dgvAssetError.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            outputCsv[dgvAssetError.Rows.Count-1] = "Fondo 1,Fondo 2,Fondo 3,";
                            outputCsv[dgvAssetError.Rows.Count] = boxFondo_1.Texts + "," + boxFondo_2.Texts + "," + boxFondo_3.Texts + ",";

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Reporte exportado correctamente!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay datos para exportar", "Info");

            }
        }
    }
}
