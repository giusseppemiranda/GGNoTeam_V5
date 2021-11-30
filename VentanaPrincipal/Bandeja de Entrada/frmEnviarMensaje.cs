using GGNoTeam_V5.Recursos.sendMail;
using SautinSoft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5.VentanaPrincipal.Bandeja_de_Entrada
{
    public partial class frmEnviarMensaje : Form
    {
        private MailMessage msg;
        private string correoDestinatario;
        private LoginWS.persona emisor;
        public frmEnviarMensaje(LoginWS.persona destinatario, LoginWS.persona emisor)
        {
            InitializeComponent();
            msg = new MailMessage();

            txtBoxDestinatario.Texts = destinatario.nombre + " " + destinatario.apellidos + ":    " + destinatario.correo;
            correoDestinatario = destinatario.correo;

            this.emisor = emisor;

            //this.BackColor = Color.;
        }



        private void btnEnviar_Click(object sender, EventArgs e)
        {
            asignarReplyTo();
            obtenerEmisor();
            obtenerDestinatario();
            obtenerAsunto();
            obtenerBody();
            enviarMensaje();
            this.Dispose();
        }

        private void asignarReplyTo()
        {
            msg.ReplyToList.Add(new MailAddress(emisor.correo));
            msg.ReplyToList.Add(new MailAddress(credenciales.AddressOUT));
        }

        private void enviarMensaje()
        {
            servidorCliente server = new servidorCliente();
            server.sendMessage(msg);

        }

        private void obtenerBody()
        {

            RtfToHtml r = new SautinSoft.RtfToHtml();
            richTextBox1.Text = richTextBox1.Text + "\n\n\n" + pieDeBody();
            string rtf = richTextBox1.Rtf;
            r.ImageStyle.IncludeImageInHtml = true;
            string BODY = r.ConvertString(rtf);
            msg.Body = BODY;
            msg.IsBodyHtml = true;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
        }

        private string pieDeBody()
        {
            string pie = "";

            pie = "Este mensaje ha sido enviado por el administrador " + emisor.nombre + " " + emisor.apellidos + ".\nSi desea contactarse directamente envíe el mensaje al siguiente correo: " + emisor.correo;

            return pie;
        }

        private void obtenerEmisor()
        {
            msg.From = new MailAddress(credenciales.AddressOUT);
        }

        private void obtenerAsunto()
        {
            msg.Subject = txtBoxAsunto.Texts;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
        }

        private void obtenerDestinatario()
        {
            msg.To.Add(correoDestinatario);
        }

        private void agregarAttachmenter(string ruta)
        {
            msg.Attachments.Add(new Attachment(ruta));
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDeleteMessage_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            txtBoxAsunto.Texts = "Asunto";
        }

        private void btnAdjuntarArchivo_Click(object sender, EventArgs e)
        {
            openFiles.InitialDirectory = "C:\\";

            if (openFiles.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string rutaArchivo = openFiles.FileName;
                    agregarAttachmenter(rutaArchivo);
                    richTextBox2.AppendText("\n" + rutaArchivo);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void btnAdjuntarImagen_Click(object sender, EventArgs e)
        {
            openFiles.InitialDirectory = "C:\\";

            openFiles.Filter = "Archivos PNG(*.png)|*.png|Archivos JPG(*.jpg)|*.jpg";

            if (openFiles.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string rutaArchivo = openFiles.FileName;
                    agregarAttachmenter(rutaArchivo);
                    richTextBox2.AppendText("\n" + rutaArchivo);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void txtBoxAsunto_Enter(object sender, EventArgs e)
        {
            if (txtBoxAsunto.Texts == "Asunto")
            {
                txtBoxAsunto.Texts = "";
            };
        }

        private void txtBoxAsunto_Leave(object sender, EventArgs e)
        {
            if (txtBoxAsunto.Texts == "")
            {
                txtBoxAsunto.Texts = "Asunto";
            }
        }
    }
}
