using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGNoTeam_V5.Recursos.sendMail
{
    public static class credenciales
    {
        static string addressOUT = "AFPIntegraLP2@gmail.com";
        static string passwordOUT = "adminlp2";

        public static string AddressOUT { get => addressOUT; set => addressOUT = value; }
        public static string PasswordOUT { get => passwordOUT; set => passwordOUT = value; }
    }
}
