using System;
using BibliotecaSobrecargas;

namespace Ejercicio_I01___Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;

            Sumador sumador1 = new Sumador(3);
            Sumador sumador2 = new Sumador(3);

            Console.WriteLine(sumador1.Sumar(21, 22));
            Console.WriteLine(sumador2.Sumar("Hello ", "World"));

            //Generar una conversión explícita que retorne cantidadSumas. (ver metodo en biblioteca)
            a = (int)sumador1;
            b = (int)sumador2;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(sumador1 + sumador2);
            Console.WriteLine(sumador1 | sumador2);

            Console.ReadKey();
        }
    }
}
