using System;

namespace I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 5 números por consola, guardándolos en una variable escalar.
            //Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
  
            bool unNumeroIngresado = false;
            int numMaximo = -1;
            int numMinimo = -1;
            int acumulador = 0;

            for (int i=0; i < 5; i++) 
            {
                Console.Write("Ingrese un numero: ");
                string numeroIngresado = Console.ReadLine();
                bool validarNumero = int.TryParse(numeroIngresado, out int numero);
                if (validarNumero) 
                {
                    if (!unNumeroIngresado) 
                    {
                        numMaximo = numero;
                        numMinimo = numero;
                        unNumeroIngresado = true;
                    }

                    if(numero < numMinimo) 
                    {
                        numMinimo = numero;
                    }

                    if (numero > numMaximo)
                    {
                        numMaximo = numero;
                    }
                    acumulador += numero;
                }
                else 
                {
                    Console.Write("Ingresaste un numero no valido!");
                }
            }
            Console.WriteLine($"El minimo: {numMinimo}");
            Console.WriteLine($"El maximo: {numMaximo}");
            Console.WriteLine($"El promedio: {(float)acumulador/5}");

            Console.ReadKey();
        }
    }
}
