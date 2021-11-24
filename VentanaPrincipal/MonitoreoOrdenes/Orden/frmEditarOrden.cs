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
        private MonitoreoOrdenWS.MonitorOrdenWSClient _daoMO;
        private bool insertarOrden = false;
        private MonitoreoOrdenWS.orden Orden;

        ////Insertar Orden
        public frmEditarOrden()
        {
            InitializeComponent();
            _daoMO = new MonitoreoOrdenWS.MonitorOrdenWSClient();
            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();

            insertarOrden = true;
            cambiarTema();
            cargarTipoEdicion();
            cargarComboFondo();
            cargarComboOperacion();
            cargarComboAssetClass();
        }

        //Modificar Orden
        public frmEditarOrden(MonitoreoOrdenWS.orden orden)
        {
            InitializeComponent();
            _daoMO = new MonitoreoOrdenWS.MonitorOrdenWSClient();
            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();
            Orden = orden;
            cambiarTema();
            cargarTipoEdicion();
            cargarDatosOrden();
            cargarComboOperacion();
            cargarComboAssetClass();
            cargarComboFondo();
        }

        private void cargarDatosOrden()
        {
            TextBoxAUMOrdenes.Texts = Orden.porcentageFondo.ToString();
            TextBoxCodigoSbs.Texts = Orden.codsbs;
            TextBoxCodigoSin.Texts = Orden.codsbs;
            TextBoxInstrumento.Texts = Orden.instrumento;
            dateTimePicker1.Value = Convert.ToDateTime(Orden.fecha);
            //TextBoxOperacion.Texts = Orden.operacion.ToString();
            comboFondo.SelectedIndex = Convert.ToInt32(Orden.fidFondo) - 1;
        }
        private void cargarComboFondo()
        {
            String[] fondos = _daoTE.ListarFondos();
            comboFondo.DataSource = fondos;
        }
        private void cargarComboOperacion()
        {
            String[] operaciones = { "Compra","Venta"};
            comboOperacion.DataSource = operaciones;
        }
        private void cargarComboAssetClass()
        {
            String[] assets = { "Renta Fija", "Renta Variable" };
            ComboAssetClass.DataSource = assets;
        }
        private void cargarTipoEdicion()
        {
            if (insertarOrden)
            {
                lblTitulo.Text = "Insertar Orden";
                btnSiguiente.Text = "Insertar";
            }
            else
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
                    if (i !=0)
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


        private bool cargarDatos()
        {
            Orden.fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Orden.fidFondo= comboFondo.SelectedIndex + 1;

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

            
            try
            {
                Orden.porcentageFondo = Convert.ToDouble( TextBoxAUMOrdenes.Texts);
                Orden.codsbs = TextBoxCodigoSbs.Texts;
                Orden.codisin= TextBoxCodigoSin.Texts;
                Orden.instrumento = TextBoxInstrumento.Texts;
                Orden.fidAssetClass = ComboAssetClass.SelectedIndex + 1;
                Orden.fidTipoOperacion= comboOperacion.SelectedIndex + 1;

            }
            catch
            {
                MessageBox.Show("Los valores ingresados en porcentaje Fondo codigo SBS  y en codigo SIN  deben ser números, no deben contener letras. Intente nuevamente");
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
