using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.DataValorCuota.Registros;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.DataValorCuota
{
    public partial class frmDataValorCuota : Form
    {
        private frmPrincipal ventanaPadre = null;

        public frmDataValorCuota(frmPrincipal ventana)
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

        private void btnAgregarRegistros_Click(object sender, System.EventArgs e)
        {
            frmEditarRegistroDataValorCuota ventanaAgregar = new frmEditarRegistroDataValorCuota();
            ventanaAgregar.ShowDialog();
        }
    }
}
