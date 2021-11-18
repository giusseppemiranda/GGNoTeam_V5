using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.VentanaPrincipal.MonitoreoOrdenes.Ejecucion;

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
        private frmMonitoreoOrdenes ventanaPrincipal = null;
        private MonitoreoOrdenWS.MonitoreoOrdenWSClient _daoMO;
        private MonitoreoOrdenWS.orden[] listaOrdenes;
        public frmOrden(frmMonitoreoOrdenes ventana)
        {
            InitializeComponent();
            ventanaPrincipal = ventana;
            ventanaPrincipal.eventoCambiarTema += new frmMonitoreoOrdenes.delegadoCambiarTema(cambiarTema);
            _daoMO = new MonitoreoOrdenWS.MonitoreoOrdenWSClient();
            cambiarTema();
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
            if (listaOrdenes!= null)
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

            listaOrdenes = _daoMO.ListarOrdenPorFechaFondo(dateInicial.Value.ToString("yyyy-MM-dd"), comboFondo.SelectedIndex + 1));
            dgvOrdenes.Rows.Clear();
            if (listaOrdenes != null)
            {
                for (int i = 0; i < listaOrdenes.Length; i++)
                {
                   dgvOrdenes.Rows.Add(
                       listaOrdenes[i].fecha.ToString("dd/MM/yyyy"), 
                       comboFondo.SelectedItem.ToString(),
                       listaOrdenes[i].nombre,
                       listaOrdenes[i].codsbs,
                       listaOrdenes[i].codisin,
                       listaOrdenes[i].instrumento,
                       listaOrdenes[i].tipoOper,
                       listaOrdenes[i].porcentageFondo);
                }
            }
            dgvOrdenes.Refresh();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void dateInicial_ValueChanged(object sender, EventArgs e)
        {

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
    }
}
