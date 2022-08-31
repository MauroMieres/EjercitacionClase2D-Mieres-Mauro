using System;

/*Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

Calcular (público): Recibirá tres parámetros, el primer operando1, el segundo operando1 y la operación matemática. El método devolverá el resultado de la operación.

Validar (privado): Recibirá como parámetro el segundo operando1. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando1 es distinto de cero.

Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.*/

namespace Ejercicio_I04___La_calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            float operando1;
            float operando2;
            do
            {
                Console.Write("Ingrese un numero: ");
                string numeroIngresado = Console.ReadLine();
                while (!float.TryParse(numeroIngresado, out operando1))
                {
                    Console.Write("Ingrese un numero valido: ");
                    numeroIngresado = Console.ReadLine();
                }

                Console.Write("Ingrese otro numero: ");
                numeroIngresado = Console.ReadLine();
                while (!float.TryParse(numeroIngresado, out operando2))
                {
                    Console.Write("Ingrese un numero valido: ");
                    numeroIngresado = Console.ReadLine();
                }

                Console.Write("Que operacion quiere realizar? Ingrese el caracter: +;-;*;/ : ");
                string operacionIngresada = Console.ReadLine();
                float resultado = Calculadora.Calcular(operando1, operando2, operacionIngresada);

                if (operacionIngresada == "+" || operacionIngresada == "-" || operacionIngresada == "*" || operacionIngresada == "/")
                    Console.WriteLine($"Resultado de: {operando1} {operacionIngresada} {operando2} = {resultado}");

                Console.Write("Quiere hacer otra operacion? S/N: ");
                respuesta = Console.ReadLine();
            } while (Validador.ValidarRespuesta(respuesta));

            Console.ReadKey();
        }
    }
}
