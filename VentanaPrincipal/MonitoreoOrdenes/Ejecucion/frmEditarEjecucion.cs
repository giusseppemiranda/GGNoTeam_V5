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

namespace GGNoTeam_V5.VentanaPrincipal.MonitoreoOrdenes.Ejecucion
{
    public partial class frmEditarEjecucion : Form
    {
        private TrackingErrorWS.TrackingErrorWSClient _daoTE;
        private MonitoreoOrdenWS.MonitoreoOrdenWSClient _daoMO;
        private bool insertarEjecucion = false;
        private MonitoreoOrdenWS.ejecucion Ejecucion;

        //Insertar Ejecucion
        public frmEditarEjecucion()
        {
            InitializeComponent();
            _daoMO = new MonitoreoOrdenWS.MonitoreoOrdenWSClient();
            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();
            insertarEjecucion = true;
            cambiarTema();
            cargarTipoEdicion();
            cargarComboFondo();
        }

        //Modificar Ejecucion
        public frmEditarEjecucion(MonitoreoOrdenWS.ejecucion ejecucion)
        {
            InitializeComponent();
            _daoMO = new MonitoreoOrdenWS.MonitoreoOrdenWSClient();
            Ejecucion = ejecucion;
            cambiarTema();
            cargarTipoEdicion();
            cargarDatosEjecucion();
            cargarComboFondo();
        }

        private void cargarDatosEjecucion()
        {
            TextBoxAUMEjecuciones.Texts = Ejecucion.AUM;
            TextBoxCodigoSbs.Texts = Ejecucion.codsbs;
            TextBoxCodigoSin.Texts = Ejecucion.codisin;
            TextBoxInstrumento.Texts = Ejecucion.instrumento;
            dateTimePicker1.Value = Ejecucion.fechaOper;
            TextBoxOperacion.Texts = Ejecucion.tipoOper;
            comboFondo.SelectedIndex = Ejecucion.fondo - 1;
        }
        private void cargarComboFondo()
        {
            String[] fondos = _daoTE.ListarFondos();
            comboFondo.DataSource = fondos;
        }
        private void cargarTipoEdicion()
        {
            if (insertarOperacion)
            {
                lblTitulo.Text = "Insertar Ejecucion";
                btnSiguiente.Text = "Insertar";
            }
            else
            {
                lblTitulo.Text = "Modificar Ejecucion";
                btnSiguiente.Text = "Actualizar";
            }
        }
        public void cambiarTema()
        private void activarTemaOscuro()
        {
            this.BackColor = Global.FrmOscuro;

        }
        private void activarTemaClaro()
        {
            this.BackColor = Global.FrmClaro;

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }
        private bool cargarDatos()
        {
            Ejecucion.fecha = dateTimePicker1.Value;
            Ejecucion.fechaSpecified = true;
            Ejecucion.fondo = comboFondo.SelectedIndex + 1;

            if (TextBoxAUMEjecuciones.Texts == "")
            {
                MessageBox.Show("AUM Ejecuciones no puede tener un campo vacío");
                return false;
            }

            if (TextBoxCodigoSbs.Texts == "")
            {
                MessageBox.Show("Codigo Sbs no puede tener un campo vacío");
                return false;
            }
            if (TextBoxCodigoSin.Texts == "")
            {
                MessageBox.Show("CodigoSin no puede tener un campo vacío");
                return false;
            }

            if (TextBoxInstrumento.Texts == "")
            {
                MessageBox.Show("Instrumento no puede tener un campo vacío");
                return false;
            }

            if (TextBoxOperacion.Texts == "")
            {
                MessageBox.Show("Operacion no puede tener un campo vacío");
                return false;
            }
            try
            {
                Ejecucion.porcentageFondo = TextBoxAUMEjecuciones.Texts;
                Ejecucion.codSBS = TextBoxCodigoSbs.Texts;
                Ejecucion.codISIN = TextBoxCodigoSin.Texts;
                Ejecucion.instrumento = TextBoxInstrumento.Texts;
                Ejecucion.operacion = TextBoxOperacion.Texts
            }
            catch
            {
                MessageBox.Show("Los valores ingresados en porcentaje Fondo codigo SBS  y en codigo ISIN deben ser números, no deben contener letras. Intente nuevamente");
                return false;
            }

            return true;
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            if (insertarEjecucion)
            {
                Ejecucion = new MonitoreoOrdenWS.ejecucion();
                if (cargarDatos())
                {
                    int i = _daoMO.insertarEjecucion(Ejecucion);
                    if (i == 1)
                    {
                        MessageBox.Show("La inserción fue realizada con éxito.");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al insertar.");
                    }

                }
            }
            else
            {
                if (cargarDatos())
                {
                    int i = _daoMO.modificarEjecucion(Ejecucion);
                    if (i == 0)
                    {
                        MessageBox.Show("Se ha realizado correctamente la modificación del Asset Error");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al modificar.");
                    }

                }
            }

        }

    }
}
