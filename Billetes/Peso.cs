using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Peso()
        {
            Peso.cotzRespectoDolar = 138.78;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Peso.cotzRespectoDolar = cotizacion;
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
                return Peso.cotzRespectoDolar;
            }
        }

        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        //sobrecargas para euro y dolar
        public static explicit operator Euro(Peso p)
        {
            return new Euro(p.GetCantidad / Euro.GetCotizacion);
        }

        public static explicit operator Dolar(Peso p)
        {
            //reutilizmos public static explicit operator Euro(Dolar d)
            //si usamos return (Euro)((Dolar)p);
            return new Dolar(p.GetCantidad / Dolar.GetCotizacion);
        }

    }
}
