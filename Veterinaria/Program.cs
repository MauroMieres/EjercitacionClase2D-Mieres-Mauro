using System;

namespace Veterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///hardcordear clientes y clienteMascotas 

            DateTime fechaMascota1 = new DateTime(2020, 07, 23);
            string[] vacunasMascota1 = new string[10];
            vacunasMascota1[0] = "vacuna1";
            vacunasMascota1[1] = "antirrabica";
            vacunasMascota1[2] = "desparasitar";
            Mascota mascota1 = new Mascota("Chimuelo", "Perro", fechaMascota1, vacunasMascota1);

            DateTime fechaMascota2 = new DateTime(2015, 02, 1);
            string[] vacunasMascota2 = new string[10];
            vacunasMascota1[0] = "vacuna1";
            Mascota mascota2 = new Mascota("Kalila", "Perro", fechaMascota2, vacunasMascota2);

            DateTime fechaMascota3 = new DateTime(2022, 13, 9);
            string[] vacunasMascota3 = new string[10];
            Mascota mascota3 = new Mascota("Nala", "Gato", fechaMascota3, vacunasMascota3);

            Mascota[] arrayMascotas1 = new Mascota[3];
            arrayMascotas1[0] = mascota1;
            arrayMascotas1[1] = mascota2;
            arrayMascotas1[2] = mascota3;

            Cliente cliente1 = new Cliente("Mauro", "Doxxeado 420", "1139096719", arrayMascotas1);

            ///

            DateTime fechaMascota4 = new DateTime(2007, 05, 15);
            string[] vacunasMascota4 = new string[10];
            vacunasMascota4[0] = "vacuna1";
            Mascota mascota4 = new Mascota("Simba", "Perro", fechaMascota4, vacunasMascota4);

            Mascota[] arrayMascotas2 = new Mascota[1];
            arrayMascotas2[0] = mascota4;

            Cliente cliente2 = new Cliente("Lucas", "Doxxeado 6969", "4455-7755", arrayMascotas2);

            ///

            DateTime fechaMascota5 = new DateTime(2013, 12, 7);
            string[] vacunasMascota5 = new string[10];
            Mascota mascota5= new Mascota("White", "Gato", fechaMascota5, vacunasMascota5);

            Mascota[] arrayMascotas3 = new Mascota[1];
            arrayMascotas3[0] = mascota5;

            Cliente cliente3 = new Cliente("Ulises", "Calle Siempre Viva 123", "911", arrayMascotas3);

            Cliente[]clientes= new Cliente[3];
            clientes[0] = cliente1;
            clientes[1] = cliente2;
            clientes[2] = cliente3;

            ///

            Veterinaria veterinariaDorothea = new Veterinaria(clientes);

            Console.ReadKey();
        }
    }
}
