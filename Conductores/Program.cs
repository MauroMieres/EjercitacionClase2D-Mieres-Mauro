using System;
using Conductores;

namespace Conductores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] kmConductor1 = { 1, 2, 1, 7, 1, 1, 1 };
            float[] kmConductor2 = { 3, 3, 3, 3, 3, 3, 3 };
            float[] kmConductor3 = { 1, 3, 5, 5, 1, 5, 1 };

            Conductor[] conductores = new Conductor[3];

            conductores[0] = new Conductor("Mauro", kmConductor1);
            conductores[1] = new Conductor("Lucas", kmConductor2);
            conductores[2] = new Conductor("Ulises", kmConductor3);

            Empresa empresa = new Empresa(conductores);

            Conductor.ConductorMasKmSemanales(conductores);
            Conductor.ConductorMasKmDia(conductores,3);
            Conductor.ConductorMasKmDia(conductores,5);

            Console.ReadKey();
        }
    }
}
