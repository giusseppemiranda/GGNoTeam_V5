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

        //INSERTAR DATA VALOR CUOTA
        public frmEditarRegistroDataValorCuota(TrackingErrorWS.afp[] listaAfps)
        {
            InitializeComponent();
            cambiarTema();
            cargarCombo();
            cargarComboAFP(listaAfps);
            
            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();            
            dato = new TrackingErrorWS.dataValorCuota();
            comboAFP.SelectedIndex = 0;
            comboFondo.SelectedIndex = 0;
            lblTitulo.Text = "INSERTAR DATA VALOR CUOTA";
            insertar = true;
        }

        //EDITAR DATA VALOR CUOTA
        public frmEditarRegistroDataValorCuota(TrackingErrorWS.dataValorCuota dato, TrackingErrorWS.afp[] listaAfps, int tipoFondo)
        {
            InitializeComponent();
            cambiarTema();
            cargarCombo();
            cargarComboAFP(listaAfps);

            lblTitulo.Text = "EDITAR DATA VALOR CUOTA";
            this.dato = dato;
            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();

            cargarCamposEdicion(tipoFondo);
        }

        private void cargarCamposEdicion(int tipoFondo)
        {
            comboFondo.SelectedIndex = tipoFondo;
            dateTimePicker1.Value = dato.fecha;
            comboAFP.SelectedIndex = dato.fidAFP - 1;
            boxPatrimonio.Texts = dato.patrimonio.ToString();
            boxCuota.Texts = dato.cuotas.ToString();
            boxValorCuota.Texts = dato.valorCuota.ToString();
        }

        private void cargarComboAFP(TrackingErrorWS.afp[] listaAfps)
        {
            for(int i = 0; i < listaAfps.Length; i++)
            {
                comboAFP.Items.Add(listaAfps[i].nombre);
            }            
        }

        private void cargarCombo()
        {
            comboFondo.DataSource = _daoTE.ListarFondos();
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
                dato.fecha = dateTimePicker1.Value;
                dato.fechaSpecified = true;


                dato.cuotas = Convert.ToDouble(boxCuota.Texts);
                dato.valorCuota = Convert.ToDouble(boxValorCuota.Texts);
                dato.patrimonio = Convert.ToDouble(boxPatrimonio.Texts);
                
                if(boxValorCuota.Texts == "")
                {
                    MessageBox.Show("Valor cuota no puede estar vacío");
                    return;
                }

                if (boxCuota.Texts == "")
                {
                    MessageBox.Show("Cuota no puede estar vacío");
                    return;
                }

                int i = -1;
                if (insertar)
                {
                    i = _daoTE.insertarDataValorCuota(dato, comboFondo.SelectedIndex+1);
                    if(i == 1)
                    {
                        //MessageBox.Show("Se insertó correctamente.");
                    } else
                    {
                        MessageBox.Show("No se han insertado los valores en la base de datos");
                    }
                } else
                {
                    i = _daoTE.modificarDataValorCuota(dato, comboFondo.SelectedIndex+1);
                    if (i == 1)
                    {
                        MessageBox.Show("Se modificó correctamente.");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("No se han modificado los valores en la base de datos");
                    }
                }                                
            }
            catch 
            {
                MessageBox.Show("Pruebe ingresando nuevamente, hay un error. Cuota y valor cuota deben ser números.");
            }
        }
    }
}
