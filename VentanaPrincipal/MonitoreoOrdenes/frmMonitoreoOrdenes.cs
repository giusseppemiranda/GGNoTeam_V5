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
        private MonitoreoOrdenWS.MonitoreoOrdenWSClient _daoMO;
        private MonitoreoOrdenWS.operacion[] listaOperaciones;
        public frmMonitoreoOrdenes(frmPrincipal ventana)
        {
            InitializeComponent();
            ventanaPrincipal = ventana;
            ventanaPrincipal.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);
            _daoMO = new MonitoreoOrdenWS.MonitoreoOrdenWSClient();
            cambiarTema();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            listaOperaciones = _daoMO.ListarOperacionPorFecha(dateInicial.Value.ToString("yyyy-MM-dd"), dateFinal.Value.ToString("yyyy-MM-dd"), comboFondo.SelectedIndex + 1);
            dgvOrdenes.Rows.Clear();
            if (listaOperaciones != null)
            {
                for (int i = 0; i < listaOperaciones.Length; i++)
                {
                    dgvOrdenes.Rows.Add(
                        listaOperaciones[i].fecha.ToString("dd/MM/yyyy"), 
                        comboFondo.SelectedItem.ToString(), 
                        listaOperaciones[i].codsbs, 
                        listaOperaciones[i].codsin, 
                        listaOperaciones[i].instrumento,

                        listaOperaciones[i].operacion,
                        listaOperaciones[i].aumSit.AUM,
                        listaOperaciones[i].aumOrd.porcentageFondo,

                        listaOperaciones[i].estadoValidacion,
                        listaOperaciones[i].comentario);
                }
            }
            dgvOrdenes.Refresh();
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
            this.btnConsultar_Click(sender, e);
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            if (listaOperaciones != null)
            {
                frmEditarOperacion ventanaModificar = new frmEditarOperacion(listaOperaciones[dgvOrdenes.CurrentRow.Index]);
                ventanaModificar.ShowDialog();
                this.btnConsultar_Click(sender, e);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnAccederOrden_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionarOrdenes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmOrden(this));
        }

        private void btnGestionarEjecuciones_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmEjecucion(this));

        }
        private void abrirFormulario(Form formulario)
        {
            /*
            if (frmActivo != null)
            {
                frmActivo.Dispose();
            }
            frmActivo = formulario;
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(formulario);
            formulario.Show();
            */
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
