using GGNoTeam_V5.VentanaPrincipal.GestionInstrumentosOriginadores.Originador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            instAux = new GestionInstrumentosOriginadoresWS.instrumento();
            lblRegistroInstrumento.Text = "Modificar instrumento";
            instAux.idInstrumento = inst.idInstrumento;
            boxcodSBS.Texts = inst.codigoSBS;
            boxcodISIN.Texts = inst.codigoISIN;
            boxScore.Texts = inst.score;
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
            dateVencimiento.Value = inst.fechaVencimiento;

            inst.fechaRegistroSpecified = true;
            dateRegistro.Value = inst.fechaRegistro;
                        
            dateUltimaModificacion.Value = inst.fechaUltimaClasificacion;
            boxMoody.Texts = inst.moodys;
            dateMoody.Value = inst.fechaMoodys;



        }

        public frmRegistroInstrumento()
        {
            InitializeComponent();
            _daoInst = new GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient();
            cargarCombos();
            instAux = new GestionInstrumentosOriginadoresWS.instrumento();
            orig = new GestionInstrumentosOriginadoresWS.originador();
            lblRegistroInstrumento.Text = "Registro instrumento";
            codigoAnt = "";
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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            instAux.codigoSBS = boxcodSBS.Texts;
            instAux.codigoISIN = boxcodISIN.Texts;
            instAux.score = boxScore.Texts;
            instAux.clasificacionErr = (GestionInstrumentosOriginadoresWS.eClasificacionErr)comboBoxAssetClass.SelectedIndex;
            instAux.ratingUnificadoLocal = boxClasificacionLocal.Texts;
            instAux.factorRiesgo = boxFactorRiesgo.Texts;
            instAux.limiteAplicable = (GestionInstrumentosOriginadoresWS.eLimiteAplicable)comboBoxLimiteAplicable.SelectedIndex;
            instAux.ratingEncaje = boxRatingEncaje.Texts;
            instAux.fidOriginador = orig.idOriginador;
            instAux.fechaVencimiento = dateVencimiento.Value;
            instAux.fechaRegistro = dateRegistro.Value;
            instAux.fechaUltimaClasificacion = dateUltimaModificacion.Value;
            instAux.moodys = boxMoody.Texts;
            instAux.fechaMoodys = dateMoody.Value;
            instAux.activo = 1;

            if (lblRegistroInstrumento.Text == "Modificar instrumento")
            {
                _daoInst.modificarInstrumento(instAux);
                MessageBox.Show("Modificación exitosa!");
            }
            else
            {
                _daoInst.insertarInstrumento(instAux);
                MessageBox.Show("Registro exitoso!");
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
