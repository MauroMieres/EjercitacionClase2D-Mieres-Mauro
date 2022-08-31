using System;

/*Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):*/

namespace Ejercicio_I03___Conversor_binario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDecimal = Conversor.ConvertirBinarioADecimal(110010101);
            Console.WriteLine($"Binario a decimal: {numeroDecimal}");
            string numeroBinario = Conversor.ConvertirDecimalABinario(numeroDecimal);
            Console.WriteLine($"Decimal a binario: {numeroBinario}");
            Console.ReadKey();
        }
    }
}
