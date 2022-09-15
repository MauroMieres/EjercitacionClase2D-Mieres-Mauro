using System;

namespace Ejemplo___Aula
{
    public class Aula
    {
        public string comision;
        public Materia materia;
        public Profesor docente;
        public Alumno[] alumnos;

        private Aula(string comision, Materia materia, Profesor docente)
        {
            this.comision = comision;
            this.materia = materia;
            this.docente = docente;
        }

        public Aula(string comision, Materia materia, Profesor docente, int capacidad) : this(comision, materia, docente)
        {
            this.alumnos = new Alumno[capacidad];
        }

        public Aula(string comision, Materia materia, Profesor docente, Alumno[] alumnos) : this(comision, materia, docente)
        {
            this.alumnos = alumnos;
        } 

        public void AgregarAlumno(Alumno alumno)
        {

        }
    }
}