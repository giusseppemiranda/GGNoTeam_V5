using GGNoTeam_V5.VentanaPrincipal.GestionInstrumentosOriginadores.Emisor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.GestionInstrumentosOriginadores.Originador
{
    public partial class frmRegistroOriginador : Form
    {
        private GestionInstrumentosOriginadoresWS.emisor emi;
        private GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient _daoOrig;
        private GestionInstrumentosOriginadoresWS.originador oriAux;
        private GestionInstrumentosOriginadoresWS.emisor[] emisores;
        private string codigoAnt;
        public frmRegistroOriginador()
        {
            InitializeComponent();
            Program.acccionGlobal.tablaReferenciada = "Originadores";
            lblRegistroOriginador.Text = "Registro originador";
            _daoOrig = new GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient();
            oriAux = new GestionInstrumentosOriginadoresWS.originador();
            codigoAnt = "";

        }
        public frmRegistroOriginador(GestionInstrumentosOriginadoresWS.originador orig)
        {
            InitializeComponent();
            Program.acccionGlobal.tablaReferenciada = "Originadores";
            oriAux = new GestionInstrumentosOriginadoresWS.originador();
            oriAux.idOriginador = orig.idOriginador;
            lblRegistroOriginador.Text = "Modificar originador";
            boxCodigoOriginador.Texts = orig.codigoOriginador;
            boxNombreOriginador.Texts = orig.nombreOriginador;
            boxSector.Texts = orig.sectorGics;
            _daoOrig = new GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient();
            emi=_daoOrig.BuscarUnEmisorPorID(orig.fidEmisor); 
            boxEmisor.Texts = emi.codigoEmisor;
            codigoAnt = boxEmisor.Texts;
            lblNombreEmisor.Text = emi.nombre;
        }

        public frmRegistroOriginador(GestionInstrumentosOriginadoresWS.originador orig,int i)
        {
            InitializeComponent();
            Program.acccionGlobal.tablaReferenciada = "Originadores";
            oriAux = new GestionInstrumentosOriginadoresWS.originador();
            //oriAux.idOriginador = orig.idOriginador;
            lblRegistroOriginador.Text = "Registro originador";
            boxCodigoOriginador.Texts = orig.codigoOriginador;
            boxNombreOriginador.Texts = orig.nombreOriginador;
            boxSector.Texts = orig.sectorGics;
            _daoOrig = new GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient();
            emi = _daoOrig.BuscarUnEmisorPorID(orig.fidEmisor);
            boxEmisor.Texts = emi.codigoEmisor;
            codigoAnt = boxEmisor.Texts;
            lblNombreEmisor.Text = emi.nombre;
        }

        public void cargarEmisor(GestionInstrumentosOriginadoresWS.emisor emiAux)
        {
            emi.idEmisor = emiAux.idEmisor;
            emi.codigoEmisor = emiAux.codigoEmisor;
            emi.nombre = emiAux.nombre;
        }
        private void btnBuscarEmisor_Click(object sender, EventArgs e)
        {
            emisores = _daoOrig.listarEmisoresPorNombreCodigo(boxEmisor.Texts);
            if (emisores != null)
            {
                frmBusquedaEmisor buscaEmi = new frmBusquedaEmisor(this,emisores);
                buscaEmi.ShowDialog();
                boxEmisor.Texts = emi.codigoEmisor;
                codigoAnt = emi.codigoEmisor;
                lblNombreEmisor.Text = emi.nombre;
            }
            else
            {
                MessageBox.Show("No se encontró ningun emisor");
                boxEmisor.Texts = codigoAnt;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            oriAux.codigoOriginador = boxCodigoOriginador.Texts;
            oriAux.nombreOriginador = boxNombreOriginador.Texts;
            oriAux.sectorGics = boxSector.Texts;
            oriAux.fidEmisor = emi.idEmisor;

            if (lblRegistroOriginador.Text == "Modificar originador")
            {
                if (_daoOrig.modificarOriginador(oriAux) > 0)
                {
                    MessageBox.Show("Modificación exitosa!");
                    Program.acccionGlobal.tipoAccion = "Modificar";
                }
                else
                    MessageBox.Show("Revise los campos e intente de nuevo", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                _daoOrig.insertarOriginador(oriAux);
                MessageBox.Show("Registro exitoso!");
                Program.acccionGlobal.tipoAccion = "Insertar";
            }
            Program.acccionGlobal.fecha = DateTime.Now.ToString("yyyy-MM-dd");
            Program.acccionGlobal.hora = DateTime.Now.ToString("HH:mm:ss");
            this.Dispose();
        }

        private void frmRegistroOriginador_Load(object sender, EventArgs e)
        {

        }
    }
}
