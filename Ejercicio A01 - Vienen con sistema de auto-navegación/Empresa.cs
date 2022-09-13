using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_A01___Vienen_con_sistema_de_auto_navegación
{
    public class Empresa
    {
        Conductor[] conductores;

        private Empresa() 
        {
            conductores = new Conductor[3];
        }

        public Empresa(Conductor[] conductores):this()
        {
            this.conductores = conductores;
        }

        public float ConductorKmRecorridos(Conductor conductor) 
        {
            float acumulador = 0;

            for(int i =0; i < conductor.KmRecorridosPorDia.Length; i++) 
            {
                acumulador += conductor.KmRecorridosPorDia[i];
            }
            return acumulador;
        }

        public Conductor ConductorMasKmPorSemana() 
        {
            float kmSemanalesConductor;
            float masKmRecorridos = 0;
            foreach(Conductor conductor in conductores) 
            {
                kmSemanalesConductor = ConductorKmPorSemana(conductor);
                if(kmSemanalesConductor>masKmRecorridos) 
                {
                    masKmRecorridos = kmSemanalesConductor;
                }
            }
            foreach (Conductor conductor in conductores)
            {
                if (masKmRecorridos == ConductorKmPorSemana(conductor))
                    return conductor;
            }
            return null;
        }

        public void MostrarCondcutor()
        {
            StringBuilder datosCondcutor = new StringBuilder();
            float kmRecorridos = ConductorMasKmPorSemana();


            datosCondcutor.Append($"Nombre: {this.nombre},

            Console.WriteLine(datosEstudiante);
        }
    }
}
