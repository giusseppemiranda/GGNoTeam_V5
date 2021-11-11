using GGNoTeam_V5.Recursos.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.GestionInstrumentosOriginadores
{
    public partial class frmGestionOriginadoresInstrumentos : Form
    {
        private frmPrincipal ventanaPadre = null;


        public frmGestionOriginadoresInstrumentos(frmPrincipal ventana)
        {
            InitializeComponent();
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);
            cambiarTema();
        }

        public void cambiarTema()
        {
            if (Global.TemaOscuro)
            {
                activarTemaClaro();
            }
            else
            {
                activarTemaOscuro();
            }
        }

        private void activarTemaOscuro()
        {
            this.BackColor = Global.FrmOscuro;
            Global.pintarTxtBoxOscuro(ref txtboxbusqueda);
            Global.pintarBtnOscuro(ref btnBuscar);
        }

        private void activarTemaClaro()
        {
            this.BackColor = Global.FrmClaro;
            Global.pintarTxtBoxClaro(ref txtboxbusqueda);
            Global.pintarBtnClaro(ref btnBuscar);
        }

        private void cargarComboBoxEleccion()
        {
            comboTipo.Items.Add("Emisor");
            comboTipo.Items.Add("Instrumento");
            comboTipo.Items.Add("Originador");
        }
    }
}
