using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I03___El_ejemplo_universal
{
    public class Estudiante
    {
        string nombre;
        string apellido;
        string legajo;
        int notaPrimerParcial;
        int notaSegundoParcial;
        Random random;

        public Estudiante(string nombre, string legajo, string apellido, int notaPrimerParcial, int notaSegundoParcial)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
            SetNotaPrimerParcial(notaPrimerParcial);
            SetNotaSegundoParcial(notaSegundoParcial);
        }

        public void SetNotaPrimerParcial(int notaPrimerParcial) 
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }

        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        public float CalcularPromedio() 
        {
            float promedio = ((float)this.notaPrimerParcial + this.notaSegundoParcial) / 2;
            return promedio;
        }

        public int CalcularNotaFinal() 
        {
            if (this.notaPrimerParcial < 4 || this.notaSegundoParcial < 4)
                return -1;
            Random r = new Random();
            int notaFinal = r.Next(6, 10);
            return notaFinal;
        }

        public void Mostrar() 
        {
            StringBuilder datosEstudiante = new StringBuilder();
            string notaFinal = CalcularNotaFinal().ToString();

            if (notaFinal == "-1")
                notaFinal = "Alumno desaprobado";
   
            datosEstudiante.Append($"Nombre: {this.nombre}, Apellido: {this.apellido}, Legajo {this.legajo}" +
                $", NPP: {this.notaPrimerParcial}, NSP: {this.notaSegundoParcial}, Promedio: {this.CalcularPromedio()}" +
                $", Nota final: {notaFinal}");

            Console.WriteLine(datosEstudiante);
        }
    }
}
