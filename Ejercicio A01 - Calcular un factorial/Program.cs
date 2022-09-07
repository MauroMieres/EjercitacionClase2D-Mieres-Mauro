using System;

/*El factorial de un número es una operación que consiste en multiplicar un numero “n” por todos los números enteros positivos que estén debajo de él, por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.

En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.*/

namespace Ejercicio_A01___Calcular_un_factorial
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("Ingrese un entero mayor a cero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"{numero}! es {CalcularFactorial(numero)}");
            Console.ReadKey();

            static long CalcularFactorial(int numero) 
            {
                long factorialNumero = 1;
                while(numero > 0) 
                {
                    factorialNumero = factorialNumero * numero--;
                }
                return factorialNumero;
            }  
        }
    }
}
