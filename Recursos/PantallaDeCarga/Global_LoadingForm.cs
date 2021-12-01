using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGNoTeam_V5.Recursos.PantallaDeCarga
{
    public static class Global_LoadingForm
    {
        public static LoadingForm formulario;
        public static void Show()
        {            
            formulario = new LoadingForm();
            formulario.Show();                        
        }

        public static void Dispose()
        {
            formulario.Dispose();
        }


    }
}
