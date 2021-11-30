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

namespace GGNoTeam_V5.VentanaPrincipal.TrackingErrorVSAlpha.AssetError.Registros
{
    public partial class frmEditarRegistroAssetError : Form
    {
        private TrackingErrorWS.TrackingErrorWSClient _daoTE;
        private bool insertarAssetError = false;
        private TrackingErrorWS.assetError AssetError;

        //Insertar AssetError
        public frmEditarRegistroAssetError()
        {
            InitializeComponent();
            
            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();

            insertarAssetError = true;
            cambiarTema();
            cargarTipoEdicion();
            cargarComboFondo();
        }

        //Modificar AssetError
        public frmEditarRegistroAssetError(TrackingErrorWS.assetError asset)
        {
            InitializeComponent();

            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();
            
            AssetError = asset;
            cambiarTema();
            cargarTipoEdicion();
            cargarComboFondo();
            cargarDatosAsset();
        }

        private void cargarDatosAsset()
        {
            dateTimePicker1.Value = AssetError.fecha;
            comboFondo.SelectedIndex = AssetError.fidFondo - 1;
            boxNombre.Texts = AssetError.nombre;
            boxWGT.Texts = AssetError.wgtP.ToString();
            boxTotalRisk.Texts = AssetError.totalRiskD.ToString();
        }

        /*
        public frmEditarRegistroAssetError()
        {
            InitializeComponent();
            _daoTE = new TrackingErrorWS.TrackingErrorWSClient();
            cambiarTema();
            cargarTipoEdicion();  
        }
        */

        private void cargarComboFondo()
        {
            String[] fondos = _daoTE.ListarFondos();
            comboFondo.DataSource = fondos;
        }

        private void cargarTipoEdicion()
        {
            if (insertarAssetError)
            {
                lblTitulo.Text = "Insertar Asset Error";
                btnSiguiente.Text = "Insertar";
            } else
            {
                lblTitulo.Text = "Modificar Asset Error";
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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (insertarAssetError) casoInsertar();
            else casoModificar();                        
        }

        private void casoModificar()
        {
            if (cargarDatos())
            {
                int i = _daoTE.modificarAssetError(AssetError, AssetError.fidFondo);
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

        private void casoInsertar()
        {
            int i = -1;
            AssetError = new TrackingErrorWS.assetError();
            if (cargarDatos())
            {
                i = _daoTE.insertarAssetError(AssetError, AssetError.fidFondo);
                if (i != 0)
                {
                    MessageBox.Show("La inserción fue realizada con éxito.");
                    CargarLogInsertar(i);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Hubo un error al insertar.");
                }

            }
        }

        private void CargarLogInsertar(int id)
        {
            Program.acccionGlobal.fecha = DateTime.Now.ToString("yyyy-MM-dd");
            Program.acccionGlobal.hora = DateTime.Now.ToString("HH:mm:ss");
            Program.acccionGlobal.idObjeto = id;
            Program.acccionGlobal.tablaReferenciada = "TrackingError";
            Program.acccionGlobal.tipoAccion = "Insertar";
            Program._daoAcciones.insertarAccion(Program.acccionGlobal);
        }

        private bool cargarDatos()
        {
            AssetError.fecha = dateTimePicker1.Value;
            AssetError.fechaSpecified = true;
            AssetError.fidFondo = comboFondo.SelectedIndex + 1;
            AssetError.nombre = boxNombre.Texts;
            

            if(AssetError.nombre == "")
            {
                MessageBox.Show("El nombre del objeto Asset Error no puede ser vacío.");
                return false;
            }

            if(AssetError.nombre.Length > 30)
            {
                MessageBox.Show("El nombre del objeto Asset Error no debe contener más de 30 caracteres");
                return false;
            }

            if(boxWGT.Texts == "")
            {
                MessageBox.Show("WGT no puede tener un campo vacío");
                return false;
            }

            if (boxTotalRisk.Texts == "")
            {
                MessageBox.Show("TotalRisk no puede tener un campo vacío");
                return false;
            } 

            try
            {
                AssetError.wgtP = Convert.ToDouble(boxWGT.Texts);
                AssetError.totalRiskD = Convert.ToDouble(boxTotalRisk.Texts);
                //if(AssetError.wgtP > 10)
                //{
                //    MessageBox.Show("El valor de wgtP debe encontrarse entre 0 y 10.");
                //    return false;
                //}
                //if (AssetError.totalRiskD > 10)
                //{
                //    MessageBox.Show("El valor de totalRisk debe encontrarse entre 0 y 10.");
                //    return false;
                //}
            }
            catch
            {
                MessageBox.Show("Los valores ingresados en wgtP y en Total Risk deben ser números, no deben contener letras. Intente nuevamente");
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
