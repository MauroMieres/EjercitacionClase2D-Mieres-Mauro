using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Cliente
    {
        //clienteDomicilio, el clienteNombre y apellido y un teléfono. 
        private string clienteNombre;
        private string clienteDomicilio;
        private string clienteTelefono;
        private Mascota[] mascotas;

        public Cliente(string nombre, string domicilio, string telefono, Mascota[] mascotas)
        {
            this.clienteNombre = nombre;
            this.clienteDomicilio = domicilio;
            this.clienteTelefono = telefono;
            this.mascotas = mascotas;
        }

        public string ClienteNombre
        {
            get
            {
                return clienteNombre;
            }
            set
            {
                if(value is not null)
                clienteNombre = value;
            }
        }

        public string ClienteDomicilio
        {
            get
            {
                return clienteDomicilio;
            }
            set
            {
                if (value is not null)
                    clienteDomicilio = value;
            }
        }

        public string ClienteTelefono
        {
            get
            {
                return clienteTelefono;
            }
            set
            {
                if (value is not null)
                    clienteTelefono = value;
            }
        }

    }
}
