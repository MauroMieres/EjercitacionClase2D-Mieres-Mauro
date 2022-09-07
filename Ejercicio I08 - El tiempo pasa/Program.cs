using System;

/*
 * Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa fecha hasta la fecha actual. Tener en cuenta los años bisiestos.

Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule el número de días vividos por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.

Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.*/

namespace Ejercicio_I08___El_tiempo_pasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar anio de nacimiento: ");
            string anioIngresado = Console.ReadLine();
            int anio = int.Parse(anioIngresado);

            Console.Write("Ingresar mes de nacimiento: ");
            string mesIngresado = Console.ReadLine();
            int mes = int.Parse(mesIngresado);

            Console.Write("Ingresar dia de nacimiento: ");
            string diaIngresado = Console.ReadLine();
            int dia = int.Parse(diaIngresado);

            Console.WriteLine("Usted vivio "+Fechas.CalcularDiasVividos(anio,mes,dia)+" dias.");

            Console.ReadKey();
        }
    }
}
