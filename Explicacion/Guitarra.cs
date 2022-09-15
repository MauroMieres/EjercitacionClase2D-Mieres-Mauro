using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicacion
{
    public class Guitarra
    {
        // atributos 
        public string marca;
        public int precio;
        public string material;
        public bool estaAfinada;
        public int cantidadCuerdas;


        public Guitarra(string marca,int precio)
        {
            material = "NO CARGADO ESTE DATO"; // HARDCODEARLO POR DEFECTO 
            this.marca = marca;
            this.precio = precio;
        }

        public Guitarra(string marca, int precio, string material):this(marca,precio)
        {
            this.material = material;
        }
        public Guitarra(string marca, int precio, string material, bool estaAfinada, int cantidadCuerdas):this(marca,precio,material)
        {
            this.estaAfinada = estaAfinada;
            this.cantidadCuerdas = cantidadCuerdas;
        }

        public Guitarra(string marca,int precio, bool estaAfinada):this(marca,precio)
        {
            this.estaAfinada = estaAfinada;
        }



        // ctrl . 
        // comportamientos

        public bool Afinar()
        {
            estaAfinada = true;
            return estaAfinada;
        }

        // Sobrecarga : agregarle una nueva funcionalidad a algo ya definido

        public void SubirDePrecio(string marca, int aumento, string material)
        {
            if (marca == "Gibson" || marca == "Fender" || material != "Roble")
            {
                precio *= aumento;
            }

        }

        public void SubirDePrecio(int aumento = 2)
        {
            precio *= aumento;
        }
    }
}
