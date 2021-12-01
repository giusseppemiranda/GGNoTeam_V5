using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5.Recursos.Validaciones
{
    static class ValidarTextBox
    {

        public static int correo(GGNoTeam_V5.Recursos.UserControls.GGTextBox box, string Titulo, int cantMaxima)
        {
            string msgCasoVacio = Titulo + " no debe encontrarse vacía. Intente nuevamente.";
            string msgCasoCantidadMaxima = Titulo + " no puede exceder el tamaño de " + cantMaxima + " caracteres.";
            
            return correo(box, msgCasoVacio, msgCasoCantidadMaxima, cantMaxima);
        }

        public static int correo(GGNoTeam_V5.Recursos.UserControls.GGTextBox box, string msgCasoVacio, string msgCasoCantidadMaxima, int cantMaxima)
        {
            if (cadenaVacia(box, msgCasoVacio) != 0) return 1;
            if (cadenaGrande(box, msgCasoCantidadMaxima, cantMaxima) != 0) return 2;            
            if (Regex.IsMatch(box.Texts.ToLowerInvariant(), "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$")) return 0;
            else 
            {
                MessageBox.Show("El correo ingresado no concuerda con el formato de correo.\nFormato válido:\n\tusuariocorreo@gmail.com\n\tusuariocorreo@outlook.com");
                return -1; 
            }
        }
        /**
         * (VALOR RETORNO) :   MOTIVO
         *        
         *   (0) :   La cadena pasa la validación de texto
         *   (1) :   La cadena se encuentra vacía
         *   (2) :   La cadena inicia con caracteres Inválidos ( Espacios en blanco)
         *   (3) :
         *                     
         */
        public static int NoNumerico(GGNoTeam_V5.Recursos.UserControls.GGTextBox box, string Titulo, int cantMaxima)
        {
            string msgCasoVacio = Titulo + " no debe encontrarse vacía. Intente nuevamente.";
            string msgCasoInvalido = Titulo + " tiene error. No debe contener caracteres especiales y tampoco iniciar con espacios en blancos.";
            string msgCasoContieneNumeros = Titulo + " no debe contener números. Intente nuevamente.";
            string msgCasoCantidadMaxima = Titulo + " no puede exceder el tamaño de " + cantMaxima + " caracteres.";

            return NoNumerico(box, msgCasoVacio, msgCasoInvalido, msgCasoContieneNumeros, msgCasoCantidadMaxima, cantMaxima);
        }

        public static int NoNumerico(GGNoTeam_V5.Recursos.UserControls.GGTextBox box, string msgCasoVacio, string msgCasoInvalido, string msgCasoContieneNumeros, string msgCasoCantidadMaxima, int cantidad)
        {
            string patron = "";

            string texto = box.Texts.Trim();
            box.Texts = texto;

            //CASO 1
            if (cadenaVacia(box, msgCasoVacio) != 0) return 1;            

            //CASO 3
            patron = "[0-9]+";
            if (Regex.IsMatch(box.Texts, patron))
            {
                MessageBox.Show(msgCasoContieneNumeros);
                return 3;
            }


            //CASO 4
            if (cadenaGrande(box, msgCasoCantidadMaxima, cantidad) != 0) return 4;            


            return 0;
        }


        public static int alfaNumerico(GGNoTeam_V5.Recursos.UserControls.GGTextBox box, string Titulo, int cantMaxima)
        {
            string msgCasoVacio = Titulo + " no debe encontrarse vacía. Intente nuevamente.";
            string msgCasoInvalido = Titulo + " tiene error. No debe contener caracteres especiales y tampoco iniciar con espacios en blancos.";
            string msgCasoContieneNumeros = Titulo + " no debe contener números. Intente nuevamente.";
            string msgCasoCantidadMaxima = Titulo + " no puede exceder el tamaño de " + cantMaxima + " caracteres.";

            return alfaNumerico(box, msgCasoVacio, msgCasoInvalido, msgCasoContieneNumeros, msgCasoCantidadMaxima, cantMaxima);
        }

        public static int alfaNumerico(GGNoTeam_V5.Recursos.UserControls.GGTextBox box, string msgCasoVacio, string msgCasoInvalido, string msgCasoContieneNumeros, string msgCasoCantidadMaxima, int cantidad)
        {
            string patron = "";

            string texto = box.Texts.Trim();
            box.Texts = texto;

            //CASO 1
            if (cadenaVacia(box, msgCasoVacio) != 0) return 1;


            //CASO 4
            if (cadenaGrande(box, msgCasoCantidadMaxima, cantidad) != 0) return 4;

            return 0;
        }

        public static int inicioNormal(GGNoTeam_V5.Recursos.UserControls.GGTextBox box, string Titulo)
        {
            string patron;
            patron = "^[a-zA-Z]+(\\s[a-zA-Z])*$";
            if (!Regex.IsMatch(box.Texts, patron))
            {
                MessageBox.Show(Titulo+" no puede contener caracteres en blanco al inicio y tampoco iniciar con números.");
                return 2;
            }
            return 0;
        }
        

        public static int PuntoFlotante(GGNoTeam_V5.Recursos.UserControls.GGTextBox box, string Titulo)
        {
            string msgCasoVacio = Titulo + " no debe encontrarse vacía. Intente nuevamente.";
            string msgCasoInvalido = Titulo + " tiene error. No debe contener caracteres especiales, tampoco iniciar con espacios en blancos ni debe contener letras.";

            return PuntoFlotante(box, msgCasoVacio, msgCasoInvalido);
        }

        public static int PuntoFlotante(GGNoTeam_V5.Recursos.UserControls.GGTextBox box, string msgCasoVacio, string msgCasoInvalido)
        {
            string patron;

            if (cadenaVacia(box, msgCasoVacio) != 0) return 1;


            patron = "^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$";
            if (!Regex.IsMatch(box.Texts, patron)){
                MessageBox.Show(msgCasoInvalido);
                return 2;
            } else
            {
                return 0;
            }
        }


        /**
         * (VALOR RETORNO) :   MOTIVO
         *        
         *   (0) :   La cadena pasa la validación de Numero Entero
         *   (1) :   La cadena se encuentra vacía         
         *   (2) :   La cadena no debe contener letras 
         *                     
         */
        public static int NumeroEntero(GGNoTeam_V5.Recursos.UserControls.GGTextBox box, string Titulo, int cantMaxima)
        {
            string msgCasoVacio = Titulo + " no debe encontrarse vacía. Intente nuevamente.";
            string msgCasoContieneLetras = Titulo + " no debe contener letras ni caracteres especiales. Intente nuevamente.";
            string msgCasoCantidadMaxima = Titulo + " no debe exceder de " + cantMaxima + " caracteres.";

            return NumeroEntero(box, msgCasoVacio, msgCasoContieneLetras, msgCasoCantidadMaxima, cantMaxima);
        }

        public static int NumeroEntero(GGNoTeam_V5.Recursos.UserControls.GGTextBox box, string msgCasoVacio, string msgCasoContieneLetras, string msgCasoCantidadMaxima, int cantidadMaxima)
        {
            string patron = "";

            //CASO 1            
            if (cadenaVacia(box, msgCasoVacio) != 0)  return 1;


            if (cadenaGrande(box, msgCasoCantidadMaxima, cantidadMaxima) != 0) return 4;

            //CASO 2
            try
            {
                int dummy = Int32.Parse(box.Texts);
                return 0;
            }
            catch
            {
                MessageBox.Show(msgCasoContieneLetras);
                return 2;
            }

        }

        public static int cadenaGrande(GGNoTeam_V5.Recursos.UserControls.GGTextBox box, string msgCasoCantidadMaxima, int cantidad)
        {
            if (box.Texts.Length > cantidad)
            {
                MessageBox.Show(msgCasoCantidadMaxima);
                return 1;
            }
            return 0;
        }

        //CASO INDIVIDUALES
        public static int cadenaVacia(GGNoTeam_V5.Recursos.UserControls.GGTextBox box, string msgCasoVacio)
        {
            if (box.Texts == string.Empty)
            {
                MessageBox.Show(msgCasoVacio);
                return 1;
            }

            return 0;
        }
    }
}

