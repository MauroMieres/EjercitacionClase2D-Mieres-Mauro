using System;
/*Escribir un programa que determine si un año es bisiesto.

Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos,
salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.

Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.*/
namespace I06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un año de inicio: ");
            int anioInicio;
            while(int.TryParse(Console.ReadLine(),out anioInicio))
            {
                Console.Write("Ingrese un año final: ");
                int anioFinal;
                while (int.TryParse(Console.ReadLine(), out anioFinal))
                { 
                    for(int i = anioInicio; i <= anioFinal; i++) 
                    {
                        if (i % 4 == 0)
                        {
                            if (i % 100 == 0)
                            {
                                if (i % 400 == 0)
                                {
                                    Console.WriteLine(i);
                                }
                            }
                            else
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Ingrese un anio valido! ");
            Console.ReadKey();
        }
    }
}
