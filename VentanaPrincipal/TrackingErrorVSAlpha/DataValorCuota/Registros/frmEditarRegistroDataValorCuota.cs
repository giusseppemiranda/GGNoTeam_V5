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
        private TrackingErrorWS.dataValorCuota dato;
        private bool insertar = false;
        public frmEditarRegistroDataValorCuota()
        {
            InitializeComponent();
            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();
            cambiarTema();
            cargarCombo();
            dato = new TrackingErrorWS.dataValorCuota();
            comboFondo.SelectedIndex = 0;
            insertar = true;
        }

        public frmEditarRegistroDataValorCuota(TrackingErrorWS.dataValorCuota dato)
        {
            InitializeComponent();
            this.dato = dato;
            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();
            cambiarTema();
            cargarCombo();
            comboFondo.SelectedIndex = 0;

            dateTimePicker1.Value = dato.fecha;
            comboFondo.SelectedIndex = 0;
            boxPatrimonio.Texts = dato.patrimonio.ToString();
            boxCuota.Texts = dato.cuotas.ToString();
            boxValorCuota.Texts = dato.valorCuota.ToString();
        }

        private void cargarCombo()
        {
            comboFondo.Items.Add("Fondo 1");
            comboFondo.Items.Add("Fondo 2");
            comboFondo.Items.Add("Fondo 3");

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
            try
            {
                dato.activo = 1;
                dato.cuotas = Convert.ToDouble(boxCuota.Texts);
                dato.fecha = dateTimePicker1.Value;
                dato.fechaSpecified = true;
                dato.patrimonio = Convert.ToDouble(boxPatrimonio.Texts);
                dato.valorCuota = Convert.ToDouble(boxValorCuota.Texts);
                dato.ytoD = 0.2;
                int i = -1;
                if (insertar)
                {
                    i = _daoTE.insertarDataValorCuota(dato, 1);
                } else
                {
                    i = _daoTE.modificarDataValorCuota(dato, 1);

                }
                
                if (i == 1)
                {
                    MessageBox.Show("TODO CORRECTO");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("HAY ERROR");
                }
            }
            catch 
            {
                MessageBox.Show("Pruebe ingresando nuevamente, hay un error. Patrimonio, cuota y valor cuota deben ser números");
            }
        }
    }
}
