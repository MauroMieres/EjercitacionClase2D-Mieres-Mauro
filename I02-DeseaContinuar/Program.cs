using System;

/*
 * Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.*/

namespace I02_DeseaContinuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            int numero;
            int suma = 0;
            do
            {
                Console.Write("Ingrese un entero: ");
                string numeroIngresado = Console.ReadLine();    
                while(!int.TryParse(numeroIngresado,out numero))
                {
                    Console.Write("Ingrese un numero valido: ");
                    numeroIngresado = Console.ReadLine();
                }
                suma += numero;
                Console.WriteLine($"Suma: {suma}");

                Console.Write("Quiere ingresar otro numero? S/N: ");
                respuesta = Console.ReadLine(); 
            } while (Validador.ValidarRespuesta(respuesta));

            Console.ReadKey();
        }
    }
}
