using GGNoTeam_V5.Recursos.UserControls;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.DataValorCuota
{
    public partial class frmCalcularAlpha : Form
    {
        private frmPrincipal ventanaPrincipal = null;
        private TrackingErrorWS.TrackingErrorWSClient _dao;
        private TrackingErrorWS.dataValorCuota[] datos;
        private TrackingErrorWS.afp[] listaAfps;
        private TrackingErrorWS.alpha[] listaAlphas;
        private string[] fondos = { "Fondo 1", "Fondo 2", "Fondo 3" };
        private frmTEvsAlpha ventanaPadre = null;
        public frmCalcularAlpha(frmPrincipal ventana, frmTEvsAlpha ventana_2)
        {
            InitializeComponent();
            ventanaPrincipal = ventana;
            ventanaPrincipal.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);
            ventanaPadre = ventana_2;

            _dao = new TrackingErrorWS.TrackingErrorWSClient();
            dgvDataValorCuota.AutoGenerateColumns = false;

            Global.pintarDGV(ref dgvDataValorCuota, Color.DarkSalmon);
            cambiarTema();
            cargarNombresAFP();
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

        private void cargarNombresAFP()
        {
            listaAfps = _dao.ListarTodasAfp();
        }


        private void btnConsultarRegistros_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            dgvDataValorCuota.comenzarHilo();
            datos = _dao.listarDataValorCuotaXFecha(dateInicial.Value.ToString("yyyy-MM-dd"));
            listaAlphas = _dao.listarAlphaXFecha(dateInicial.Value.ToString("yyyy-MM-dd"));
            if (datos != null)
            {
                dgvDataValorCuota.setDataSource1(datos);
                boxAlpha_1.Texts = listaAlphas[0].alpha1.ToString();
                boxAlpha_2.Texts = listaAlphas[1].alpha1.ToString();
                boxAlpha_3.Texts = listaAlphas[2].alpha1.ToString();
            }
            else
            {
                dgvDataValorCuota.setDataSource1(null);
                boxAlpha_1.Texts = "";
                boxAlpha_2.Texts = "";
                boxAlpha_3.Texts = "";
            }
            this.Cursor = Cursors.Default;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvDataValorCuota.Rows.Count > 0)
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
                            int columnCount = dgvDataValorCuota.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dgvDataValorCuota.Rows.Count + 3];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dgvDataValorCuota.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dgvDataValorCuota.Rows.Count - 2; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dgvDataValorCuota.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            outputCsv[dgvDataValorCuota.Rows.Count - 1] = "Fondo 1,Fondo 2,Fondo 3,";
                            outputCsv[dgvDataValorCuota.Rows.Count] = boxAlpha_1.Texts + "," + boxAlpha_2.Texts + "," + boxAlpha_3.Texts + ",";

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


        private void dgvDataValorCuota_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            TrackingErrorWS.dataValorCuota dvc = (TrackingErrorWS.dataValorCuota)dgvDataValorCuota.Rows[e.RowIndex].DataBoundItem;
            int fondoindex;
            int afpindex;

            dgvDataValorCuota.Rows[e.RowIndex].Cells[0].Value = dvc.idDataValorCuota;
            dgvDataValorCuota.Rows[e.RowIndex].Cells[1].Value = dvc.fecha.ToString("dd/MM/yyyy");
            afpindex = (int)((dvc.fidAFP - 1) / 3);
            fondoindex = dvc.fidAFP - (afpindex * 3) - 1;

            dgvDataValorCuota.Rows[e.RowIndex].Cells[2].Value = listaAfps[afpindex].nombre;
            dgvDataValorCuota.Rows[e.RowIndex].Cells[3].Value = fondos[fondoindex];
            dgvDataValorCuota.Rows[e.RowIndex].Cells[4].Value = dvc.cuotas;
            dgvDataValorCuota.Rows[e.RowIndex].Cells[5].Value = dvc.valorCuota;
            dgvDataValorCuota.Rows[e.RowIndex].Cells[6].Value = dvc.patrimonio;
            dgvDataValorCuota.Rows[e.RowIndex].Cells[7].Value = dvc.patrimonio * dvc.valorCuota / dvc.cuotas;
        }
    }
}
