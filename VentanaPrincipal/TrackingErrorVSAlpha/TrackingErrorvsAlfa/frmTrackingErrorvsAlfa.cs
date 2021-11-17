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

namespace GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.TrackingErrorvsAlfa
{
    public partial class frmTrackingErrorvsAlfa : Form
    {
        private frmPrincipal ventanaPadre = null;
        private TrackingErrorWS.TrackingErrorWSClient _daoTE;
        private TrackingErrorWS.trackingError[] listaTE;        

        public frmTrackingErrorvsAlfa(frmPrincipal ventana)
        {
            InitializeComponent();
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);

            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();

            cambiarTema();
            configurarGraficoTE();
        }

        private void configurarGraficoTE()
        {
            graficoTE.Series["TrackingError"].XValueMember = "fecha";
            graficoTE.Series["TrackingError"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            graficoTE.Series["TrackingError"].YValueMembers = "trackingError";
            graficoTE.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            graficoTE.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
        }

        private void configurarGraficoAlpha()
        {
            graficoAlpha.Series["Alpha"].XValueMember = "fecha";
            graficoAlpha.Series["Alpha"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            graficoAlpha.Series["Alpha"].YValueMembers = "trackingError";
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
            generarGraficoTrackingError();
        }

        private void btnFondo_2_Click(object sender, EventArgs e)
        {
            obtenerDatosTrackingError(2);
            generarGraficoTrackingError();
        }

        private void btnFondo_3_Click(object sender, EventArgs e)
        {
            obtenerDatosTrackingError(3);
            generarGraficoTrackingError();
        }
        

        private void generarGraficoTrackingError()
        {
            graficoTE.DataSource = null;
            if (listaTE != null)
            {
                graficoTE.DataSource = listaTE;                
            }
            graficoTE.DataBind();
        }

        private void obtenerDatosTrackingError(int fidFondo)
        {
            listaTE = _daoTE.ListarTrackingErrorPorFechaPorFondo(dateInicial.Value.ToString("yyyy-MM-dd"), dateFinal.Value.ToString("yyyy-MM-dd"), fidFondo);
        }

        private void btnExportarGraficos_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                graficoTE.SaveImage(saveFileDialog1.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            }
        }

        private void chart2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
