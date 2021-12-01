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
        private int m, mx, my;
        public frmRegistroEmisor()
        {
            InitializeComponent();

            Program.acccionGlobal.tablaReferenciada = "Emisores";
            emiAux = new GestionInstrumentosOriginadoresWS.emisor();

        }
        public frmRegistroEmisor(GestionInstrumentosOriginadoresWS.emisor emi)
        {
            InitializeComponent();
            Program.acccionGlobal.tablaReferenciada = "Emisores";
            lblRegistroEmisor.Text = "Modificar Emisor";
            boxCodigoEmisor.Texts = emi.codigoEmisor.ToString();
            boxNombreEmisor.Texts = emi.nombre;
            emiAux = new GestionInstrumentosOriginadoresWS.emisor();
            emiAux.idEmisor = emi.idEmisor;
        }
        public frmRegistroEmisor(GestionInstrumentosOriginadoresWS.emisor emi,int i)
        {
            InitializeComponent();
            Program.acccionGlobal.tablaReferenciada = "Emisores";
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
                if (_daoInstOrig.modificarEmisor(emiAux) > 0)
                {
                    Program.acccionGlobal.fecha = DateTime.Now.ToString("yyyy-MM-dd");
                    Program.acccionGlobal.hora = DateTime.Now.ToString("HH:mm:ss");
                    Program.acccionGlobal.idObjeto = emiAux.idEmisor;
                    Program.acccionGlobal.tipoAccion = "Modificar";
                    Program._daoAcciones.insertarAccion(Program.acccionGlobal);
                }
            }
            else
            {
                int a = _daoInstOrig.insertarEmisor(emiAux);
                if ( a> 0)
                {
                    Program.acccionGlobal.fecha = DateTime.Now.ToString("yyyy-MM-dd");
                    Program.acccionGlobal.hora = DateTime.Now.ToString("HH:mm:ss");
                    Program.acccionGlobal.idObjeto = a;
                    Program.acccionGlobal.tipoAccion = "Insertar";
                    Program._daoAcciones.insertarAccion(Program.acccionGlobal);
                }
            }
            MessageBox.Show("Se insertó emisor con éxito!");
            this.Dispose();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        } 
    }
}
