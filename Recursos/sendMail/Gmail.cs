using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AE.Net.Mail;

namespace GGNoTeam_V5.Recursos.sendMail
{
    static class Gmail
    {
        static ImapClient IC;

        public static void conectar()
        {
            IC = new ImapClient("imap.gmail.com", credenciales.AddressOUT, credenciales.PasswordOUT, AuthMethods.Login, 993, true);
        }

        public static MailMessage verMensaje(int i)
        {
            IC.SelectMailbox("INBOX");

            MailMessage Email = IC.GetMessage(i);
            //Console.WriteLine(Email.Subject);
            
            return Email;
        }

        public static int cantidadMensajes()
        {
            int cantidad = IC.GetMessageCount();

            return cantidad;
        }
    }
}
