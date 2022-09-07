using System;
using System.Text;

namespace BibliotecaCuentas
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        private string GetTitular()
        {
            return this.titular;
        }

        /*Propiedades  Clase 03 - Parte 2 min 50.00
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }*/

        private decimal GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder datosCuenta = new StringBuilder();

            datosCuenta.AppendLine($"Titular: {titular}");
            datosCuenta.AppendLine($"Saldo: {cantidad}");

            //string datosCuenta = $"Titular: {persona.titular}, Saldo: {persona.cantidad.ToString()}";
            return datosCuenta.ToString();
        }

        public void Ingresar(decimal deposito)
        {
            if (deposito > 0)
                this.cantidad += deposito;
        }

        public void Retirar(decimal extraccion)
        {
            this.cantidad -= extraccion;
        }
    }
}
