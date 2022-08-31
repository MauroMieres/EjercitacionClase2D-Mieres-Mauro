using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I03___Conversor_binario
{
    internal class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero) 
        {
            long binario = 0;

            const int DIVISOR = 2;
            long digito = 0;

            for (int i = numeroEntero % DIVISOR, j = 0; numeroEntero > 0; numeroEntero /= DIVISOR, i = numeroEntero % DIVISOR, j++)
            {
                digito = i % DIVISOR;
                binario += digito * (long)Math.Pow(10, j);
            }
            return binario.ToString(); ;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int numero = 0;
            int digito = 0;
            const int DIVISOR = 10;

            for (long i = numeroEntero, j = 0; i > 0; i /= DIVISOR, j++)
            {
                digito = (int)i % DIVISOR;
                if (digito != 1 && digito != 0)
                {
                    return -1;
                }
                numero += digito * (int)Math.Pow(2, j);
            }
            return numero;
        }
    }
}
