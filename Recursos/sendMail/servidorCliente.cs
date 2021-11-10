using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGNoTeam_V5.Recursos.sendMail
{
    public class servidorCliente
    {
        System.Net.Mail.SmtpClient cliente;
        public servidorCliente()
        {
            cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential(credenciales.AddressOUT, credenciales.PasswordOUT);
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";            
        }

        public void sendMessage(System.Net.Mail.MailMessage msg)
        {
            try
            {
                cliente.Send(msg);
            }
            catch (Exception)
            {
                //MessageBox.Show("Error al enviar");
            }
        }
    }
}
