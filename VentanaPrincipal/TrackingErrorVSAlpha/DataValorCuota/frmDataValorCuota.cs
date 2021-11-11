﻿using GGNoTeam_V5.Recursos.UserControls;
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

        public frmDataValorCuota(frmPrincipal ventana)
        {
            InitializeComponent();
            cambiarTema();
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);
            _dao = new TrackingErrorWS.TrackingErrorWSClient();
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
        }

        private void btnActualizarRegistro_Click(object sender, System.EventArgs e)
        {

        }

        private void btnConsultarRegistros_Click(object sender, System.EventArgs e)
        {
            TrackingErrorWS.dataValorCuota[] datos;
            datos = _dao.ListarPorFechaSinYtoDDataValorCuota(dateInicial.Value.ToString("yyyy-MM-dd"), dateFinal.Value.ToString("yyyy-MM-dd"), 1);

            if (datos != null)
            {
                dgvDataValorCuota.DataSource = new BindingList<TrackingErrorWS.dataValorCuota>(datos.ToList());
            }
            
        }

        private void btnEliminarRegistro_Click(object sender, System.EventArgs e)
        {
            TrackingErrorWS.dataValorCuota[] datos;
            datos = _dao.ListarPorFechaSinYtoDDataValorCuota(dateInicial.Value.ToString("yyyy-MM-dd"), dateFinal.Value.ToString("yyyy-MM-dd"), 1);
            int  i = _dao.eliminarDataValorCuota(datos[dgvDataValorCuota.CurrentRow.Index].idDataValorCuota);
            if (i == 1)
            {
                MessageBox.Show("TODO OK");
            }
            else
            {
                MessageBox.Show("ERROR");

            }
        }
    }
}
