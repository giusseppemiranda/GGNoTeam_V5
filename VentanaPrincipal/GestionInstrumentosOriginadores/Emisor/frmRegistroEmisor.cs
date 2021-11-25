using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.GestionInstrumentosOriginadores.Emisor
{
    public partial class frmRegistroEmisor : Form
    {
        public frmRegistroEmisor()
        {
            InitializeComponent();
        }
        public frmRegistroEmisor(GestionInstrumentosOriginadoresWS.emisor emi)
        {
            InitializeComponent();
            boxCodigoEmisor.Texts = emi.codigoEmisor.ToString();
            boxNombreEmisor.Texts = emi.nombre;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }
    }
}
