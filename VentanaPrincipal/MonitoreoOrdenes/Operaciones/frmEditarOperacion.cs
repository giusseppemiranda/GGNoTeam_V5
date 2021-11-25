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

namespace GGNoTeam_V5.VentanaPrincipal.MonitoreoOrdenes.Operaciones
{
    public partial class frmEditarOperacion : Form
    {
        private TrackingErrorWS.TrackingErrorWSClient _daoTE;
        private bool insertarOperacion = false;
        private MonitoreoOrdenWS.MonitorOrdenWSClient _daoMO;
        private MonitoreoOrdenWS.operacion Operacion;

        //Insertar Operacion
        public frmEditarOperacion()
        {
            InitializeComponent();
            _daoMO = new MonitoreoOrdenWS.MonitorOrdenWSClient();
            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();
            insertarOperacion = true;
            cambiarTema();
            cargarComboValidacion();
            cargarTipoEdicion();
            //cargarComboFondo();
        }

        //Modificar Operacion
        public frmEditarOperacion(MonitoreoOrdenWS.operacion operacion)
        {
            InitializeComponent();
            _daoMO = new MonitoreoOrdenWS.MonitorOrdenWSClient();
            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();
            Operacion = operacion;
            cargarComboValidacion();
            cambiarTema();
            cargarTipoEdicion();
            cargarDatosOperacion();
            //cargarComboFondo();
        }

       /*
        private void cargarComboFondo()
        {
            String[] fondos = _daoTE.ListarFondos();
            comboFondo.DataSource = fondos;
        }
       */
        private void cargarTipoEdicion()
        {
            if (insertarOperacion)
            {
                lblTitulo.Text = "Insertar Operacion";
                btnSiguiente.Text = "Insertar";
            }
            else
            {
                lblTitulo.Text = "Modificar Operacion";
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cargarDatosOperacion()
        {
            double eje = 0; 
            double ord=0;
            dateTimePicker1.Value = Convert.ToDateTime(Operacion.fecha);
            //comboFondo.SelectedIndex = Operacion.fondo - 1;
            MonitoreoOrdenWS.ejecucion[] ejecuciones = _daoMO.listarTodosEjecucion();
            MonitoreoOrdenWS.orden[] ordenes= _daoMO.listaTodosOrden();

            foreach (var orden in ordenes)
            {
                if (orden.idOrden == Operacion.fidOrden) ord = orden.porcentageFondo;
            }
            foreach (var ejecucion in ejecuciones)
            {
                if (ejecucion.idEjecucion== Operacion.fidEjecu) eje= ejecucion.AUM;
            }

            TextBoxAUMEjecuciones.Texts = eje.ToString();
            TextBoxAUMOrdenes.Texts = ord.ToString();

            comboValidacion.SelectedIndex = Convert.ToInt32(Operacion.validacion);
            TextBoxCodigoSbs.Texts = Operacion.codsbs;
            TextBoxCodigoSin.Texts = Operacion.codisin;
            TextBoxComentarios.Texts = Operacion.comentario;
            TextBoxInstrumento.Texts = Operacion.instrumento;
            TextBoxOperacion.Texts = Operacion.idOperacion.ToString();
            
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (insertarOperacion)
            {
                Operacion = new MonitoreoOrdenWS.operacion();
                if (cargarDatos())
                {
                    int i = _daoMO.insertarOperacion(Operacion);
                    if (i != 0)
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
                    int i = _daoMO.modificarOperacion(Operacion);
                    if (i == 0)
                    {
                        MessageBox.Show("Se ha realizado correctamente la modificación");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al modificar.");
                    }

                }
            }
        }
        private void cargarComboValidacion()
        {
            String[] validacion = { "False", "True" };
            comboValidacion.DataSource = validacion;
        }
        private bool cargarDatos()
        {
            Operacion.fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            if (TextBoxAUMOrdenes.Texts == "")
            {
                MessageBox.Show("AUM Ordenes no puede tener un campo vacío");
                return false;
            }

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
                Operacion.fidEjecu= Convert.ToInt32(TextBoxAUMEjecuciones.Texts);
                Operacion.fidOrden= Convert.ToInt32(TextBoxAUMOrdenes.Texts);
                
                Operacion.codsbs = TextBoxCodigoSbs.Texts;
                Operacion.codisin = TextBoxCodigoSin.Texts;
                Operacion.comentario = TextBoxComentarios.Texts;
                Operacion.instrumento = TextBoxInstrumento.Texts;
                //Operacion.operacion= Convert.ToInt32(TextBoxOperacion.Texts);
                Operacion.validacion = Convert.ToBoolean(comboValidacion.SelectedIndex);

            }
            catch
            {
                MessageBox.Show("Los valores ingresados en porcentaje Fondo codigo SBS  y en codigo SIN deben ser números, no deben contener letras. Intente nuevamente");
                return false;
            }

            return true;
        }

    }
}
