using System;
using BibliotecaCuentas;
/*Consigna
Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

Deberá tener los atributos:

titular que contendrá la razón social del titular de la cuenta.
cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
Construir los siguientes métodos para la clase:

Un constructor que permita inicializar todos los atributos.
Un método getter para cada atributo.
mostrar retornará una cadena de texto con todos los datos de la cuenta.
ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.*/

namespace Ejercicio_I01___Creo_que_necesito_un_préstamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Cuenta persona1 = new Cuenta("Mauro", 500000);

            Console.WriteLine(persona1.Mostrar());

            Random r = new Random();

            decimal rDecimal = r.Next(0,10000);
            Console.WriteLine(rDecimal);

            persona1.Ingresar(rDecimal);
            Console.WriteLine($"Despues de ingresar dinero -->" + persona1.Mostrar());

            decimal rDecimal2 = r.Next(0, 10000);
            Console.WriteLine(rDecimal2);

            persona1.Retirar(rDecimal2);
            Console.WriteLine($"Despues de retirar dinero -->" + persona1.Mostrar());

            Console.ReadKey();
        }
    }
}
