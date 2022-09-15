using System;

namespace BibliotecaPuestoAtencion
{
    public class Cliente
    {
        int numero;//si no especifico modificador por defecto es private
        string nombre;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) : this(numero)
        {
            this.numero = numero;
        }

        public int Numero
        {
            get { return numero; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        //cuando uso el operator == esto funciona de a pares, tengo que hacer
        //el distinto tambien !=
        public static bool operator == (Cliente c1, Cliente c2) 
        {
            return c1.numero == c2.numero;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
