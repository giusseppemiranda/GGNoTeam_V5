using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.TrackingErrorWS;

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
    public partial class frmEditarOrden : Form
    {
        private TrackingErrorWS.TrackingErrorWSClient _daoTE;
        private MonitoreoOrdenWS.MonitoreoOrdenWSClient _daoMO;
        private bool insertarOrden = false;
        private MonitoreoOrdenWS.orden Orden;

        //Insertar Orden
        public frmEditarOrden()
        {
            InitializeComponent();
            _daoMO = new MonitoreoOrdenWS.MonitoreoOrdenWSClient(); 
            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();

            insertarOrden = true;
            cambiarTema();
            cargarTipoEdicion();
            cargarComboFondo();
        }

        //Modificar Orden
        public frmEditarOrden(MonitoreoOrdenWS.orden orden)
        {
            InitializeComponent();
            _daoMO = new MonitoreoOrdenWS.MonitoreoOrdenWSClient();
            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();
            Operacion = operacion;
            cambiarTema();
            cargarTipoEdicion();
            cargarDatosOrden();
            cargarComboFondo();
        }

        private void cargarDatosOrden()
        {
            TextBoxAUMOrdenes.Texts = Orden.porcentageFondo;
            TextBoxCodigoSbs.Texts = Orden.codSBS;
            TextBoxCodigoSin.Texts = Orden.codISIN;
            TextBoxInstrumento.Texts = Orden.instrumento;
            dateTimePicker1.Value = Orden.fecha;
            TextBoxOperacion.Texts = Orden.operacion;
            comboFondo.SelectedIndex = Orden.Fondo.idFondo - 1;
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
                lblTitulo.Text = "Insertar Orden";
                btnSiguiente.Text = "Insertar";
            } else
            {
                lblTitulo.Text = "Modificar Orden";
                btnSiguiente.Text = "Actualizar";
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
        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            if (insertarOrden)
            {
                Orden = new MonitoreoOrdenWS.orden();
                if (cargarDatos())
                {
                    int i = _daoMO.insertarOrden(Orden);
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
                    int i = _daoMO.modificarOrden(Orden);
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private bool cargarDatos()
        {
            Orden.fecha = dateTimePicker1.Value;
            Orden.fechaSpecified = true;
            Orden.Fondo.idFondo = comboFondo.SelectedIndex + 1;

            if (TextBoxAUMOrdenes.Texts == "")
            {
                MessageBox.Show("AUM Ordenes no puede tener un campo vacío");
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
                Orden.porcentageFondo = TextBoxAUMOrdenes.Texts;
                Orden.codSBS = TextBoxCodigoSbs.Texts;
                Orden.codISIN = TextBoxCodigoSin.Texts;
                Orden.instrumento = TextBoxInstrumento.Texts;
                Orden.operacion = TextBoxOperacion.Texts
            }
            catch
            {
                MessageBox.Show("Los valores ingresados en porcentaje Fondo codigo SBS  y en codigo SIN  deben ser números, no deben contener letras. Intente nuevamente");
                return false;
            }

            return true;
        }

    }
}
