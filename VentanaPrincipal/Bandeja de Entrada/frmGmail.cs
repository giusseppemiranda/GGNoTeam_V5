using GGNoTeam_V5.Recursos.UserControls;
using System.Drawing;
using System.Windows.Forms;
using GGNoTeam_V5.Recursos.sendMail;
using AE.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using SautinSoft;
using System.Text.RegularExpressions;

namespace GGNoTeam_V5.VentanaPrincipal.Bandeja_de_Entrada
{
    public partial class frmGmail : Form
    {
        private frmPrincipal ventanaPadre = null;
        private int cantidadMensajes = -1;
        private int posicionMensajes = 0;
        public frmGmail(frmPrincipal ventana)
        {
            InitializeComponent();
            this.Cursor = Cursors.WaitCursor;
            ventanaPadre = ventana;
            ventanaPadre.eventoCambiarTema += new frmPrincipal.delegadoCambiarTema(cambiarTema);            
            btnBefore.Enabled = false;
            btnNext.Enabled = false;
            Gmail.conectar();
            cantidadMensajes = Gmail.cantidadMensajes();
            posicionMensajes = cantidadMensajes - 1;
            if(cantidadMensajes != 0)
            {
                mostrarMensaje(Gmail.verMensaje(posicionMensajes));
                if(cantidadMensajes > 1)
                {
                    btnNext.Enabled = true;
                }
            }
            cambiarTema();
            this.Cursor = Cursors.Default;
        }

        private void mostrarMensaje(MailMessage msg)
        {
            string pagina = (posicionMensajes + 1).ToString() + " / " + (cantidadMensajes).ToString();
            lblNumeroMensaje.Text = pagina; 
            msgFrom.Text = msg.From.ToString();
            msgAsunto.Text = msg.Subject;
            msgDate.Text = msg.Date.ToString("dd - MM - yyyy");
            obtenerBody(msg);
        }

        private void obtenerBody(MailMessage msg)
        {/*
            HtmlToRtf h = new SautinSoft.HtmlToRtf();

            h.PageStyle.PageNumbers.Format = "Página {page} de {numpages}";
            h.PageStyle.PageNumbers.AlignH = SautinSoft.HtmlToRtf.eAlign.Center;
            h.PageStyle.PageNumbers.AlignV = SautinSoft.HtmlToRtf.eAlign.Bottom;

            if (h.OpenHtml(msg.Body))
            {
                richTextBox1.Rtf = h.ToRtf();
            };
           */

            richTextBox1.Text = msg.Body;
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
            btnNext.IconColor = Color.WhiteSmoke;
            btnBefore.IconColor = Color.WhiteSmoke;
            pintarLabelOscuro(msgAsunto);            
            pintarLabelOscuro(msgDate);
            pintarLabelOscuro(msgFrom);
        }

        private void activarTemaClaro()
        {
            this.BackColor = Global.FrmClaro;
            btnNext.IconColor = Color.Black;
            btnBefore.IconColor = Color.Black;
            pintarLabelClaro(msgAsunto);            
            pintarLabelClaro(msgDate);
            pintarLabelClaro(msgFrom);
        }

        private void pintarLabelClaro(Label lbl)
        {
            lbl.BackColor = Global.FrmClaro_2;
            lbl.ForeColor = Color.DimGray;
        }

        private void pintarLabelOscuro(Label lbl)
        {
            lbl.BackColor = Global.FrmOscuro_2;
            lbl.ForeColor = Color.WhiteSmoke;
        }

        

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            posicionMensajes--;
            btnBefore.Enabled = true;
            if(posicionMensajes == 0)
            {                
                btnNext.Enabled = false;
            }
            mostrarMensaje(Gmail.verMensaje(posicionMensajes));
        }

        private void btnBefore_Click(object sender, System.EventArgs e)
        {
            posicionMensajes++;
            btnNext.Enabled = true;
            if(posicionMensajes == cantidadMensajes - 1)
            {
                btnBefore.Enabled = false;
            }
            mostrarMensaje(Gmail.verMensaje(posicionMensajes));
        }
    }
}
