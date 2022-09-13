using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conductores_V2;

namespace Conductores_V2
{
    public class Empresa
    {
        //la empresa tiene x cantidad de conductores
        Conductor[] conductores;

        //constructor por defecto con 3 conductores
        public Empresa()
        {
            conductores = new Conductor[3];
        }

        //Este constructor lo uso cuando le paso datos
        public Empresa(Conductor[] conductores)
        {
            this.conductores = conductores;
        }

        public static float CalcularKmSemanales(Conductor conductor) 
        {
            float kmTotales = 0;

            for (int i = 0; i < conductor.kmRecorridos.Length ;i++)
            {
                    kmTotales += conductor.kmRecorridos[i];   
            }
            return kmTotales;
        }

        public static Conductor ConductorMasKmSemanales(Conductor[] conductores)
        {
            float kmSemanalesConductor;
            float masKmRecorridos = 0;
            Conductor conductorAuxiliar = new Conductor();
            conductorAuxiliar = null;

            for (int i = 0; i < conductores.Length; i++)
            {
                kmSemanalesConductor = CalcularKmSemanales(conductores[i]);
                if (kmSemanalesConductor > masKmRecorridos)
                {
                    masKmRecorridos = kmSemanalesConductor;
                    conductorAuxiliar = conductores[i];
                }
            }
            return conductorAuxiliar;
        }

        public static Conductor ConductorMasKmDia(Conductor[] conductores, int dia)
        {
            float kmDiaConductor;
            float masKmRecorridos = 0;
            Conductor conductorMasKmRecorridos = new Conductor();
            conductorMasKmRecorridos = null;

            for (int i = 0; i < conductores.Length; i++)
            {
                kmDiaConductor = conductores[i].kmRecorridos[dia];
                if (kmDiaConductor > masKmRecorridos)
                {
                    masKmRecorridos = kmDiaConductor;
                    conductorMasKmRecorridos = (conductores[i]);
                }
            }
            return conductorMasKmRecorridos;
        }

        public static void MostrarCondcutor(Conductor conductor)
        {
            float kmRecorridos = CalcularKmSemanales(conductor);
            Console.WriteLine($"Conductor: {conductor.nombreConductor}, kms. recorridos: {kmRecorridos}");
        }

        private static void MostrarCondcutor(Conductor conductor,int dia)
        {
            Console.WriteLine($"Conductor: {conductor.nombreConductor}, kms. recorridos: {conductor.kmRecorridos[dia]}");
        }
    }
}
