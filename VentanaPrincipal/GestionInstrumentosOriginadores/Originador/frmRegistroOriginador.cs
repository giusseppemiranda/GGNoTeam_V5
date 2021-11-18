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
        public frmRegistroOriginador()
        {
            InitializeComponent();
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
            emi.codigo = emiAux.codigo;
            emi.nombre = emiAux.nombre;
        }
        private void btnBuscarOriginador_Click(object sender, EventArgs e)
        {
            frmBusquedaEmisor emi = new frmBusquedaEmisor(this,boxEmisor.Texts);

        }
    }
}
