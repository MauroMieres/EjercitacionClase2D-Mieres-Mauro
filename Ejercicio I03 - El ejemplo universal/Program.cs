using System;

namespace Ejercicio_I03___El_ejemplo_universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Mauro","25242","Mieres",9,10);
            Estudiante estudiante2 = new Estudiante("Lucas","44556","Avalos",8,5);
            Estudiante estudiante3 = new Estudiante("Gladys","24034","Knofler",3,2);

            estudiante1.Mostrar();
            estudiante2.Mostrar();
            estudiante3.Mostrar();

            Console.ReadKey();
        }
    }
}
