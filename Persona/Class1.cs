using System;
using System.Text;


namespace ClasePersona
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public DateTime FechaDeNacimiento
        {
            get
            {
                return fechaDeNacimiento;
            }
            set
            {
                fechaDeNacimiento = value;
            }
        }

        public int Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }

        private int CalcularEdad() 
        {
                DateTime fechaInicial = new DateTime(this.fechaDeNacimiento.Year, this.fechaDeNacimiento.Month, this.fechaDeNacimiento.Day);
                DateTime fechaActual = DateTime.Now;
                int edad = (fechaActual.Subtract(fechaInicial).Days)/365;
                return edad;
        }

        public string Mostrar()
        {
            string datosPersona = $"Nombre: {nombre}, fecha de nacimiento: {fechaDeNacimiento}, {CalcularEdad()} anios, DNI: {dni}";
            return datosPersona;
        }

        public string EsMayorDeEdad() 
        {
            if (CalcularEdad() >= 18)
                return "es mayor de edad.";
            return "es menor.";
        }
    }
}
