using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.DataValorCuota.Registros;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.DataValorCuota
{
    
    public partial class frmDataValorCuota : Form
    {
        private frmPrincipal ventanaPadre = null;
        private TrackingErrorWS.TrackingErrorWSClient _dao;
        private TrackingErrorWS.dataValorCuota[] datos;

        public frmDataValorCuota(frmPrincipal ventana)
        {
            InitializeComponent();
            cambiarTema();
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);
            _dao = new TrackingErrorWS.TrackingErrorWSClient();
            cargarCombo();
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
            dgvDataValorCuota.Refresh();
        }

        private void btnActualizarRegistro_Click(object sender, System.EventArgs e)
        {
            if (dgvDataValorCuota.CurrentRow != null)
            {
                frmEditarRegistroDataValorCuota ventanaAgregar = new frmEditarRegistroDataValorCuota(datos[dgvDataValorCuota.CurrentRow.Index]);
                ventanaAgregar.ShowDialog();
            }

            dgvDataValorCuota.Refresh();
        }

        private void btnConsultarRegistros_Click(object sender, System.EventArgs e)
        {            
            datos = _dao.ListarPorFechaSinYtoDDataValorCuota(dateInicial.Value.ToString("yyyy-MM-dd"), dateFinal.Value.ToString("yyyy-MM-dd"), comboFondo.SelectedIndex+1);
            if (datos != null)
            {                
                dgvDataValorCuota.DataSource = new BindingList<TrackingErrorWS.dataValorCuota>(datos.ToList());
            }

            dgvDataValorCuota.Refresh();
        }

        private void btnEliminarRegistro_Click(object sender, System.EventArgs e)
        {
            int i = -1;
            datos = _dao.ListarPorFechaSinYtoDDataValorCuota(dateInicial.Value.ToString("yyyy-MM-dd"), dateFinal.Value.ToString("yyyy-MM-dd"), comboFondo.SelectedIndex + 1);
            if(datos!= null) i= _dao.eliminarDataValorCuota(datos[dgvDataValorCuota.CurrentRow.Index].idDataValorCuota);
            if (i == 1)
            {
                MessageBox.Show("TODO OK");
            }
            else
            {
                MessageBox.Show("ERROR");

            }

            dgvDataValorCuota.Refresh();
        }
        private void cargarCombo()
        {
            comboFondo.Items.Add("Fondo 1");
            comboFondo.Items.Add("Fondo 2");
            //comboFondo.Items.Add("Fondo 3");
        }
        private void btnVerCalculoAlfa_Click(object sender, System.EventArgs e)
        {

        }
    }
}

