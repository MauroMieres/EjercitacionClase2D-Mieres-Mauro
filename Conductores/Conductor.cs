using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conductores
{
    public class Conductor
    {
        public string nombre;
        public float[] KmRecorridosPorDia;

        public Conductor()
        {
            KmRecorridosPorDia = new float[7];
        }

        public Conductor(string nombre, float[] kmRecorridosPorDia) : this()
        {
            this.nombre = nombre;
            KmRecorridosPorDia = kmRecorridosPorDia;
        }

        public float CalcularKmRecorridos()
        {
            float kmTotales = 0;

            for (int i = 0; i < this.KmRecorridosPorDia.Length; i++)
            {
                kmTotales += this.KmRecorridosPorDia[i];
            }
            return kmTotales;
        }

        public static void ConductorMasKmSemanales(Conductor[]conductores) 
        {
            float kmSemanalesConductor;
            float masKmRecorridos = 0;
            Conductor conductorMasKmRecorridos = new Conductor();
          
            for(int i = 0; i < conductores.Length; i++) 
            {
                kmSemanalesConductor = conductores[i].CalcularKmRecorridos();
                if(kmSemanalesConductor > masKmRecorridos) 
                {
                    masKmRecorridos=kmSemanalesConductor;
                    conductorMasKmRecorridos = (conductores[i]);
                }
            }
            Console.WriteLine("Mas kilometros recorridos:");
            conductorMasKmRecorridos.MostrarCondcutor();
        }

        public static void ConductorMasKmDia(Conductor[] conductores,int dia)
        {
            float kmDiaConductor;
            float masKmRecorridos = 0;
            Conductor conductorMasKmRecorridos = new Conductor();

            for (int i = 0; i < conductores.Length; i++)
            {
                kmDiaConductor = conductores[i].KmRecorridosPorDia[dia];
                if (kmDiaConductor > masKmRecorridos)
                {
                    masKmRecorridos = kmDiaConductor;
                    conductorMasKmRecorridos = (conductores[i]);
                }
            }
            Console.WriteLine($"Mas kilometros recorridos dia {dia}:");
            conductorMasKmRecorridos.MostrarCondcutor(dia);
        }

        public void MostrarCondcutor()
        {
            float kmRecorridos = CalcularKmRecorridos();
            Console.WriteLine($"Conductor: {this.nombre}, kms. recorridos: {kmRecorridos}");
        }

        private void MostrarCondcutor(int dia)
        {
            Console.WriteLine($"Conductor: {this.nombre}, kms. recorridos: {this.KmRecorridosPorDia[dia]}");
        }
    }
}
