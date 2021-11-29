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
        private frmTEvsAlpha ventanaAnterior = null;

        public frmDataValorCuota(frmPrincipal ventana, frmTEvsAlpha ventana_2)
        {
            InitializeComponent();
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);

            ventanaAnterior = ventana_2;

            dgvDataValorCuota.AutoGenerateColumns = false;
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
                frmEditarRegistroDataValorCuota ventanaAgregar = new frmEditarRegistroDataValorCuota(frmTEvsAlpha.DatosPrin[dgvDataValorCuota.CurrentRow.Index], listaAfps, comboFondo.SelectedIndex);
                ventanaAgregar.ShowDialog();
                this.btnConsultarRegistros_Click(sender, e);
            }
        }

        private void btnConsultarRegistros_Click(object sender, System.EventArgs e)
        {
            datos = _dao.ListarPorFechaPorFondoDataValorCuota(dateInicial.Value.ToString("yyyy-MM-dd"), dateFinal.Value.ToString("yyyy-MM-dd"), comboFondo.SelectedIndex + 1);
            if (datos != null)
            {
                dgvDataValorCuota.setDataSource1(datos);
            }
            else
            {
                dgvDataValorCuota.DataSource = null;
            }
        }

        private void btnEliminarRegistro_Click(object sender, System.EventArgs e)
        {
            int i = -1;
            if (dgvDataValorCuota.CurrentRow != null)
            {
                var respuesta = MessageBox.Show("¿Está seguro que desea borrar el registro seleccionado?", "Eliminar registro Data Valor Cuota", MessageBoxButtons.OKCancel);
                if (respuesta == DialogResult.OK)
                {
                    i = _dao.eliminarDataValorCuota(datos[dgvDataValorCuota.CurrentRow.Index].idDataValorCuota);
                    if (i == 1)
                    {
                        MessageBox.Show("Se han borrado correctamente los datos seleccionados");
                        this.btnConsultarRegistros_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error al momento de borrar. Intente nuevamente");
                    }
                }
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
                this.btnConsultarRegistros_Click(sender, e);
            }
        }

        private void dgvDataValorCuota_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            TrackingErrorWS.dataValorCuota dvc = (TrackingErrorWS.dataValorCuota)dgvDataValorCuota.Rows[e.RowIndex].DataBoundItem;
            dgvDataValorCuota.Rows[e.RowIndex].Cells[0].Value = dvc.idDataValorCuota;
            dgvDataValorCuota.Rows[e.RowIndex].Cells[1].Value = dvc.fecha.ToString("dd/MM/yyyy");
            dgvDataValorCuota.Rows[e.RowIndex].Cells[2].Value = listaAfps[dvc.fidAFP - 1].nombre;
            dgvDataValorCuota.Rows[e.RowIndex].Cells[3].Value = comboFondo.SelectedItem.ToString();
            dgvDataValorCuota.Rows[e.RowIndex].Cells[4].Value = dvc.patrimonio;
            dgvDataValorCuota.Rows[e.RowIndex].Cells[5].Value = dvc.cuotas;
            dgvDataValorCuota.Rows[e.RowIndex].Cells[6].Value = dvc.valorCuota;
        }
    }
}

