using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Boligrafo
    {
        short cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor() 
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta) 
        {
            //positivo carga tinta
            if (tinta > 0) 
            {
                if ((this.tinta + tinta) <= 100)
                    CambiarNivelTinta(tinta);
            }
            //negativo gasta tinta
            if (tinta < 0) 
            {
                if ((this.tinta + tinta) >= 0)
                    CambiarNivelTinta(tinta);
            }   
        }

        private void CambiarNivelTinta(short tinta) 
        {
            this.tinta += tinta;
        }

        public void Recargar() 
        {
            short tintaCargada = GetTinta();
            short tintaParaCargar = (short)(100 - tintaCargada);
            SetTinta(tintaParaCargar);
        }

        /*El método Pintar restará la tinta gastada (reutilizar código). El parámetro gasto representará la cantidad de unidades de tinta a utilizar
         * y utilizará tanta tinta como tenga disponible sin quedar en negativo. Utilizando el parámetro dibujo informará el resultado retornando tantos * como 
         * unidades de tinta haya gastado, por ejemplo:
            Si no había nada de tinta retornará una cadena de texto vacía.
            Si el nivel de tinta era 10 y la cantidad a gastar 2, entonces retonará **.
            Si el nivel de tinta era 3 y la cantidad a gastar 10, entonces retornará ***.*/

        public bool Pintar(short gasto,out string dibujo) 
        {
            //gasto es la cantidad de univades de tinta a utilizar
            //se usa tanta como sea disponible sin quedar en negativo, entonces primero tengo qsaber cuanta tinta hay
            short tintaCargada = GetTinta();

            if (tintaCargada - gasto < 0) 
            {
                gasto = tintaCargada;
            }

            SetTinta((short)(gasto*-1));

            if (tintaCargada == 0)
                dibujo = "";
            else 
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 1; i <= gasto; i++)
                    sb.Append("*");
                dibujo = sb.ToString();
                Console.ForegroundColor = GetColor();
                Console.WriteLine(dibujo);
                Console.ForegroundColor = ConsoleColor.White;
            }   
            return true;
        }
    }
}
