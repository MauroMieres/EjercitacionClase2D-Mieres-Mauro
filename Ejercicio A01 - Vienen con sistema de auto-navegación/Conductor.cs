using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_A01___Vienen_con_sistema_de_auto_navegación
{
    public class Conductor
    {
        public string nombre;
        public float[]KmRecorridosPorDia;

        private Conductor() 
        {
            KmRecorridosPorDia = new float[7];//7 dias de la semana
        }

        public Conductor(string nombre, float[] kmRecorridosPorDia):this()
        {
            this.nombre = nombre;
            KmRecorridosPorDia = kmRecorridosPorDia;
        }
    }
}
