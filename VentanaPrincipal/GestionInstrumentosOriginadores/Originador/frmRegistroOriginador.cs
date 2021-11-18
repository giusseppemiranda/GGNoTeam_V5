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
        public frmRegistroOriginador()
        {
            InitializeComponent();
        }
        public frmRegistroOriginador(GestionInstrumentosOriginadoresWS.originador orig)
        {
            InitializeComponent();

        }
    }
}
