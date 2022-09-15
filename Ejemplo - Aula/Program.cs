using System;

namespace Ejemplo___Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("German");

            Profesor profesor = new Profesor("Curcio");

            Materia laboII = new Materia("laboratorio II");
            Materia progII = new Materia("programacion II");

            Alumno[] alumnos2D = new Alumno[3]
            {
                alumno1,
                new Alumno("Juan"),
                new Alumno("Julieta")
            };



            Aula aula1 = new Aula("2D", laboII, profesor, 20);

            Aula aula2 = new Aula("2D", progII, profesor, alumnos2D);


        }

    }
}
