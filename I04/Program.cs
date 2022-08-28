using System;

/*
 * Consigna
Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos 
(excluido el mismo) que son divisores del número.

El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

Escribir una aplicación que encuentre los 4 primeros números perfectos.*/

namespace I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorNumerosPerfectos = 0;
            int numero = 1;
            while(contadorNumerosPerfectos < 4) 
            {
                if (determinarNumeroPerfecto(numero)) 
                {
                    Console.WriteLine($"Se encontro numero perfecto: {numero}");
                    contadorNumerosPerfectos++;
                }
                numero++;
            }
            Console.ReadKey();
        }

        static bool determinarNumeroPerfecto(int numero) 
        {
            int suma = 0;
            int i = 1;
            while (i < numero) 
            {
            if(numero % i == 0) 
                {
                    suma += i;
                    if (suma > numero)
                        return false;    
                }
                i++;
            }
            return (suma == numero);//retorna true cuando suma es igual a numero
        }
    }
}
