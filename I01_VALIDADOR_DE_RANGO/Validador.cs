using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01_VALIDADOR_DE_RANGO
{
    internal class Validador
    {
        public static bool ValidarEntero(string numeroIngresado, int minimo, int maximo)
        {
            if (Validador.esNumerico(numeroIngresado))
            {
                int numero = int.Parse(numeroIngresado);
                if (ValidarRangoEntero(numero, minimo, maximo))
                    return true;
            }
            return false;
        }

        public static bool ValidarRangoEntero(int numero, int minimo, int maximo)
        {
            if (numero > minimo && numero < maximo)
                return true;
            return false;
        }

        private static bool esNumerico(string numeroIngresado)
        {
            return (int.TryParse(numeroIngresado, out int numero));
        }
    }
}
