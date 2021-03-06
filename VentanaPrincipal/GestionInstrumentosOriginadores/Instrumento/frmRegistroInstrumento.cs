using GGNoTeam_V5.Recursos.Validaciones;
using GGNoTeam_V5.VentanaPrincipal.GestionInstrumentosOriginadores.Originador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.GestionInstrumentosOriginadores.Instrumento
{
    public partial class frmRegistroInstrumento : Form
    {
        private GestionInstrumentosOriginadoresWS.originador orig;
        private GestionInstrumentosOriginadoresWS.originador[] originadores;
        private GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient _daoInst;
        private GestionInstrumentosOriginadoresWS.instrumento instAux;
        private string codigoAnt;
        public frmRegistroInstrumento(GestionInstrumentosOriginadoresWS.instrumento inst)
        {
            InitializeComponent();
            cargarCombos();
            Program.acccionGlobal.tablaReferenciada = "Instrumentos";
            Program.acccionGlobal.tipoAccion = "Modificar";
            instAux = new GestionInstrumentosOriginadoresWS.instrumento();
            lblRegistroInstrumento.Text = "Modificar instrumento";
            instAux.idInstrumento = inst.idInstrumento;
            boxcodSBS.Texts = inst.codigoSBS;
            boxcodISIN.Texts = inst.codigoISIN;
            boxScore.Texts = inst.score;
            boxID059.Texts = inst.codigoID059;
            boxRatingEncajeSistema.Texts = inst.ratingEncajeSistema;
            boxRatingUnificado.Texts = inst.ratingUnificado;
            comboBoxAssetClass.SelectedItem = inst.clasificacionErr.ToString();
            boxClasificacionLocal.Texts = inst.ratingUnificadoLocal;
            boxFactorRiesgo.Texts = inst.factorRiesgo;
            comboBoxLimiteAplicable.SelectedItem = inst.limiteAplicable.ToString();
            boxRatingEncaje.Texts = inst.ratingEncaje;
            _daoInst = new GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient();
            orig = new GestionInstrumentosOriginadoresWS.originador();            
            orig = _daoInst.buscarOrigId(inst.fidOriginador);
            boxCodigoOriginador.Texts = orig.codigoOriginador;
            codigoAnt = orig.codigoOriginador;
            lblNombreOriginador.Text = orig.nombreOriginador;
            
            dateVencimiento.Value = DateTime.Parse(inst.fechaVencimiento.Replace("-","/"));

            dateRegistro.Value = DateTime.Parse(inst.fechaRegistro.Replace("-", "/"));
            dateRegistro.Enabled = false;
            dateUltimaModificacion.Value = DateTime.Parse(inst.fechaUltimaClasificacion.Replace("-", "/")); 
            boxMoody.Texts = inst.moodys;
            dateMoody.Value = DateTime.Parse(inst.fechaMoodys.Replace("-", "/"));



        }

        public frmRegistroInstrumento(GestionInstrumentosOriginadoresWS.instrumento inst,int i)
        {
            InitializeComponent();
            cargarCombos();
            Program.acccionGlobal.tablaReferenciada = "Instrumentos";
            Program.acccionGlobal.tipoAccion = "Insertar";
            instAux = new GestionInstrumentosOriginadoresWS.instrumento();
            lblRegistroInstrumento.Text = "Registro instrumento";
            //instAux.idInstrumento = inst.idInstrumento;
            boxcodSBS.Texts = inst.codigoSBS;
            boxcodISIN.Texts = inst.codigoISIN;
            boxScore.Texts = inst.score;
            boxID059.Texts = inst.codigoID059;
            boxRatingEncajeSistema.Texts = inst.ratingEncajeSistema;
            boxRatingUnificado.Texts = inst.ratingUnificado;
            comboBoxAssetClass.SelectedItem = inst.clasificacionErr.ToString();
            boxClasificacionLocal.Texts = inst.ratingUnificadoLocal;
            boxFactorRiesgo.Texts = inst.factorRiesgo;
            comboBoxLimiteAplicable.SelectedItem = inst.limiteAplicable.ToString();
            boxRatingEncaje.Texts = inst.ratingEncaje;
            _daoInst = new GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient();
            orig = new GestionInstrumentosOriginadoresWS.originador();
            orig = _daoInst.buscarOrigId(inst.fidOriginador);
            boxCodigoOriginador.Texts = orig.codigoOriginador;
            codigoAnt = orig.codigoOriginador;
            lblNombreOriginador.Text = orig.nombreOriginador;

            dateVencimiento.Value = DateTime.Parse(inst.fechaVencimiento.Replace("-", "/"));


            //dateRegistro.Value = DateTime.Parse(inst.fechaRegistro.Replace("-", "/"));
            dateRegistro.Enabled = false;
            dateUltimaModificacion.Value = DateTime.Parse(inst.fechaUltimaClasificacion.Replace("-", "/"));
            boxMoody.Texts = inst.moodys;
            dateMoody.Value = DateTime.Parse(inst.fechaMoodys.Replace("-", "/"));



        }

        public frmRegistroInstrumento()
        {
            InitializeComponent();
            Program.acccionGlobal.tablaReferenciada = "Instrumentos";
            Program.acccionGlobal.tipoAccion = "Insertar";
            _daoInst = new GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient();
            cargarCombos();
            instAux = new GestionInstrumentosOriginadoresWS.instrumento();
            orig = new GestionInstrumentosOriginadoresWS.originador();
            lblRegistroInstrumento.Text = "Registro instrumento";
            codigoAnt = "";
            dateRegistro.Enabled = false;
        }
        
        public void cargarOriginador(GestionInstrumentosOriginadoresWS.originador origAux)
        {
            orig.idOriginador = origAux.idOriginador;
            orig.codigoOriginador = origAux.codigoOriginador;
            orig.nombreOriginador = origAux.nombreOriginador;
        }
        private void ggTextBox9__TextChanged(object sender, EventArgs e)
        {

        }

        private void ggTextBox12__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarOriginador_Click(object sender, EventArgs e)
        {
            originadores=_daoInst.buscarUnOriginadorPorCodigo(boxCodigoOriginador.Texts);
            if (originadores != null)
            {
                frmBusquedaOrig busquedaOrig = new frmBusquedaOrig(this, originadores);
                busquedaOrig.ShowDialog();
                boxCodigoOriginador.Texts = orig.codigoOriginador;
                codigoAnt = orig.codigoOriginador;
                lblNombreOriginador.Text = orig.nombreOriginador;
            }
            else
            {
                MessageBox.Show("No se encontró ningun originador");
                boxCodigoOriginador.Texts = codigoAnt;
            }
        }

        private void boxCodigoOriginador__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        //true si hay errores
        //false si no tiene errores
        private bool validaciones()
        {
            int valido = -1;

            valido = ValidarTextBox.alfaNumerico(boxcodSBS, "El código SBS", 45);
            if (valido != 0) return true;

            valido = ValidarTextBox.alfaNumerico(boxcodISIN, "El código ISIN", 45);
            if (valido != 0) return true;

            valido = ValidarTextBox.alfaNumerico(boxID059, "El ID-059", 45);
            if (valido != 0) return true;

            valido = ValidarTextBox.alfaNumerico(boxClasificacionLocal, "La clasificación local", 10);
            if (valido != 0) return true;

            valido = ValidarTextBox.alfaNumerico(boxRatingEncaje, "El rating encaje", 10);
            if (valido != 0) return true;

            valido = ValidarTextBox.alfaNumerico(boxRatingEncajeSistema, "El rating encaje de Sistema", 10);
            if (valido != 0) return true;

            valido = ValidarTextBox.NumeroEntero(boxMoody, "Moddys", 3);
            if (valido != 0) return true;

            valido = ValidarTextBox.NumeroEntero(boxScore, "Score", 3);
            if (valido != 0) return true;

            valido = ValidarTextBox.alfaNumerico(boxRatingUnificado, "El rating unificado", 10);
            if (valido != 0) return true;

            valido = ValidarTextBox.PuntoFlotante(boxFactorRiesgo, "El factor de riesgo");
            if (valido != 0) return true;

            if(Convert.ToDouble(boxFactorRiesgo.Texts)< 0 && Convert.ToDouble(boxFactorRiesgo.Texts) > 1)
            {
                MessageBox.Show("Factor Riesgo debe encontrarse entre 0 y 1");
                return true;
            }

            boxCodigoOriginador.Texts = boxCodigoOriginador.Texts.Trim();
            if(boxCodigoOriginador.Texts == "")
            {
                MessageBox.Show("Codigo originador no debe estar vacío.");
                return true;
            }

            return false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (validaciones()) return;
            Program.acccionGlobal.fecha = DateTime.Now.ToString("yyyy-MM-dd");
            Program.acccionGlobal.hora = DateTime.Now.ToString("HH:mm:ss");
            instAux.codigoSBS = boxcodSBS.Texts;
            instAux.codigoISIN = boxcodISIN.Texts;
            instAux.codigoID059 = boxID059.Texts;
            instAux.score = boxScore.Texts;
            //GestionInstrumentosOriginadoresWS.eClasificacionErr myEnum = (GestionInstrumentosOriginadoresWS.eClasificacionErr)Enum.Parse(typeof(GestionInstrumentosOriginadoresWS.eClasificacionErr), myString);
            instAux.clasificacionErr = (GestionInstrumentosOriginadoresWS.eClasificacionErr)Enum.Parse(typeof(GestionInstrumentosOriginadoresWS.eClasificacionErr),(comboBoxAssetClass.SelectedItem.ToString()));
            instAux.clasificacionErrSpecified = true;
            instAux.ratingUnificadoLocal = boxClasificacionLocal.Texts;
            instAux.ratingUnificado = boxRatingUnificado.Texts;
            instAux.factorRiesgo = boxFactorRiesgo.Texts;
            instAux.limiteAplicable = (GestionInstrumentosOriginadoresWS.eLimiteAplicable)Enum.Parse(typeof(GestionInstrumentosOriginadoresWS.eLimiteAplicable),(comboBoxLimiteAplicable.SelectedItem.ToString()));
            instAux.limiteAplicableSpecified = true;
            instAux.ratingEncaje = boxRatingEncaje.Texts;
            instAux.ratingEncajeSistema = boxRatingEncajeSistema.Texts;
            instAux.fidOriginador = orig.idOriginador;
            instAux.fechaVencimiento = dateVencimiento.Value.ToString("yyyy/MM/dd").Replace("/","-");
            instAux.fechaRegistro = dateRegistro.Value.ToString("yyyy/MM/dd").Replace("/", "-");
            instAux.fechaUltimaClasificacion = dateUltimaModificacion.Value.ToString("yyyy/MM/dd").Replace("/", "-");
            instAux.moodys = boxMoody.Texts;
            instAux.fechaMoodys = dateMoody.Value.ToString("yyyy/MM/dd").Replace("/", "-");
            instAux.activo = 1;

            if (lblRegistroInstrumento.Text == "Modificar instrumento")
            {
                if (_daoInst.modificarInstrumento(instAux) > 0)
                {
                    MessageBox.Show("Modificación exitosa!");
                    Program.acccionGlobal.idObjeto=instAux.idInstrumento;
                    Program._daoAcciones.insertarAccion(Program.acccionGlobal);
                }
                else
                    MessageBox.Show("Error al modificar");
            }
            else
            {
                int a= _daoInst.insertarInstrumento(instAux);
                MessageBox.Show("Registro exitoso!");
                Program.acccionGlobal.idObjeto = a;
                Program._daoAcciones.insertarAccion(Program.acccionGlobal);
            }

            
            
            this.Dispose();

        }

        private void cargarCombos()
        {
            string[] AssetClassEnum = Enum.GetNames(typeof(GestionInstrumentosOriginadoresWS.eClasificacionErr));
            string[] LimiteAplicableEnum = Enum.GetNames(typeof(GestionInstrumentosOriginadoresWS.eLimiteAplicable));
            //string[] ClasificacionLocalEnum = Enum.GetNames(typeof(GestionInstrumentosOriginadoresWS.));
            comboBoxAssetClass.DataSource = AssetClassEnum;
            comboBoxLimiteAplicable.DataSource = LimiteAplicableEnum;
            //comboBoxClasificacionLocal.DataSource = ;
        }

    }
}
