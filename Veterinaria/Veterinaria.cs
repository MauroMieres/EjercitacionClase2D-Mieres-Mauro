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

        public Veterinaria(Cliente[] clientes)
        {
            this.clientes = clientes;
        }

        //clienteDomicilio, el nombre y apellido y un teléfono y clienteMascotas
        public string ObtenerDatosCliente(Cliente cliente)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {cliente.ClienteNombre}, domicilio: {cliente.ClienteDomicilio}, telefono: {cliente.ClienteTelefono}.");
            sb.AppendLine($"Mascotas:");

            foreach (Mascota mascota in cliente.ClienteMascotas)
            {
                string datosMascota = ($"Nombre: {mascota.MascotaNombre},Especie: {mascota.MascotaEspecie},Fecha de nacimiento: {mascota.MascotaFechaNacimiento.ToString()}, vacunas: ");
                sb.AppendLine(datosMascota);

                for (int j = 0; j < mascota.MascotaHistorialVacunas.Length; j++)
                { 
                    string vacunas = (mascota.MascotaHistorialVacunas[j]);
                    sb.AppendLine(vacunas);
                    if (mascota.MascotaHistorialVacunas[j] == null)
                        break;
                }
            }
            return sb.ToString();
        }
    }
}
