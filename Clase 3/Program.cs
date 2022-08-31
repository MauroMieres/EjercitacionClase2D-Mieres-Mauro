using System;
using Biblioteca;

namespace Clase_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona(dniIngresado);
            Mascota mascota = new Mascota();

            

            Console.WriteLine("Hello World!");
        }
    }
}

/* METODOS ESTATICOS: No dependen de un objeto
 * Despues del modificador de acceso se agrega la palabra static
 * public statitic doble VerboInfinitivo (int n)
 * 
 * MODIFICADORES DE ACCESO:
 * public, private, internal, protected
 * 
 * PROYECTOS DE BIBLIOTECAS DE CLASES: Agrupan varias clases
 * 
 * PROYECTOS DE CONSOLA: Interactuan con la consola
 * 
 * 
 * 
