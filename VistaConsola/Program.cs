using System;

namespace VistaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write sin el Line no baja de renglon
            Console.Write("Ingrese su edad: ");
            string nombre; //siempre se usa para textos
            nombre = "Mauro";
            string edadIngresada = Console.ReadLine();
            int edad;
            Console.Write("Ingrese precio: ");
            float precio;
            string precioIngresado = Console.ReadLine();
            bool resultado2 = float.TryParse(precioIngresado, out precio);

            bool resultado = int.TryParse(edadIngresada, out edad);

            decimal a = 23.34m;

            float precioConComa = 45.34f;
            //conversion explicita
            int precioSinComa = (int)precioConComa;
            //conversion implicita
            int entero;
            //float flotante = entero;

            if (resultado) 
            {
                Console.WriteLine("Su edad es " + edad);
                //o
                Console.WriteLine($"su edad es {edad}");
                //o
                Console.WriteLine($"su edad es {edad + 20}");
                //o
                Console.WriteLine("Hola {0}, tu edad es {1}", nombre, edad);    
            }
            else
            {
                Console.WriteLine("Edad no valida!");
            }

            if (resultado2)
            {
                Console.WriteLine($"El precio es: {precio:C2}");
            }
            else
            {
                Console.WriteLine("Precio no valido!");
            }

            string [] nombres = new string[3];

            nombres[0] = "Lucas";
            nombres[1] = "Mauro";
            nombres[2] = "Messi";

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }

            string[] paises = { "argentina", "brasil", "uruguay" };

            foreach (string pais in paises)//foreach itera todo el array hasta el final
            {
                Console.WriteLine(pais);
            }

            Console.ReadKey();
        }
    }
}
