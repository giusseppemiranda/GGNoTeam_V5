using GGNoTeam_V5.Recursos.UserControls;
using GGNoTeam_V5.Recursos.Validaciones;
using System;
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

            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();
            dato = new TrackingErrorWS.dataValorCuota();
            lblTitulo.Text = "INSERTAR DATA VALOR CUOTA";
            insertar = true;

            cambiarTema();
            cargarCombo();
            cargarComboAFP(listaAfps);

            comboAFP.SelectedIndex = 0;
            comboFondo.SelectedIndex = 0;

        }

        //EDITAR DATA VALOR CUOTA
        public frmEditarRegistroDataValorCuota(TrackingErrorWS.dataValorCuota dato, TrackingErrorWS.afp[] listaAfps, int tipoFondo)
        {
            InitializeComponent();

            lblTitulo.Text = "EDITAR DATA VALOR CUOTA";
            this.dato = dato;
            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();

            cambiarTema();
            cargarCombo();
            cargarComboAFP(listaAfps);
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
            for (int i = 0; i < listaAfps.Length; i++)
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
            if (pasarValidaciones() != 0) return;

            cargarDatos();

            int fidFondo = calcularFidFondo();

            if (insertar) casoInsertar(fidFondo);
            else casoModificar(fidFondo);            

        }

        private int pasarValidaciones()
        {
            int validar = -1;
            validar = ValidarTextBox.PuntoFlotante(boxCuota, "La CUOTA");
            if (validar != 0) return validar;
            validar = ValidarTextBox.PuntoFlotante(boxValorCuota, "El VALOR CUOTA");
            if (validar != 0) return validar;

            return validar;
        }
        
        private void casoModificar(int fidFondo)
        {
            int i = -1;
            i = _daoTE.modificarDataValorCuota(dato, fidFondo);
            if (i == 1)
            {
                MessageBox.Show("Se modificó correctamente.");
                cargarLogModificar(dato.idDataValorCuota);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se han modificado los valores en la base de datos.");
            }
        }


        
        private void casoInsertar(int fidFondo)
        {
            int i = -1;
            i = _daoTE.insertarDataValorCuota(dato, fidFondo);
            if (i != 0)
            {
                MessageBox.Show("Se insertó correctamente.");
                cargarLogInsertar(i);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se han insertado los valores en la base de datos.");
            }
        }

        private void cargarLogInsertar(int id)
        {            
            Program.acccionGlobal.fecha = DateTime.Now.ToString("yyyy-MM-dd");
            Program.acccionGlobal.hora = DateTime.Now.ToString("HH:mm:ss");
            Program.acccionGlobal.idObjeto = id;
            Program.acccionGlobal.tablaReferenciada = "Alpha";
            Program.acccionGlobal.tipoAccion = "Insertar";
            Program._daoAcciones.insertarAccion(Program.acccionGlobal);       
        }

        private void cargarLogModificar(int id)
        {
            Program.acccionGlobal.fecha = DateTime.Now.ToString("yyyy-MM-dd");
            Program.acccionGlobal.hora = DateTime.Now.ToString("HH:mm:ss");
            Program.acccionGlobal.idObjeto = id;
            Program.acccionGlobal.tablaReferenciada = "Alpha";
            Program.acccionGlobal.tipoAccion = "Modificar";
            Program._daoAcciones.insertarAccion(Program.acccionGlobal);
        }

        private void cargarDatos()
        {
            dato.fecha = dateTimePicker1.Value;
            dato.fechaSpecified = true;
            dato.fidAFP = comboAFP.SelectedIndex + 1;
            dato.cuotas = Convert.ToDouble(boxCuota.Texts);
            dato.valorCuota = Convert.ToDouble(boxValorCuota.Texts);
        }

        private int calcularFidFondo()
        {
            int fidFondo = 0;

            fidFondo = 3 * (comboAFP.SelectedIndex) + comboFondo.SelectedIndex + 1;            

            return fidFondo;
        }

        private void boxCuota__TextChanged(object sender, EventArgs e)
        {
            try
            {
                double cuota = Convert.ToDouble(boxCuota.Texts);
                double valorCuota = Convert.ToDouble(boxValorCuota.Texts);
                double patrimonio = cuota * valorCuota;

                boxPatrimonio.Texts = patrimonio.ToString();
            }
            catch
            {
                boxPatrimonio.Texts = "ERROR";
                return;
            }
        }

        private void boxValorCuota__TextChanged(object sender, EventArgs e)
        {
            try
            {
                double cuota = Convert.ToDouble(boxCuota.Texts);
                double valorCuota = Convert.ToDouble(boxValorCuota.Texts);
                double patrimonio = cuota * valorCuota;

                boxPatrimonio.Texts = patrimonio.ToString();
            }
            catch
            {
                boxPatrimonio.Texts = "ERROR";
                return;
            }
        }

        private void frmEditarRegistroDataValorCuota_Load(object sender, EventArgs e)
        {

        }
    }
}
