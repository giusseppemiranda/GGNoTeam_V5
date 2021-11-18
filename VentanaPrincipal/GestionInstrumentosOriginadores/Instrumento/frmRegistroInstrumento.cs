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
        public frmRegistroInstrumento(GestionInstrumentosOriginadoresWS.instrumento inst)
        {
            InitializeComponent();
            boxcodSBS.Texts = inst.codigoSBS;
            boxcodISIN.Texts = inst.codigoISIN;
        }

        public frmRegistroInstrumento()
        {
            InitializeComponent();
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
            frmBusquedaOrig busquedaOrig = new frmBusquedaOrig(this,boxCodigoOriginador.Texts);
            busquedaOrig.ShowDialog();
        }

        private void boxCodigoOriginador__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
