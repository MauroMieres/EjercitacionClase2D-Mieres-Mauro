using System;
using I01_VALIDADOR_DE_RANGO;

/*Consigna
Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

bool Validar(int valor, int min, int max)

valor: dato a validar.
min: mínimo valor incluido.
max: máximo valor incluido.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.*/

namespace I01_VALIDADOR_DE_RANGO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minimo = Int32.MaxValue;
            int maximo = Int32.MinValue;
            int suma = 0;
            float promedio;
            Console.WriteLine("*** Ingrese 10 numeros enteros *** ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}) Ingrese un entero: ");
                string numeroIngresado = Console.ReadLine();
                while (!(Validador.ValidarEntero(numeroIngresado, -100, 100)))
                {
                    Console.Write($"{i}) Ingrese un entero valido: ");
                    numeroIngresado = Console.ReadLine();
                }
                int numero = int.Parse(numeroIngresado);

                if (numero < minimo)
                    minimo = numero;

                if (numero > maximo)
                    maximo = numero;

                suma += numero;
            }
            promedio = (float)suma / 10;
            Console.WriteLine($"Minimo valor ingresado {minimo}");
            Console.WriteLine($"Maximo valor ingresado {maximo}");
            Console.WriteLine($"Promedio: {promedio}");
            Console.ReadKey();
        }
    }
}
