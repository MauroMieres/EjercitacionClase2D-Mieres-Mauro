using System;

namespace I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Mostrar por pantalla todos los números primos que haya hasta 
            el número que ingrese el usuario por consola.
            Validar que el dato ingresado por el usuario sea un número.
            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            Si ingresa "salir", cerrar la consola.
            Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
          */

            string respuesta = "n";
            bool validarNumeroIngresado = false;
 
            while (respuesta!="s") 
            {
                Console.Write("Ingrese un numero: ");
                string numeroIngresado = Console.ReadLine();
                validarNumeroIngresado = int.TryParse(numeroIngresado, out int numero);

                if (validarNumeroIngresado)
                {
                    Console.WriteLine("Numeros primos hasta el {0}:", numeroIngresado);
                    int cont = 0;
                    for (int i = 2; i <= numero; i++) //arranca en 2 porque el 1 no es primo
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            if (i % j == 0) //si entra aca, es porque i es divisible por j
                            {
                                cont++;
                            }
                        }
                        if (cont == 2) //si es divisible solo por 2 numeros, 1 y si mismo, es primo
                        {
                            Console.WriteLine(i);
                        }
                        cont = 0;
                    }
                }
                else 
                {
                    Console.WriteLine("Numero ingresado invalido, desea salir? s/n");
                    respuesta = Console.ReadLine();
                }
            }
            Console.WriteLine("Salir!");
            Console.ReadKey();
        }
    }
}
