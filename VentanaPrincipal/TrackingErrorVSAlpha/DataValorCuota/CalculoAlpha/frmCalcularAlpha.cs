using GGNoTeam_V5.Recursos.UserControls;
using System;
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
        
    }
}
