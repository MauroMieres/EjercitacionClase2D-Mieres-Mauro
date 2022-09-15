using System;
using System.Collections.Generic;
using System.Linq;


namespace Números_locos_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();

            Stack<int> stackNumerosPositivos = new Stack<int>();
            Stack<int> stackNumerosNegativos = new Stack<int>();

            Queue<int> queueNumerosPositivos = new Queue<int>();
            Queue<int> queueNumerosNegativos = new Queue<int>();

            Random rdn = new Random();

            for (int i = 0; i < 20; i++) 
            {
                listaNumeros.Add(rdn.Next(-100, 100));
            }

            Console.WriteLine("Lista");
            foreach (int item in listaNumeros) 
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lista positivos ordenados decreciente");
            listaNumeros.Sort(Program.OrdenarDescendente);

            foreach (int i in listaNumeros)
            {
                if (i > 0)
                {
                    Console.WriteLine(i);
                    queueNumerosPositivos.Enqueue(i);//agrego positivo a la cola de positivos
                }
                else if (i != 0)
                {
                    queueNumerosNegativos.Enqueue(i);//agrego negativos a la cola de negativos
                }
            }

            Console.WriteLine("Lista negativos ordenados creciente");
            listaNumeros.Sort();
            foreach(int i in listaNumeros) 
            {
                if(i < 0)
                    Console.WriteLine(i);
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Cola positivos");

            foreach (int item in queueNumerosPositivos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Cola negativos");
            foreach (int item in queueNumerosNegativos)
            {
                Console.WriteLine(item);
            }

            foreach (int i in listaNumeros)
            {
                if (i > 0)
                {
                    stackNumerosPositivos.Push(i);//agrego positivo a la pila de positivos
                }
                else if (i != 0)
                {
                    stackNumerosNegativos.Push(i);//agrego negativos a la pila de negativos
                }
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Stack positivos");
            foreach (int item in stackNumerosPositivos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Stack negativos");
            foreach (int item in stackNumerosPositivos)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        public static int OrdenarDescendente(int a, int b)
        {
            return b - a;
        }
    }
}
