using System;

namespace Ejercicio_A01___Vienen_con_sistema_de_auto_navegación
{
    public class Program
    {
        static void Main(string[] args)
        {
            float[] kmConductor1 = { 23, 47, 87, 23, 56, 6, 20 };
            float[] kmConductor2 = { 50, 33, 44, 12, 67, 5, 30 };
            float[] kmConductor3 = { 11, 22, 33, 66, 32, 11, 40 };

            Conductor[] conductores = new Conductor[3];

            conductores[0] = new Conductor("Mauro", kmConductor1);
            conductores[1] = new Conductor("Lucas", kmConductor2);
            conductores[2] = new Conductor("Ulises", kmConductor3);

            for(int i = 0; i < conductores.Length; i++) 
            {
                Console.WriteLine($"Conductor: {conductores[i].nombre}");  
                for(int j=0;j<7;j++)
                    Console.WriteLine(conductores[i].KmRecorridosPorDia[j]);
            }


            Empresa empresa = new Empresa(conductores);
 

            Console.ReadKey();
        }
    }
}
