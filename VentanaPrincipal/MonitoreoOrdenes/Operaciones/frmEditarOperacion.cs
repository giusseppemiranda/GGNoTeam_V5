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
        //private TrackingErrorWS.TrackingErrorWSClient _daoTE;
        //private bool insertarOperacion = false;
        //private MonitoreoOrdenWS.MonitoreoOrdenWSClient _daoMO;
        //private MonitoreoOrdenWS.operacion Operacion;

        ////Insertar Operacion
        //public frmEditarOperacion()
        //{
        //    InitializeComponent();
        //    _daoMO = new MonitoreoOrdenWS.MonitoreoOrdenWSClient();
        //    _daoTE = new TrackingErrorWS.TrackingErrorWSClient();
        //    insertarOperacion = true;
        //    cambiarTema();
        //    cargarTipoEdicion();
        //    cargarComboFondo();
        //}

        ////Modificar Operacion
        //public frmEditarOperacion(MonitoreoOrdenWS.operacion operacion)
        //{
        //    InitializeComponent();
        //    _daoMO = new MonitoreoOrdenWS.MonitoreoOrdenWSClient();
        //    _daoTE = new TrackingErrorWS.TrackingErrorWSClient();
        //    Operacion = operacion;
        //    cambiarTema();
        //    cargarTipoEdicion();
        //    cargarDatosOperacion();
        //    cargarComboFondo();
        //}
        //private void cargarComboFondo()
        //{
        //    String[] fondos = _daoTE.ListarFondos();
        //    comboFondo.DataSource = fondos;
        //}
        //private void cargarTipoEdicion()
        //{
        //    if (insertarOperacion)
        //    {
        //        lblTitulo.Text = "Insertar Operacion";
        //        btnSiguiente.Text = "Insertar";
        //    }
        //    else
        //    {
        //        lblTitulo.Text = "Modificar Operacion";
        //        btnSiguiente.Text = "Actualizar";
        //    }
        //}

        //public void cambiarTema()
        //{
        //    if (Global.TemaOscuro)
        //    {
        //        activarTemaClaro();
        //    }
        //    else
        //    {
        //        activarTemaOscuro();
        //    }
        //}

        //private void activarTemaOscuro()
        //{
        //    this.BackColor = Global.FrmOscuro;

        //}

        //private void activarTemaClaro()
        //{
        //    this.BackColor = Global.FrmClaro;

        //}

        //private void btnCancelar_Click(object sender, EventArgs e)
        //{
        //    this.Dispose();
        //}

        //private void cargarDatosOperacion()
        //{
        //    dateTimePicker1.Value = Operacion.fecha;
        //    comboFondo.SelectedIndex = Operacion.fondo - 1;
        //    TextBoxAUMEjecuciones.Texts = Operacion.aumSit.AUM;
        //    TextBoxAUMOrdenes.Texts = Operacion.aumOrd.porcentageFondo;
        //    TextBoxCodigoSbs.Texts = Operacion.codsbs;
        //    TextBoxCodigoSin.Texts = Operacion.codisin;
        //    TextBoxComentarios.Texts = Operacion.comentario;
        //    TextBoxInstrumento.Texts = Operacion.instrumento;
        //    TextBoxOperacion.Texts = Operacion.operacion;
        //    TextBoxValidacion.Texts = Operacion.estadoValidacion.ToString();
        //}

        //private void btnSiguiente_Click(object sender, EventArgs e)
        //{
        //    if (insertarOperacion)
        //    {
        //        Operacion = new MonitoreoOrdenWS.MonitoreoOrdenWSClient();
        //        if (cargarDatos())
        //        {
        //            int i = _daoMO.insertarOperacion(Operacion, Operacion.aumOrd.idOrden, Operacion.aumSit.idEjecucion);
        //            if(i == 1)
        //            {
        //                MessageBox.Show("La inserción fue realizada con éxito.");
        //                this.Dispose();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Hubo un error al insertar.");
        //            }
                    
        //        }
        //    } else
        //    {
        //        if (cargarDatos())
        //        {
        //            int i = _daoMO.modificarOperacion(Operacion);
        //            if(i == 0)
        //            {
        //                MessageBox.Show("Se ha realizado correctamente la modificación");
        //                this.Dispose();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Hubo un error al modificar.");
        //            }
                    
        //        }
        //    }            
        //}

        //private bool cargarDatos()
        //{
        //    Operacion.fecha = dateTimePicker1.Value;
        //    Operacion.fechaSpecified = true;
        //    Operacion.fidFondo = comboFondo.SelectedIndex + 1; 


        //    if (TextBoxAUMOrdenes.Texts == "")
        //    {
        //        MessageBox.Show("AUM Ordenes no puede tener un campo vacío");
        //        return false;
        //    }

        //    if (TextBoxAUMEjecuciones.Texts == "")
        //    {
        //        MessageBox.Show("AUM Ejecuciones no puede tener un campo vacío");
        //        return false;
        //    }

        //    if (TextBoxCodigoSbs.Texts == "")
        //    {
        //        MessageBox.Show("Codigo Sbs no puede tener un campo vacío");
        //        return false;
        //    }
        //    if (TextBoxCodigoSin.Texts == "")
        //    {
        //        MessageBox.Show("CodigoSin no puede tener un campo vacío");
        //        return false;
        //    }

        //    if (TextBoxInstrumento.Texts == "")
        //    {
        //        MessageBox.Show("Instrumento no puede tener un campo vacío");
        //        return false;
        //    }

        //    if (TextBoxOperacion.Texts == "")
        //    {
        //        MessageBox.Show("Operacion no puede tener un campo vacío");
        //        return false;
        //    }

        //    try
        //    {
        //        Operacion.aumSit.AUM = Convert.ToDouble(TextBoxAUMEjecuciones.Texts);
        //        Operacion.aumOrd.porcentageFondo = Convert.ToDouble(TextBoxAUMOrdenes.Texts);
        //        Operacion.codsbs = TextBoxCodigoSbs.Texts;
        //        Operacion.codisin = TextBoxCodigoSin.Texts;
        //        Operacion.comentario = TextBoxComentarios.Texts;
        //        Operacion.instrumento = TextBoxInstrumento.Texts;
        //        Operacion.operacion =Convert.ToInt32(TextBoxOperacion.Texts);
        //        Operacion.estadoValidacion = Convert.ToBoolean(TextBoxValidacion.Texts);
                
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Los valores ingresados en porcentaje Fondo codigo SBS  y en codigo SIN deben ser números, no deben contener letras. Intente nuevamente");
        //        return false;
        //    }

        //    return true;
        //}


        
    }
}
