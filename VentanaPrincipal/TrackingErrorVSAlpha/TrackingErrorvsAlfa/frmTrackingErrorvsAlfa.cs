using GGNoTeam_V5.Recursos.UserControls;
using iTextSharp.text;
using iTextSharp.text.pdf;
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

namespace GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.TrackingErrorvsAlfa
{
    public partial class frmTrackingErrorvsAlfa : Form
    {
        private frmPrincipal ventanaPadre = null;
        private TrackingErrorWS.TrackingErrorWSClient _daoTE;
        private TrackingErrorWS.trackingError[] listaTE;
        private TrackingErrorWS.alpha[] listaAlpha;
        private int fondoActivado = 0;
        public frmTrackingErrorvsAlfa(frmPrincipal ventana)
        {
            InitializeComponent();
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);

            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();

            cambiarTema();
            configurarGraficoTE();
            configurarGraficoAlpha();
        }

        private void agregarLeyendaGraficosAlpha(int fondo)
        {
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();

            legend3.DockedToChartArea = "ChartArea1";
            legend3.Name = "Legend1";
            legend3.Title = "Grafico para el fondo " + fondo.ToString();

            graficoAlpha.Legends.Clear();
            graficoAlpha.Legends.Add(legend3);
        }

        private void agregarLeyendaGraficosTE(int fondo)
        {
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();

            legend3.DockedToChartArea = "ChartArea1";
            legend3.Name = "Legend1";
            legend3.Title = "Grafico para el fondo " + fondo.ToString();

            graficoTE.Legends.Clear();
            graficoTE.Legends.Add(legend3);
        }

        private void configurarGraficoTE()
        {
            //graficoTE.Series["TrackingError"].XValueMember = "fecha";
            //graficoTE.Series["TrackingError"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            //graficoTE.Series["TrackingError"].YValueMembers = "trackingError";
            //graficoTE.Series["TrackingError"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            graficoTE.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            graficoTE.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
        }

        private void configurarGraficoAlpha()
        {
            //graficoAlpha.Series["Alpha"].XValueMember = "fecha";
            //graficoAlpha.Series["Alpha"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            //graficoAlpha.Series["Alpha"].YValueMembers = "alpha1";
            //graficoAlpha.Series["Alpha"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            graficoAlpha.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            graficoAlpha.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
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

        private void btnFondo_1_Click(object sender, EventArgs e)
        {

            obtenerDatosTrackingError(1);
            generarGraficoTrackingError(1);
            obtenerDatosAlpha(1);
            generarGraficoAlpha(1);
        }

        private void btnFondo_2_Click(object sender, EventArgs e)
        {
            obtenerDatosTrackingError(2);
            generarGraficoTrackingError(2);
            obtenerDatosAlpha(2);
            generarGraficoAlpha(2);
        }

        private void btnFondo_3_Click(object sender, EventArgs e)
        {
            obtenerDatosTrackingError(3);
            generarGraficoTrackingError(3);
            obtenerDatosAlpha(3);
            generarGraficoAlpha(3);
        }

        private void obtenerDatosAlpha(int fidFondo)
        {
            listaAlpha = _daoTE.listarAlpha_Fecha_Fondo(dateInicial.Value.ToString("yyyy-MM-dd"), dateFinal.Value.ToString("yyyy-MM-dd"), fidFondo);
        }

        private void generarGraficoAlpha(int fondo)
        {
            graficoAlpha.Series["Alpha"].Points.Clear();
            agregarLeyendaGraficosAlpha(fondo);
            if (listaAlpha != null)
            {
                for (int i = 0; i < listaAlpha.Length; i++)
                {
                    graficoAlpha.Series["Alpha"].Points.AddXY(listaAlpha[i].fecha.ToString("dd-MM-yyyy"), listaAlpha[i].alpha1);
                }
            }
            else
            {
                graficoAlpha.DataSource = null;
            }
            graficoTE.DataBind();
        }

        private void generarGraficoTrackingError(int fondo)
        {
            graficoTE.Series["TrackingError"].Points.Clear();
            agregarLeyendaGraficosTE(fondo);
            if (listaTE != null)
            {
                //graficoTE.DataSource = listaTE;
                for (int i = 0; i < listaTE.Length; i++)
                {
                    graficoTE.Series["TrackingError"].Points.AddXY(listaTE[i].fecha.ToString("dd-MM-yyyy"), listaTE[i].trackingerror);
                }
            }
            else
            {
                graficoTE.DataSource = null;
            }
            graficoTE.DataBind();
        }

        private void obtenerDatosTrackingError(int fidFondo)
        {
            listaTE = _daoTE.ListarTrackingErrorPorFechaPorFondo(dateInicial.Value.ToString("yyyy-MM-dd"), dateFinal.Value.ToString("yyyy-MM-dd"), fidFondo);
            fondoActivado = fidFondo;
        }

        private void btnExportarGraficos_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaTE = folderBrowserDialog1.SelectedPath + "\\" +"_TrackingError_FROM_" + dateInicial.Value.ToString("ddMMyyyy") + "_TO_" + dateFinal.Value.ToString("ddMMyyyy") + ".png";
                string rutaAlpha = folderBrowserDialog1.SelectedPath + "\\"+"_Alpha_FROM_" + dateInicial.Value.ToString("ddMMyyyy") + "_TO_" + dateFinal.Value.ToString("ddMMyyyy") + ".png";
                string rutaPDF = folderBrowserDialog1.SelectedPath + "\\"+ "_TrackingErrorVSAlpha_FROM_" + dateInicial.Value.ToString("ddMMyyyy") + "_TO_" + dateFinal.Value.ToString("ddMMyyyy") + ".pdf"; ;

                graficoTE.SaveImage(rutaTE, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                graficoAlpha.SaveImage(rutaAlpha, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                exportarPDF(rutaPDF, rutaTE, rutaAlpha);
            };
        }

        private void exportarPDF(string ruta, string rutaTE, string rutaAlpha)
        {
            Document doc = new Document(PageSize.A4);
            try
            {

                PdfWriter.GetInstance(doc, new FileStream((ruta), FileMode.Create));

                doc.Open();
                doc.SetMargins(14.1732F, 14.1732F, 14.1732F, 14.1732F);

                iTextSharp.text.Image grafTE = iTextSharp.text.Image.GetInstance(rutaTE);
                iTextSharp.text.Image grafAlpha = iTextSharp.text.Image.GetInstance(rutaAlpha);



                doc.Add(new Paragraph("                             ANÁLISIS DE TRACKING ERROR VS ALPHA          "));
                doc.Add(new Paragraph("=========================================================================="));
                doc.Add(new Paragraph(" TIPO FONDO: " + fondoActivado));
                doc.Add(new Paragraph(" DESDE:      " + dateInicial.Value.ToString("dd-MM-yyyy")));
                doc.Add(new Paragraph(" HASTA:      " + dateFinal.Value.ToString("dd-MM-yyyy")));

                grafTE.ScaleAbsoluteWidth(550);
                grafAlpha.ScaleAbsoluteWidth(550);

                doc.Add(grafTE);
                doc.Add(grafAlpha);


            }
            catch
            {

            }
            finally
            {
                doc.Close();
            }
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
