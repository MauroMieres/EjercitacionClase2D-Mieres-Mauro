using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conductores_V2
{
    public class Conductor
    {
        public string nombreConductor;
        public float[] kmRecorridos;

        public Conductor()
        {
            kmRecorridos = new float[7];//creo 7 espacios para los 7 dias de la semana
        }

        public Conductor(string nombre, float[] kmRecorridosPorDia):this()
        {
            this.nombreConductor = nombre;
            kmRecorridos = kmRecorridosPorDia;
        }

        public static float CalcularKmSemanales(Conductor conductor)
        {
            float kmTotales = 0;

            for (int i = 0; i < conductor.kmRecorridos.Length; i++)
            {
                for (int j = 0; j < conductor.kmRecorridos.Length; j++)
                {
                    Console.WriteLine(j);
                    //kmTotales += conductor.kmRecorridos[j];
                }
            }
            return kmTotales;
        }
    }
}
