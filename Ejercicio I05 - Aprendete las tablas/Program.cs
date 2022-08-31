using System;
using System.Text;

/*Consigna
Crear una aplicación de consola que permita al usuario ingresar un número entero.

Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.

Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.

Mostrar en la consola el resultado.*/

namespace Ejercicio_I05___Aprendete_las_tablas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Ingrese un numero entero: ");
            string numeroIngresado = Console.ReadLine();
            while (!int.TryParse(numeroIngresado, out numero))
            {
                Console.Write("Ingrese un numero entero valido: ");
                numeroIngresado = Console.ReadLine();
            }

            string tablasResultado = CalcularTablasMultiplicar(numero);
            Console.WriteLine($"Tabla de multiplicar del numero {numero}");
            Console.WriteLine(tablasResultado);

            Console.ReadKey();
        }

        public static string CalcularTablasMultiplicar(int numero)
        {
            StringBuilder myStringBuilder = new StringBuilder();
            for (int i = 1; i <= 9; i++)
            {
                string tabla = ($"{numero} x {i} = {numero * i}");
                myStringBuilder.AppendLine(tabla);
            }
            return (myStringBuilder.ToString());
        }
    }
}
