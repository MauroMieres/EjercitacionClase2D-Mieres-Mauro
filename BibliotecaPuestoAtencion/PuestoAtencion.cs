using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BibliotecaPuestoAtencion
{
    public class PuestoAtencion
    {
        public enum Puesto 
        {
            Caja1, Caja2
        }

        static int numeroActual;
        Puesto puesto;

        //esto es static porq es el mismo para toda la clase
        static PuestoAtencion() 
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion (Puesto puesto)
        {
            this.puesto = puesto;
        }

        public static int NumeroActual 
        {
            get
            { //usamos operador de pre incremento para que primero haga la suma y despues retorne
                return ++numeroActual;
            }
        }

        public bool Atender(Cliente cliente) 
        {
            if(cliente is not null) 
            {
                //3000 ms = 3 segundos
                Thread.Sleep(3000);
                    return true;
            }
            return false;
        }
    }
}
