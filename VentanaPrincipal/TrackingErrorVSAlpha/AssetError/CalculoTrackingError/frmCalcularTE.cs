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
        public frmCalcularTE(frmPrincipal ventana,frmTEvsAlpha ventana_2)
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
            //datos = _dao.listarPorFechaConProducto(dateInicial.Value.ToString("yyyy-MM-dd"));
            if (datos != null)
            {
                dgvDataValorCuota.DataSource = new BindingList<TrackingErrorWS.assetError>(datos.ToList());
            }

            dgvDataValorCuota.Refresh();

        }
        
        /*
        private void CalcularTeFondo()
        {
            double f1 = 0;
            double f2 = 0;
            foreach (DataGridViewRow row in dgvDataValorCuota.Rows)
            {
                var ass = row.DataBoundItem as TrackingErrorWS.assetError;
                //falta agregar el fidfondo a las clases en java, mysql y procedures
                if (ass.fidFondo == 1) f1 += ass.producto;
                if (ass.fidFondo == 2) f2 += ass.producto;
            }
            ggTextBox2.Texts = f2.ToString();
            ggTextBox1.Texts = f1.ToString();
        }
        */
    }
}
