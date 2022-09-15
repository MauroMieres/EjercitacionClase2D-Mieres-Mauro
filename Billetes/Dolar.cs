using System;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Dolar() 
        {
            Dolar.cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion):this(cantidad)
        {
            Dolar.cotzRespectoDolar = cotizacion;
        }

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public double GetCantidad 
        {
            get 
            {
                return this.cantidad;
            }
        }

        public static double GetCotizacion 
        {
            get
            {
                return Dolar.cotzRespectoDolar;
            }
        }

        public static implicit operator Dolar(double d) 
        {
            return new Dolar(d);
        }

        //sobrecargas explicitas para euro y peso
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad*Euro.GetCotizacion);
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.cantidad * Peso.GetCotizacion);
        }

        public static bool operator ==(Dolar d1, Dolar d2) 
        {
            return (d1.GetCantidad == d2.GetCantidad);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            //reutilizamos el de arriba
            return !(d1 == d2);
        }

        public static bool operator ==(Dolar d, Euro e) 
        {
            return (d.GetCantidad == (Dolar)e.GetCantidad);
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return (d.GetCantidad == (Dolar)p.GetCantidad);
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }
    }
}
