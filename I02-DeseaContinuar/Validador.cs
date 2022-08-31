using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02_DeseaContinuar
{
    internal class Validador
    {
        public static bool ValidarRespuesta(string respuesta) 
        {
            if(respuesta == "S")
                return true;
            return false;   
        }
    }
}
