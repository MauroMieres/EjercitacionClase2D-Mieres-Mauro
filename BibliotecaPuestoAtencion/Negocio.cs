using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPuestoAtencion
{
    public class Negocio
    {
        PuestoAtencion caja;
        Queue<Cliente> clientes;
        string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();//dequeue saca de la cola al objeto, peek solo muestra quien esta primero
            }
            set
            {
                /*Usando ese guión bajo como si fuera una variable (que no hemos declarado en ningún lado) 
                 * le indica al compilador que queremos hacer caso omiso del resultado devuelto por el
                 * método al que estamos llamando. Es equivalente al fragmento anterior en el que no hacíamos
                 * las asignación, pero tiene la ventaja de ser más explícito, ya que estamos dejando claro
                 * para cualquier que lea el código (incluyéndonos a nosotros mismos dentro de unos meses)
                 * que nuestra intención era sin duda no usar ese valor devuelto, y no ha sido un despiste.*/
                _ = this + value;
            }
        }


        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente item in n.clientes)
            {
                if (c == item)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if (n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }

        public static bool operator ~(Negocio n)
        {
            if(n.clientes.Count != 0) 
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
        }

        public int ClientesPendientes
        {
            get { return clientes.Count; }
        }
    }
}
