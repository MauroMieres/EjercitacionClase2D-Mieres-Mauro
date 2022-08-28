using System;
/*
 * Se debe pedir el ingreso por teclado del valor hora, el nombre, 
 * la antigüedad (en años) y la cantidad de horas trabajadas en el 
 * mes de N cantidad de empleados de una fábrica.

Se pide calcular el importe a cobrar teniendo en cuenta que el total 
(que resulta de multiplicar el valor hora por la cantidad de horas trabajadas),
hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total 
de todas esas operaciones restarle el 13% en concepto de descuentos.

Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora,
el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.*/
namespace I07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta = "si";
            do
            {
                Console.Write("Ingrese valor hora: ");
                if (int.TryParse(Console.ReadLine(), out int valorHora))
                {
                    Console.Write("Ingrese nombre del empleado: ");
                    string nombreEmpleadoIngresado = Console.ReadLine();

                    Console.Write("Ingrese antiguedad (en anios): ");
                    string antiguedadIngresada = Console.ReadLine();
                    bool validarAntiguedad = int.TryParse(antiguedadIngresada, out int antiguedad);
                    if (validarAntiguedad)
                    {
                        Console.Write("Ingrese horas trabajadas en el mes: ");
                        string horasTrabajadasIngresadas = Console.ReadLine();
                        bool validarHorasTrabajadas = float.TryParse(horasTrabajadasIngresadas, out float horasTrabajadas);

                        decimal total = (decimal)((valorHora * horasTrabajadas + 150 * antiguedad) * 0.87);
                        Console.WriteLine($"Empleado: {nombreEmpleadoIngresado},salario: {total}");
                    }
                    Console.Write("Quiere ingresar otro empleado? si/no: ");
                    respuesta = Console.ReadLine();
                }
            } while (respuesta == "si");
            Console.ReadKey();
        }
    }
}
