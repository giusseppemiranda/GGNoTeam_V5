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
        private frmMonitoreoOrdenes ventanaPrincipal = null;
        private MonitoreoOrdenWS.MonitorOrdenWSClient _daoMO;
        private MonitoreoOrdenWS.ejecucion[] listaEjecuciones;
        public frmEjecucion(frmMonitoreoOrdenes ventana)
        {
            InitializeComponent();
            ventanaPrincipal = ventana;
            ventanaPrincipal.eventoCambiarTema += new frmMonitoreoOrdenes.delegadoCambiarTema(cambiarTema);
            _daoMO = new MonitoreoOrdenWS.MonitorOrdenWSClient();
            cambiarTema();
        }

        private void btnConsultarEjecuciones_Click(object sender, EventArgs e)
        {
            //listaEjecuciones = _daoMO.ListarEjecucionPorFecha(dateInicial.Value.ToString("yyyy-MM-dd"), comboFondo.SelectedIndex + 1));
            listaEjecuciones = _daoMO.ListarEjecucionPorFecha(dateInicial.Value.ToString("yyyy-MM-dd"));
            dgvOrdenes.Rows.Clear();
            if (listaEjecuciones != null)
            {
                for (int i = 0; i < listaEjecuciones.Length; i++)
                {
                    dgvOrdenes.Rows.Add(
                        listaEjecuciones[i].fechaOper.ToString("dd/MM/yyyy"),
                        comboFondo.SelectedItem.ToString(),
                        listaEjecuciones[i].codsbs,
                        listaEjecuciones[i].codisin,
                        listaEjecuciones[i].instrumento,
                        listaEjecuciones[i].tipoOper,
                        listaEjecuciones[i].AUM);
                }
            }
            dgvOrdenes.Refresh();
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
    }
}
