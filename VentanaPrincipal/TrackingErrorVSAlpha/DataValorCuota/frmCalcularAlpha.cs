using GGNoTeam_V5.Recursos.UserControls;
using System;
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
        //private TrackingErrorWS.fondo[] fondos;
        private TrackingErrorWS.afp[] afps;
        private frmTEvsAlpha ventanaPadre = null;
        public frmCalcularAlpha(frmPrincipal ventana, frmTEvsAlpha ventana_2)
        {
            InitializeComponent();
            ventanaPrincipal = ventana;
            ventanaPrincipal.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);
            ventanaPadre = ventana_2;
            
            cambiarTema();
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
            /*
            string nombre = null;
            double Pho= 0;
            double PT= 0;
            double Ppro= 0;
            double Ppri= 0;
            double Pha= 0;
            double YtoDI = 0;
            double alpha= 0;
            double YtoPro = 0;
            double YtoDHo = 0;
            double YtoDPri = 0;
            double YtoDHa = 0;
            double YtoDSys = 0;
            int idAfp = -1;
            afps = _dao.ListarTodasAfp();
            fondos = _dao.listarTodosFondo();
            TrackingErrorWS.fondo aux = new TrackingErrorWS.fondo();
            foreach (DataGridViewRow row in dgvDataValorCuota.Rows)
            {
                var data = row.DataBoundItem as TrackingErrorWS.dataValorCuota;
                PT += data.patrimonio;
            }
            foreach (DataGridViewRow row in dgvDataValorCuota.Rows)
            {
                var data = row.DataBoundItem as TrackingErrorWS.dataValorCuota;
                //agregar fidFondo en los mysql y procedures en workbench y funciona xd 
                foreach (var fondo in fondos)   if (data.fidFondo == fondo.idFondo) idAfp = fondo.fidAFP;
                foreach (var afp in afps) if (idAfp == afp.idAFP) nombre = afp.nombre;
                
                if (nombre == "integra") YtoDI += YtoDI + (data.valorCuota/data.cuotas);
                if (nombre == "horizonte")
                {
                    Pho += data.patrimonio / PT;
                    YtoDHo += data.ytoD;
                }
                if (nombre == "profuturo")
                {
                    Ppro += data.patrimonio / PT;
                    YtoPro += data.ytoD;
                }
                if (nombre == "pri")
                {
                    Ppri += data.patrimonio / PT;
                    YtoDPri += data.ytoD;
                }
                if (nombre == "ha")
                {
                    Pha += data.patrimonio / PT;
                    YtoDHa += data.ytoD;
                }
                
            }
            YtoDSys = (YtoDHo * Pho) + (Ppro * YtoPro) + (Ppri * YtoDPri) + (Pha * YtoDHa);
            alpha = YtoDI- YtoDSys; 
            ggTextBox1.Texts = alpha.ToString();
            */
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
                            outputCsv[dgvDataValorCuota.Rows.Count] = ggTextBox1.Texts + "," + ggTextBox2.Texts + "," + ggTextBox3.Texts + ",";

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
