using System;
using Biblioteca;

namespace Ejercicio_I04___Invento_argentino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoTintaAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boligrafoTintaRoja = new Boligrafo(ConsoleColor.Red, 50);

            Console.WriteLine($"boligrafoTintaRoja antes de recargar {boligrafoTintaRoja.GetTinta()}");
            boligrafoTintaRoja.Recargar();
            Console.WriteLine($"boligrafoTintaRoja despues de recargar {boligrafoTintaRoja.GetTinta()}");
            boligrafoTintaRoja.Pintar(55, out string dibujo);
            Console.WriteLine($"boligrafoTintaRoja despues de pintar {boligrafoTintaRoja.GetTinta()}");
            boligrafoTintaRoja.Recargar();
            Console.WriteLine($"boligrafoTintaRoja despues de recargar {boligrafoTintaRoja.GetTinta()}");
            boligrafoTintaRoja.Pintar(20, out dibujo);

            Console.WriteLine($"boligrafoTintaAzul antes de recargar {boligrafoTintaAzul.GetTinta()}");
            boligrafoTintaAzul.Pintar(25, out dibujo);
            Console.WriteLine($"boligrafoTintaAzul despues de pintar {boligrafoTintaAzul.GetTinta()}");

            Console.ReadLine(); 
        }
    }
}
