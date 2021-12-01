using GGNoTeam_V5.MonitoreoOrdenWS;
using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.VentanaPrincipal.MonitoreoOrdenes.Ejecucion;

using Org.BouncyCastle.Utilities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.MonitoreoOrdenes.Orden
{
    public partial class frmOrden : Form
    {
        private frmPrincipal ventanaPrincipal = null;
        private TrackingErrorWS.TrackingErrorWSClient _daoTE;
        private MonitoreoOrdenWS.MonitorOrdenWSClient _daoMO;
        private MonitoreoOrdenWS.orden[] listaOrdenes;
        private MonitoreoOrdenWS.orden[] listaOrdenes2;
        private String[] assets = { "Renta Fija", "Renta Variable" };
        private String[] operaciones = { "Compra", "Venta" };
        private String[] fondos;

        public frmOrden(frmPrincipal ventana)
        {
            InitializeComponent();
            ventanaPrincipal = ventana;
            ventanaPrincipal.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);
            _daoMO = new MonitoreoOrdenWS.MonitorOrdenWSClient();
            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();
            dgvOrdenes.AutoGenerateColumns = false;
            cambiarTema();
            cargarComboFondo();
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            if (listaOrdenes != null)
            {
                frmEditarOrden ventanaModificar = new frmEditarOrden(listaOrdenes[dgvOrdenes.CurrentRow.Index]);
                ventanaModificar.ShowDialog();
                this.btnConsultarEjecuciones_Click(sender, e);
            }
        }

        private void EliminarRegistro_Click(object sender, EventArgs e)
        {
            if (listaOrdenes != null)
            {
                int procesoValido = _daoMO.eliminarOrden(listaOrdenes[dgvOrdenes.CurrentRow.Index].idOrden);
                if (procesoValido != 1)
                {
                    MessageBox.Show("No se ha podido eliminar el elemento seleccionado. Intente nuevamente.");
                }
            }
            this.btnConsultarEjecuciones_Click(sender, e);
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            frmEditarOrden ventanaAgregar = new frmEditarOrden();
            ventanaAgregar.ShowDialog();
            this.btnConsultarEjecuciones_Click(sender, e);
        }

        private void btnConsultarEjecuciones_Click(object sender, EventArgs e)
        {
            listaOrdenes = _daoMO.ListarOrdenPorFecha(dateInicial.Value.ToString("yyyy-MM-dd"));
             if (listaOrdenes != null)
            {
                dgvOrdenes.setDataSource1(listaOrdenes);
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
            MonitoreoOrdenWS.orden orden = (MonitoreoOrdenWS.orden)dgvOrdenes.Rows[e.RowIndex].DataBoundItem;
            dgvOrdenes.Rows[e.RowIndex].Cells[0].Value = orden.fecha;
            dgvOrdenes.Rows[e.RowIndex].Cells[1].Value = assets[orden.fidAssetClass-1];
            dgvOrdenes.Rows[e.RowIndex].Cells[2].Value = fondos[orden.fidFondo-1];
            dgvOrdenes.Rows[e.RowIndex].Cells[3].Value = orden.codsbs;
            dgvOrdenes.Rows[e.RowIndex].Cells[4].Value = orden.codisin;
            dgvOrdenes.Rows[e.RowIndex].Cells[5].Value = orden.instrumento;
            dgvOrdenes.Rows[e.RowIndex].Cells[6].Value = operaciones[orden.fidTipoOperacion - 1];
            dgvOrdenes.Rows[e.RowIndex].Cells[7].Value = orden.porcentageFondo;
        }
    }
}
