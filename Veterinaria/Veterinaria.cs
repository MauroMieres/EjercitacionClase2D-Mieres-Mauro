using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Veterinaria
    {
        private Cliente[] clientes;

        public Veterinaria()
        {
            clientes = new Cliente[10];
        }

        public Veterinaria(Cliente[] clientes)
        {
            this.clientes = clientes;
        }

        //clienteDomicilio, el nombre y apellido y un teléfono y clienteMascotas
        public string ObtenerDatosCliente(Cliente cliente)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {cliente.ClienteNombre}, domicilio: {cliente.ClienteDomicilio}, telefono: {cliente.ClienteDomicilio}, mascotas: ");

            for (int i = 1; i < cliente.ClienteMascotas.Length; i++)
            {
                foreach (Mascota mascota in cliente.ClienteMascotas)
                {
                    string datosMascota = ($"Nombre: {mascota.MascotaNombre},Especie: {mascota.MascotaEspecie},Fecha de nacimiento: {mascota.MascotaFechaNacimiento.ToString()}, vacunas: ");
                    sb.AppendLine (datosMascota);

                    for(int j = 0; j < mascota.MascotaHistorialVacunas.Length; j++) 
                    {
                        string vacunas = (mascota.MascotaHistorialVacunas[j]);
                        sb.AppendLine(vacunas);
                    }
                }   
        }
            return sb.ToString();
        }
}
}
