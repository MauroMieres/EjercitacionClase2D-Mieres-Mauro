using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I04___La_calculadora
{
    internal class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            if (respuesta == "S")
                return true;
            return false;
        }
    }
}
