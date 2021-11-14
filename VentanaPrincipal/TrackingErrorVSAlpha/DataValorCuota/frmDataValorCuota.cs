using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.DataValorCuota.Registros;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.DataValorCuota
{
    
    public partial class frmDataValorCuota : Form
    {
        private frmPrincipal ventanaPadre = null;
        private TrackingErrorWS.TrackingErrorWSClient _dao;
        private TrackingErrorWS.dataValorCuota[] datos;
        private TrackingErrorWS.afp[] listaAfps;
        private bool activarEventoComboFondo = false; 

        public frmDataValorCuota(frmPrincipal ventana)
        {
            InitializeComponent();
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);

            _dao = new TrackingErrorWS.TrackingErrorWSClient();

            Global.pintarDGV(ref dgvDataValorCuota, Color.DarkSalmon);
            cambiarTema();
            cargarCombo();
            cargarNombresAFP();
            activarEventoComboFondo = true;
        }

        private void cargarNombresAFP()
        {
            listaAfps = _dao.ListarTodasAfp();
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
            frmEditarRegistroDataValorCuota ventanaAgregar = new frmEditarRegistroDataValorCuota(listaAfps);
            ventanaAgregar.ShowDialog();
            this.btnConsultarRegistros_Click(sender, e);
            dgvDataValorCuota.Refresh();
        }

        private void btnActualizarRegistro_Click(object sender, System.EventArgs e)
        {
            if (dgvDataValorCuota.CurrentRow != null)
            {
                frmEditarRegistroDataValorCuota ventanaAgregar = new frmEditarRegistroDataValorCuota(datos[dgvDataValorCuota.CurrentRow.Index],listaAfps,comboFondo.SelectedIndex);
                ventanaAgregar.ShowDialog();
                this.btnConsultarRegistros_Click(sender, e);
            }
            
            dgvDataValorCuota.Refresh();
        }

        private void btnConsultarRegistros_Click(object sender, System.EventArgs e)
        {            
            datos = _dao.ListarPorFechaPorFondoDataValorCuota(dateInicial.Value.ToString("yyyy-MM-dd"), dateFinal.Value.ToString("yyyy-MM-dd"), comboFondo.SelectedIndex + 1);
            if (datos != null)
            {
                dgvDataValorCuota.Rows.Clear();
                for(int i = 0; i < datos.Length; i++)
                {
                    dgvDataValorCuota.Rows.Add(datos[i].idDataValorCuota,datos[i].fecha.ToString("dd/MM/yyyy"),listaAfps[datos[i].fidAFP-1].nombre,comboFondo.SelectedItem.ToString(),datos[i].patrimonio,datos[i].cuotas,datos[i].valorCuota);
                }
                
            }            
            dgvDataValorCuota.Refresh();
        }

        private void btnEliminarRegistro_Click(object sender, System.EventArgs e)
        {
            int i = -1;
            //datos = _dao.ListarPorFechaSinYtoDDataValorCuota(dateInicial.Value.ToString("yyyy-MM-dd"), dateFinal.Value.ToString("yyyy-MM-dd"), comboFondo.SelectedIndex + 1);
            if(datos!= null) i= _dao.eliminarDataValorCuota(datos[dgvDataValorCuota.CurrentRow.Index].idDataValorCuota);
            if (i == 1)
            {
                MessageBox.Show("Se han borrado correctamente los datos seleccionados");
                this.btnConsultarRegistros_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Error al momento de borrar. Intente nuevamente");

            }

            dgvDataValorCuota.Refresh();
        }
        private void cargarCombo()
        {
            String[] fondos = _dao.ListarFondos();
            comboFondo.DataSource = fondos;
        }
        private void btnVerCalculoAlfa_Click(object sender, System.EventArgs e)
        {

        }

        private void comboFondo_Load(object sender, System.EventArgs e)
        {

        }

        private void comboFondo_OnSelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (activarEventoComboFondo)
            {
                this.btnConsultarRegistros_Click(sender,e);
            }
        }
    }
}

