using System;
/*Consigna
Un centro numérico es un número que separa una lista de números enteros (comenzando en 1)
en dos grupos de números, cuyas sumas son iguales.

El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y 
(7; 8) cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista 
(1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.

Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número 
que el usuario ingrese por consola.*/
namespace I05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero entero positivo: ");
            int numero;
            while(int.TryParse(Console.ReadLine(),out numero)) 
            {
                for(int centro = 1; centro < numero; centro++) 
                {
                    int sumaAntes = 0;
                    for (int i = 0; i < centro; i++) 
                    {
                        sumaAntes += i;
                    }

                    int sumaDespues = 0;
                    for (int i = centro+1; i <= sumaAntes; i++)
                    {
                        if((sumaAntes == sumaDespues) || (sumaDespues > sumaAntes))
                        {
                            break;
                        }
                        sumaDespues += i;
                    }

                    if(sumaAntes == sumaDespues) 
                    {
                        Console.WriteLine($"Es un centro numerico: {centro}");
                    }

                }
            }
            Console.WriteLine("No es un numero valido");
            Console.ReadKey();
        }
    }
}
