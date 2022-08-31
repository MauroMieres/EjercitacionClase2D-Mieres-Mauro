using System;

namespace Clase4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

/* Ya vimos abstraccion
 * Encapsulamiento: ocultar el estado de nuestro objeto
 * Herencia: posibilidad de crear nuevas clases a partir de una existen
 * Polimorfismo : hacer muchas cosas bajo un mismo nombre o una tarea similar
 * ENCAPSULAMIENTO:
 * capsula(acceso): propiedades y metodos
 * contenido (sin acceso): atributos y metodos
 * Encapsulamiento: ocultar el estado interno y la funcionalidad de un objeto
 * y permitir solo el acceso a atraves de un conjunto publico de funciones
 * 
 * Abstraccion a la clase cafetera:
 * responsabilidad: preparar la infusion de cafe a partir de agua y granos
 * 
 * interfaz de la clase/operaciones publicas:
 * cargar agua, suministrar cafe, encender, apagar, etc
 * 
 * Encapsulamieanto:
 * el material plastico que recubre la cafetera esconde el mecanismo
 * que resuelve la preparacion del cafe, entonces:
 * No sabemos como transforma la energia en calor, no sabenmos a que temperatura
 * calienta el agua, no sabemos como esta armado el circuito de agua, no sabemos
 * que presion impacta al agua y no podemos realizar modificacion sobre todo lo
 * nombrado anteriormente
 * 
 * Modificadores de acceso: public: es accesible desde cualquier parte
 * private solo accesible desde dentro del mismo tipo
 * internal solo accesible dentro del mismo ensamblado/proyecto
 * 
 * son modificadores q sirven para los atributos,metodos, y q establecen
 * el grado de interaccion q tienen 
 * 
 * Propiedades:
 * Es un miembro q proporciona un mecanismo flexible para leer, escribir o calcular el valor
 * de un atributo.
 * 
 * No son mas q otra forma de escribir metodos de acceso (getters y setters)
 * 
 * Nos ayudan a aplicar el encapsulamiento
 * 
 * Son codigo que colocamos un get, un set y dentro hacemos validaciones para que
 * retornen los valores
 * */