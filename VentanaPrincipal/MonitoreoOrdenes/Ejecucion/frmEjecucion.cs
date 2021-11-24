using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.VentanaPrincipal.MonitoreoOrdenes.Orden;
using GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.AssetError.Registros;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.MonitoreoOrdenes.Ejecucion
{
    public partial class frmEjecucion : Form
    {
        private frmPrincipal ventanaPrincipal = null;
        private MonitoreoOrdenWS.MonitorOrdenWSClient _daoMO;
        private TrackingErrorWS.TrackingErrorWSClient _daoTE;
        private MonitoreoOrdenWS.ejecucion[] listaEjecuciones;
        private String[] assets = { "Renta Fija", "Renta Variable" };
        private String[] operaciones = { "Compra", "Venta" };
        private String[] fondos;
        public frmEjecucion(frmPrincipal ventana)
        {
            InitializeComponent();
            ventanaPrincipal = ventana;
            ventanaPrincipal.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);
            _daoMO = new MonitoreoOrdenWS.MonitorOrdenWSClient();
            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();
            cambiarTema();
            cargarComboFondo();
        }

        private void btnConsultarEjecuciones_Click(object sender, EventArgs e)
        {
            listaEjecuciones = _daoMO.listarEjecucionPorFecha(dateInicial.Value.ToString("yyyy-MM-dd"));
            if (listaEjecuciones != null)
            {
                dgvOrdenes.DataSource = listaEjecuciones;
            }
            else
            {
                dgvOrdenes.DataSource = null;
            }
        }
        private void cargarComboFondo()
        {
            fondos = _daoTE.ListarFondos();
            comboFondo.DataSource = fondos;
        }
        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            frmEditarEjecucion ventanaAgregar = new frmEditarEjecucion();
            ventanaAgregar.ShowDialog();
            this.btnConsultarEjecuciones_Click(sender, e);

        }

        private void EliminarRegistro_Click(object sender, EventArgs e)
        {
            if (listaEjecuciones != null)
            {
                int procesoValido = _daoMO.eliminarEjecucion(listaEjecuciones[dgvOrdenes.CurrentRow.Index].idEjecucion);
                if (procesoValido != 1)
                {
                    MessageBox.Show("No se ha podido eliminar el elemento seleccionado. Intente nuevamente.");
                }
            }
            this.btnConsultarEjecuciones_Click(sender, e);
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            if (listaEjecuciones != null)
            {
                frmEditarEjecucion ventanaModificar = new frmEditarEjecucion(listaEjecuciones[dgvOrdenes.CurrentRow.Index]);
                ventanaModificar.ShowDialog();
                this.btnConsultarEjecuciones_Click(sender, e);
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

        private void dgvOrdenes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            MonitoreoOrdenWS.ejecucion orden = (MonitoreoOrdenWS.ejecucion)dgvOrdenes.Rows[e.RowIndex].DataBoundItem;

            dgvOrdenes.Rows[e.RowIndex].Cells[0].Value = orden.fecha;
            dgvOrdenes.Rows[e.RowIndex].Cells[1].Value = assets[orden.fidAssetClass - 1];
            dgvOrdenes.Rows[e.RowIndex].Cells[2].Value = fondos[orden.fidFondo - 1];
            dgvOrdenes.Rows[e.RowIndex].Cells[3].Value = orden.codsbs;
            dgvOrdenes.Rows[e.RowIndex].Cells[4].Value = orden.codisin;
            dgvOrdenes.Rows[e.RowIndex].Cells[5].Value = orden.instrumento;
            dgvOrdenes.Rows[e.RowIndex].Cells[6].Value = operaciones[orden.fidTipoOperacion - 1];
            dgvOrdenes.Rows[e.RowIndex].Cells[7].Value = orden.AUM;

        }
    }
}
