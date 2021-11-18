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
        private GestionInstrumentosOriginadoresWS.originador ori;
        public frmRegistroOriginador()
        {
            InitializeComponent();
            _daoOrig = new GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient();
            ori = new GestionInstrumentosOriginadoresWS.originador();
            ori.codigoOriginador = boxCodigoOriginador.Texts;
            ori.nombreOriginador = boxNombreOriginador.Texts;
            ori.sectorGics = boxSector.Texts;
            ori.fidEmisor = emi.codigo;

        }
        public frmRegistroOriginador(GestionInstrumentosOriginadoresWS.originador orig)
        {
            InitializeComponent();
            boxCodigoOriginador.Texts = orig.codigoOriginador;
            boxNombreOriginador.Texts = orig.nombreOriginador;
            boxSector.Texts = orig.sectorGics;

            //boxEmisor.Texts = orig.fidEmisor;
        }

        public void cargarEmisor(GestionInstrumentosOriginadoresWS.emisor emiAux)
        {
            //emi.idEmisor = emiAux.idEmisor;
            emi.codigo = emiAux.codigo;
            emi.nombre = emiAux.nombre;
        }
        private void btnBuscarOriginador_Click(object sender, EventArgs e)
        {
            frmBusquedaEmisor emi = new frmBusquedaEmisor(this, boxEmisor.Texts);
            emi.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
