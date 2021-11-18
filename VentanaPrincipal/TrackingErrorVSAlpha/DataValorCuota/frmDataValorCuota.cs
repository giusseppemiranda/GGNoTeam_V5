using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.DataValorCuota.Registros;
using System;
using System.ComponentModel;
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
        private static BindingList<string> nombreafp = new BindingList<string>();
        private static string tipofondo;
        private frmTEvsAlpha ventanaAnterior = null;

        public frmDataValorCuota(frmPrincipal ventana, frmTEvsAlpha ventana_2)
        {
            InitializeComponent();
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);

            ventanaAnterior = ventana_2;

            dgvDataValorCuota.AutoGenerateColumns = false;
            dgvDataValorCuota.DataSource = frmTEvsAlpha.DatosPrin;
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
        }

        private void btnActualizarRegistro_Click(object sender, System.EventArgs e)
        {
            if (dgvDataValorCuota.CurrentRow != null)
            {
                frmEditarRegistroDataValorCuota ventanaAgregar = new frmEditarRegistroDataValorCuota(frmTEvsAlpha.DatosPrin[dgvDataValorCuota.CurrentRow.Index],listaAfps,comboFondo.SelectedIndex);
                ventanaAgregar.ShowDialog();
                this.btnConsultarRegistros_Click(sender, e);
            }
        }

        private void btnConsultarRegistros_Click(object sender, System.EventArgs e)
        {
            frmTEvsAlpha.DatosPrin = _dao.ListarPorFechaPorFondoDataValorCuota(dateInicial.Value.ToString("yyyy-MM-dd"), dateFinal.Value.ToString("yyyy-MM-dd"), comboFondo.SelectedIndex + 1);
            datos = frmTEvsAlpha.DatosPrin;
            if (datos != null)
            {
                nombreafp.Clear();
                for (int i = 0; i < datos.Length; i++)
                {
                    nombreafp.Add(listaAfps[datos[i].fidAFP - 1].nombre);
                    tipofondo = comboFondo.SelectedItem.ToString();
                }
            }
            dgvDataValorCuota.DataSource = datos;
            dgvDataValorCuota.Refresh();
        }

        private void btnEliminarRegistro_Click(object sender, System.EventArgs e)
        {
            int i = -1;
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
            ventanaAnterior.abrirFormulario(new frmCalcularAlpha(ventanaPadre, ventanaAnterior));
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

        private void dgvDataValorCuota_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {       
            TrackingErrorWS.dataValorCuota dvc = (TrackingErrorWS.dataValorCuota)dgvDataValorCuota.Rows[e.RowIndex].DataBoundItem;
            dgvDataValorCuota.Rows[e.RowIndex].Cells[0].Value = dvc.idDataValorCuota;
            dgvDataValorCuota.Rows[e.RowIndex].Cells[1].Value = dvc.fecha.ToString("dd/MM/yyyy");
            dgvDataValorCuota.Rows[e.RowIndex].Cells[2].Value = nombreafp[e.RowIndex];
            dgvDataValorCuota.Rows[e.RowIndex].Cells[3].Value = tipofondo;
            dgvDataValorCuota.Rows[e.RowIndex].Cells[4].Value = dvc.patrimonio;
            dgvDataValorCuota.Rows[e.RowIndex].Cells[5].Value = dvc.cuotas;
            dgvDataValorCuota.Rows[e.RowIndex].Cells[6].Value = dvc.valorCuota;
        }
    }
}

