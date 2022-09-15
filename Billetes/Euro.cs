using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Euro()
        {
            Euro.cotzRespectoDolar = 1/1.17;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotzRespectoDolar = cotizacion;
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
                return Euro.cotzRespectoDolar;
            }
        }

        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }

        //sobrecargas explicitas para dolar y peso
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / Euro.GetCotizacion);
        }

        public static explicit operator Peso(Euro e)
        {
            //con esto reutilizamos  public static explicit operator Peso(Dolar d)
            return (Peso)((Dolar)e);
        }

    }
}
