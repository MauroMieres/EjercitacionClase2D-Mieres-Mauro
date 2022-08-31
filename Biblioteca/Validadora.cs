using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Validadora
    {
        public static bool ValidarEntero(string numeroIngresado, int minimo, int maximo) 
        {
            if(Validadora.EsNumerico(numeroIngresado))
            {
                int numero = int.Parse(numeroIngresado);   
                if(numero > minimo && numero < maximo) 
                {
                    return true;
                }
            }
            return false;
        }
      
        public static bool ValidarEntero(int numero, int maximo)
        {

        }
        public bool ValidarCuil(int cuil) 
        {
            
        }
        public static bool EsNumerico(string numero) 
        {
            int retorno;
            if(int.TryParse(numero,out retorno)) 
            {
                return true; //el return aca funciona como break
            }
            return false;
        }

    }
}
