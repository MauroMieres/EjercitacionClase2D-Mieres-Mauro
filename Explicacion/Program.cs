using System;

namespace Explicacion
{
    internal class Program
    {
        static void Main(string[] args) // ENTRY POINT 
        {

            Console.WriteLine("Bienvenidxs a la tienda de musica");

            Console.WriteLine("Que desean comprar \n");

            Guitarra guitarra1 = new Guitarra("Gibson", 60000, "Melamina", false, 12);
            Guitarra guitarra2 = new Guitarra("Fender", 20000, true);


            Guitarra[] stockGuitarras = new Guitarra[2];

            stockGuitarras[0] = guitarra1;
            stockGuitarras[1] = guitarra2;

            foreach (Guitarra itemGuitarra in stockGuitarras)
            {
                if (itemGuitarra is not null)
                {
                    Console.WriteLine(itemGuitarra.marca);
                    Console.WriteLine(itemGuitarra.precio);

                    itemGuitarra.Afinar();

                    Console.WriteLine();

                }

            }

        }
    }
}
