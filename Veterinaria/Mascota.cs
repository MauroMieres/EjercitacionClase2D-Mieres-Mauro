using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Mascota
    {
        //De las clienteMascotas necesita conocer su especie, su nombre,
        //su fecha de nacimiento y su historial de vacunación. Los
        //primeros tres datos son obligatorios para dar de alta una
        //mascota, mientras que el último arrancará vacío y se podrá
        //ir agregando vacunas. De las vacunas sólo interesa conocer el nombre.

        private string mascotaNombre;
        private string mascotaEspecie;
        private DateTime mascotaFechaNacimiento;
        private string[] mascotaHistorialVacunas;

        public Mascota(string mascotaClienteNombre, string mascotaEspecie, DateTime mascotaFechaNacimiento, string[] mascotaHistorialVacunas)
        {
            this.mascotaNombre = mascotaClienteNombre;
            this.mascotaEspecie = mascotaEspecie;
            this.mascotaFechaNacimiento = mascotaFechaNacimiento;
            this.mascotaHistorialVacunas = mascotaHistorialVacunas;
        }

        public string MascotaNombre
        {
            get
            {
                return mascotaNombre;
            }
            set
            {
                if (value is not null)
                    mascotaNombre = value;
            }
        }

        public string MascotaEspecie
        {
            get
            {
                return mascotaEspecie;
            }
            set
            {
                if (value is not null)
                    mascotaEspecie = value;
            }
        }

        public DateTime MascotaFechaNacimiento
        {
            get
            {
                return mascotaFechaNacimiento;
            }
            set
            {
                mascotaFechaNacimiento = value;
            }
        }

        public string[] MascotaHistorialVacunas
        {
            get
            {
                return mascotaHistorialVacunas;
            }
            set
            {
                mascotaHistorialVacunas = value;
            }
        }
    }
}
