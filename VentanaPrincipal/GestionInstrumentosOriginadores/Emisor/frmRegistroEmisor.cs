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
        private GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient _daoInstOrig = new GestionInstrumentosOriginadoresWS.GestionInstOrigWSClient();
        private GestionInstrumentosOriginadoresWS.emisor emiAux;
        public frmRegistroEmisor()
        {
            InitializeComponent();
            emiAux = new GestionInstrumentosOriginadoresWS.emisor();

        }
        public frmRegistroEmisor(GestionInstrumentosOriginadoresWS.emisor emi)
        {
            InitializeComponent();
            lblRegistroEmisor.Text = "Modificar Emisor";
            boxCodigoEmisor.Texts = emi.codigoEmisor.ToString();
            boxNombreEmisor.Texts = emi.nombre;
            emiAux = new GestionInstrumentosOriginadoresWS.emisor();
            emiAux.idEmisor = emi.idEmisor;
        }
        public frmRegistroEmisor(GestionInstrumentosOriginadoresWS.emisor emi,int i)
        {
            InitializeComponent();
            boxCodigoEmisor.Texts = emi.codigoEmisor.ToString();
            boxNombreEmisor.Texts = emi.nombre;
            emiAux = new GestionInstrumentosOriginadoresWS.emisor();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            emiAux.codigoEmisor = boxCodigoEmisor.Texts;
            emiAux.nombre = boxNombreEmisor.Texts;
            if (lblRegistroEmisor.Text == "Modificar Emisor")
            {
                _daoInstOrig.modificarEmisor(emiAux);
            }
            else
            {
                _daoInstOrig.insertarEmisor(emiAux);
            }
            MessageBox.Show("Se insertó emisor con éxito!");
            this.Dispose();
        }
    }
}
