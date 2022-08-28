using System;

namespace I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //atajos para ordenar codigo ctrl K  ctrl D
            //Ingresar un número y mostrar el cuadrado y el cubo del mismo.
            //Se debe validar que el número sea mayor que cero, caso contrario,
            //mostrar el mensaje: "ERROR. ¡Reingresar número!".
            Console.Write("Ingrese un numero: ");
            string numeroIngresado = Console.ReadLine();
            bool validarNumeroIngresado = int.TryParse(numeroIngresado, out int numero);
            if (validarNumeroIngresado)
            {
                if (numero != 0)
                {
                    Console.WriteLine($"{numero} al cuadrado: {Math.Pow(numero, 2)}");
                    Console.WriteLine($"{numero} al cubo: {Math.Pow(numero, 3)}");
                }
                else
                {
                    Console.WriteLine("El numero ingresado es igual o menor a cero!");
                }
            }
            Console.ReadKey();
        }
    }
}
