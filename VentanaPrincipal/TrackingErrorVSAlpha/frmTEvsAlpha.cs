using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.TrackingErrorWS;
using GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.AssetError;
using GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.AssetError.CalculoTrackingError;
using GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.DataValorCuota;
using GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.TrackingErrorvsAlfa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha
{
    public partial class frmTEvsAlpha : Form
    {
        private Form frmActivo = null;
        private frmPrincipal ventanaPadre = null;
        private static TrackingErrorWS.dataValorCuota[] datosPrin = null;

        public static dataValorCuota[] DatosPrin { get => datosPrin; set => datosPrin = value; }

        public frmTEvsAlpha(frmPrincipal ventana)
        {
            InitializeComponent();
            cambiarTema();
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);
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


        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {            
            abrirFormulario(new frmTrackingErrorvsAlfa(ventanaPadre));
        }

        public void abrirFormulario(Form formulario)
        {
            if (frmActivo != null)
            {
                frmActivo.Dispose();
            }
            frmActivo = formulario;
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(formulario);
            formulario.Show();
        }

        

        private void frmTEvsAlpha_Load(object sender, EventArgs e)
        {

        }

        private void btnDataValorCuota_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmDataValorCuota(ventanaPadre));
        }

        private void btnAssetError_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmAssetError(ventanaPadre,this));
        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

