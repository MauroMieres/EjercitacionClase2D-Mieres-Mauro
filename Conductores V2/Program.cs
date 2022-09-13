using System;

namespace Conductores_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] kmConductor1 = { 1, 2, 1, 7, 1, 1, 1 };
            float[] kmConductor2 = { 3, 3, 3, 3, 3, 3, 3 };
            float[] kmConductor3 = { 1, 3, 5, 5, 1, 5, 1 };

            //creo el array de conductores
            Conductor[] conductores = new Conductor[3];

            conductores[0] = new Conductor("Mauro", kmConductor1);
            conductores[1] = new Conductor("Lucas", kmConductor2);
            conductores[2] = new Conductor("Ulises", kmConductor3);

            //creo la empresa, dentro se crean los 3 conductores
            Empresa empresa = new Empresa(conductores);

            Console.WriteLine("Conductor mas kms recorridos en la semana: ");
            Empresa.MostrarCondcutor(Empresa.ConductorMasKmSemanales(conductores));
            Console.WriteLine("Conductor mas kms recorridos dia 3: ");
            Empresa.MostrarCondcutor(Empresa.ConductorMasKmDia(conductores, 3));
            Console.WriteLine("Conductor mas kms recorridos dia 5: ");
            Empresa.MostrarCondcutor(Empresa.ConductorMasKmDia(conductores, 5));

            Console.ReadKey();
        }
    }
}
