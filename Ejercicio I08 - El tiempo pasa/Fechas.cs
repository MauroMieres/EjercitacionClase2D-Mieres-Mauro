using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I08___El_tiempo_pasa
{
    internal class Fechas
    {
        public static int CalcularDiasVividos(int anio,int mes,int dia) 
        {
            DateTime fechaInicial = new DateTime(anio, mes, dia);
            DateTime fechaActual = DateTime.Now;
            int diasVividos = fechaActual.Subtract(fechaInicial).Days;
            return diasVividos;
        }
    }
}
