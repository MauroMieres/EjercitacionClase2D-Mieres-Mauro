using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSobrecargas
{
    public class Sumador
    {
        private int cantidadSumas;
        
        public Sumador(int cantidadSumas) 
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() :this(0)
        {

        }

        public long Sumar(long a,long b) 
        {
            cantidadSumas++;
            return a+ b;
        }

        public string Sumar(string a, string b)
        {
            cantidadSumas++;
            return a+b;
        }

        //Generar una conversión explícita que retorne cantidadSumas. 
        public static explicit operator int(Sumador s) 
        {
            return s.cantidadSumas;
        }

        //Sobrecargar el operador + (suma) con dos operadores de tipo
        //Sumador. El resultado será un long correspondiente al
        //resultado de la suma del atributo cantidadSumas de cada
        //argumento.

        public static long operator +(Sumador a, Sumador b) 
        {
            return a.cantidadSumas + b.cantidadSumas;
        }

        //Sobrecargar el operador | (pipe) con dos operadores de tipo
        //Sumador. Deberá retornar true si ambos sumadores tienen igual
        //valor en el atributo cantidadSumas.

        public static bool operator |(Sumador a, Sumador b)
        {
            if (a.cantidadSumas == b.cantidadSumas)
                return true;
            return false;
        }

    }
}
