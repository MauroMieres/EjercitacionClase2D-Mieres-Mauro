using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I04___La_calculadora
{
    internal class Calculadora
    {
        public static float Calcular(float operando1, float operando2, string operacion)
        {
            switch (operacion)
            {
                case "+":
                    return operando1 + operando2;

                case "-":
                    return operando1 - operando2;

                case "*":
                    return operando1 * operando2;

                case "/":
                    if (Validar(operando2))
                        return operando1 / operando2;
                    Console.WriteLine("No se puede dividir por cero! ");
                    return -1;

                default:
                    Console.WriteLine("ERROR! Se ingreso una operacion invalida!");
                    return -1;
            }
        }

        private static bool Validar(float operando2)
        {
            if (operando2 != 0)
                return true;
            return false;
        }
    }
}
