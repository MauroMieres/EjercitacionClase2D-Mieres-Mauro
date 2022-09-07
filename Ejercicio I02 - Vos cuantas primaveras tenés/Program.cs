using System;
using ClasePersona;
/*Crear una aplicación de consola y una biblioteca de clases que contenga la clase ClasePersona.

Deberá tener los atributos:

nombre
fechaDeNacimiento
dni
Deberá tener un constructor que inicialice todos los atributos.

Construir los siguientes métodos para la clase:

Setter y getter para cada uno de los atributos.
CalcularEdad será privado y retornará la edad de la persona calculándola a 
partir de la fecha de nacimiento.
Mostrar retornará una cadena de texto con todos los datos de la persona, 
incluyendo la edad actual.
EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad",
sino devuelve “es menor”.
Instanciar 3 objetos de tipo ClasePersona en el método Main.
Mostrar quiénes son mayores de edad y quiénes no.*/
namespace Ejercicio_I02___Vos_cuantas_primaveras_tenés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha1 = new DateTime(1998, 09, 16);
            DateTime fecha2 = new DateTime(2005, 09, 16);
            DateTime fecha3 = new DateTime(2010, 09, 16);

            Persona mauro = new Persona("Mauro", fecha1, 24093426);
            Persona lucas = new Persona("Lucas", fecha2, 24093777);
            Persona ulises = new Persona("Ulises", fecha3, 24093123);

           string datosMauro = mauro.Mostrar();
           string datosLucas = lucas.Mostrar();
           string datosUlises = ulises.Mostrar();

            Console.WriteLine(datosMauro);
            Console.WriteLine(datosLucas);
            Console.WriteLine(datosUlises);

            string mauroMayor = mauro.EsMayorDeEdad();
            Console.WriteLine($"{mauro.Nombre} {mauroMayor}");
            string lucasMayor = lucas.EsMayorDeEdad();
            Console.WriteLine($"{lucas.Nombre} {lucasMayor}");
            string ulisesMayor = ulises.EsMayorDeEdad();
            Console.WriteLine($"{ulises.Nombre} {ulisesMayor}");

            Console.ReadKey();
        }
    }
}
