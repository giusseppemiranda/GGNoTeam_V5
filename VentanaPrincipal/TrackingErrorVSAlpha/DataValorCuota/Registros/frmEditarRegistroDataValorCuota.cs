using GGNoTeam_V5.Recursos.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.DataValorCuota.Registros
{
    public partial class frmEditarRegistroDataValorCuota : Form
    {
        private TrackingErrorWS.TrackingErrorWSClient _daoTE;
        public frmEditarRegistroDataValorCuota()
        {
            InitializeComponent();
            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();
            cambiarTema();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            TrackingErrorWS.dataValorCuota data = new TrackingErrorWS.dataValorCuota();

            data.activo = 1;
            data.cuotas = Convert.ToDouble(boxCuota.Texts);
            data.fecha = dateTimePicker1.Value;
            data.fechaSpecified = true;
            data.patrimonio = Convert.ToDouble(boxPatrimonio.Texts);
            data.valorCuota = Convert.ToDouble(boxValorCuota.Texts);
            data.ytoD = 0.2;

            int i = _daoTE.insertarDataValorCuota(data,1);
            if(i == 1)
            {
                MessageBox.Show("TODO CORRECTO");
            } else
            {
                MessageBox.Show("HAY ERROR");
            }
        }
    }
}
