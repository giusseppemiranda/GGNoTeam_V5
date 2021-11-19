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
        public frmRegistroOriginador()
        {
            InitializeComponent();
            lblRegistroOriginador.Text = "Registro originador";
            _daoOrig = new GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient();
            oriAux = new GestionInstrumentosOriginadoresWS.originador();


        }
        public frmRegistroOriginador(GestionInstrumentosOriginadoresWS.originador orig)
        {
            InitializeComponent();
            lblRegistroOriginador.Text = "Modificar originador";
            boxCodigoOriginador.Texts = orig.codigoOriginador;
            boxNombreOriginador.Texts = orig.nombreOriginador;
            boxSector.Texts = orig.sectorGics;
            _daoOrig = new GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient();
            //emi=_daoOrig.listarEmisores(orig.fidEmisor); //REEMPLAZAR LISTAR EMISOR X CODIGO
            boxEmisor.Texts = emi.codigoEmisor; 
            lblNombreEmisor.Text = emi.nombre;
        }

        public void cargarEmisor(GestionInstrumentosOriginadoresWS.emisor emiAux)
        {
            emi.idEmisor = emiAux.idEmisor;
            emi.codigoEmisor = emiAux.codigoEmisor;
            emi.nombre = emiAux.nombre;
        }
        private void btnBuscarOriginador_Click(object sender, EventArgs e)
        {
            frmBusquedaEmisor buscaEmi = new frmBusquedaEmisor(this, boxEmisor.Texts);
            buscaEmi.ShowDialog();
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
                _daoOrig.modificarOriginador(oriAux);
                MessageBox.Show("Modificación exitosa!");
            }
            else
            {

                _daoOrig.insertarOriginador(oriAux);
                MessageBox.Show("Registro exitoso!");
            }
            
            this.Dispose();
        }
    }
}
