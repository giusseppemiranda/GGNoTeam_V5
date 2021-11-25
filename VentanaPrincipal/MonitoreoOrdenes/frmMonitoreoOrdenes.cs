using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha;
using GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.AssetError.Registros;
using GGNoTeam_V5.VentanaPrincipal.MonitoreoOrdenes.Operaciones;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.TrackingErrorvsAlfa;
using GGNoTeam_V5.VentanaPrincipal.MonitoreoOrdenes.Ejecucion;
using GGNoTeam_V5.VentanaPrincipal.MonitoreoOrdenes.Orden;
using static GGNoTeam_V5.VentanaPrincipal.frmPrincipal;

namespace GGNoTeam_V5.VentanaPrincipal.MonitoreoOrdenes
{
    public partial class frmMonitoreoOrdenes : Form
    {
        public delegate void delegadoCambiarTema();
        public event delegadoCambiarTema eventoCambiarTema;
        private frmPrincipal ventanaPrincipal = null;
        private MonitoreoOrdenWS.MonitorOrdenWSClient _daoMO;
        private TrackingErrorWS.TrackingErrorWSClient _daoTE;
        private MonitoreoOrdenWS.operacion[] listaOperaciones;
        private String[] operaciones = { "Compra", "Venta" };
        private String[] fondos;
        private MonitoreoOrdenWS.orden[] ops;
        private MonitoreoOrdenWS.ejecucion[] ejes;

        public frmMonitoreoOrdenes(frmPrincipal ventana)
        {
            InitializeComponent();
            ventanaPrincipal = ventana;
            ventanaPrincipal.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);
            _daoMO = new MonitoreoOrdenWS.MonitorOrdenWSClient();
            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();

            dgvOrdenes.AutoGenerateColumns = false;

            Global.pintarDGV(ref dgvOrdenes, Color.DarkSalmon);
            cambiarTema();
            cargarComboFondo();
            ops = _daoMO.listaTodosOrden();
            ejes = _daoMO.listarTodosEjecucion();
        }
        private void cargarComboFondo()
        {
            fondos = _daoTE.ListarFondos();
            comboFondo.DataSource = fondos;
        }

        private void btnconsultar_click(object sender, EventArgs e)
        {
            listaOperaciones = _daoMO.ListarPorFechaOperacion(dateInicial.Value.ToString("yyyy-MM-dd"), dateFinal.Value.ToString("yyyy-MM-dd"));
           
            if (listaOperaciones != null)
            {
                dgvOrdenes.DataSource = listaOperaciones;
            }
            else
            {
                dgvOrdenes.DataSource = null;
            }
        }

        private void EliminarRegistro_Click(object sender, EventArgs e)
        {
            if (listaOperaciones != null)
            {
                int procesoValido = _daoMO.eliminarOperacion(listaOperaciones[dgvOrdenes.CurrentRow.Index].idOperacion);
                if (procesoValido != 1)
                {
                    MessageBox.Show("No se ha podido eliminar el elemento seleccionado. Intente nuevamente.");
                }
            }
            this.btnconsultar_click(sender, e);
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            if (listaOperaciones != null)
            {
                frmEditarOperacion ventanaModificar = new frmEditarOperacion(listaOperaciones[dgvOrdenes.CurrentRow.Index]);
                ventanaModificar.ShowDialog();
                this.btnconsultar_click(sender, e);
            }
        }

        private void btnAccederOrden_Click(object sender, EventArgs e)
        {
            ventanaPrincipal.abrirFormulario(new frmOrden(ventanaPrincipal));
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
            MonitoreoOrdenWS.operacion orden = (MonitoreoOrdenWS.operacion)dgvOrdenes.Rows[e.RowIndex].DataBoundItem;

            double aumEje = 0,aumOrd=0;
            int idFondo = 0;
            
            foreach (var eje in ejes) if (eje.idEjecucion == orden.fidEjecu)
                {
                    aumEje = eje.AUM;
                    idFondo = eje.fidFondo;
                }
            foreach (var ope in ops) if (ope.idOrden== orden.fidOrden) aumOrd= ope.porcentageFondo;

            dgvOrdenes.Rows[e.RowIndex].Cells[0].Value = orden.fecha;
            dgvOrdenes.Rows[e.RowIndex].Cells[1].Value = idFondo;
            dgvOrdenes.Rows[e.RowIndex].Cells[2].Value = orden.codsbs;
            dgvOrdenes.Rows[e.RowIndex].Cells[3].Value = orden.codisin;
            dgvOrdenes.Rows[e.RowIndex].Cells[4].Value = orden.instrumento;
            dgvOrdenes.Rows[e.RowIndex].Cells[5].Value = aumEje;
            dgvOrdenes.Rows[e.RowIndex].Cells[6].Value = aumOrd;
            dgvOrdenes.Rows[e.RowIndex].Cells[7].Value = orden.validacion;
            dgvOrdenes.Rows[e.RowIndex].Cells[8].Value = orden.comentario;

        }

        private void btnAccederEjecucion_Click(object sender, EventArgs e)
        {
            ventanaPrincipal.abrirFormulario(new frmEjecucion(ventanaPrincipal));
        }
    }
}
