using System;

namespace Resumen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

/* Paradigma: teoria o conjunto de teorias cuyo nucleo central se acepta sin 
 * cuestionar.
 * 
 * Paradigma de programacion: define la forma, metodologia o estilo con el que se resolvera
 * un problema utilizando un lenguaje de programacion.
 * 
 * Entre los paradigmas mas comunes se encuentran: 
 * -Paradigma imperativo: el programador instruye a la maquina como cambiar su estado
 * -Paradigma procedural: separa instrucciones de procedimientos.
 * 
 * -Paradigma orientado a objetos:  agrupa estas instrucciones junto con el estado sobre
 * el que operan.
 * 
 *-Paradigma declarativo: en el que el programador solamente declara propiedades de un
 *resultado deseado, pero no indica cómo calcularlo.
 *-Paradigma funcional: donde el resultado deseado es declarado como el valor de una serie
 *de aplicaciones de función.
 *-Paradigma lógico: donde el resultado deseado se declara como la respuesta a una pregunta
 *sobre un sistema de hechos y reglas.
 *-Paradigma matemático: donde el resultado deseado se declara como la solución de un
 *problema de optimización.
 *-Paradigma reactivo: donde el resultado deseado se declara con flujos de datos y 
 *la propagación del cambio.
 * 
 * Programación orientada a objetos:
 * Propone resolver problemas a traves de identificar objetos de la vida real, sus atributos
 * (datos), su comportamiento (acciones) y las relaciones de colaboracion entre ellos
 * 
 * Un objeto representa algo de la vida real.
 * Los objetos son definidos por dos componentes: atributos y comportamiento.
 * 
 * Pilares de la programacion orientada a objetos:
 * 
 * Abstraccion: capturar la idea ppal de un objeto dentro de un determinado contexto
 * ignorando detalles o especificaciones irrelevantes.
 * 
 * Encapsulamiento: agrupar datos y acciones relacionados a un objeto. Es necesario definir 
 * y controlar como y desde donde un objeto puede ser accedido y/o modificado.
 * 
 * Herencia: se trata de reutilizar codigo pariendo de una clase mas general (padre o base)
 * que compartirar esctructura y funcionalida a clases mas especificas (hijas o derivadas)
 * 
 * Polimorfismo: se trata de que una clase hija o derivada se pueda redefinir una determinada
 * accion heredada de una clase padre o base.
 * 
 * CLASES:
 * 
 * Una clase es una plantilla para la creación de objetos de datos según un modelo predefinido. 
 * Las clases se utilizan para representar entidades o conceptos. Cada clase es un modelo que define
 * un conjunto de variables (el estado), y métodos apropiados para operar con dichos datos (el comportamiento).
 * Cada objeto creado a partir de la clase se denomina instancia de la clase.
 * 
 * Instanciar objetos es el proceso de generar un ejemplar de una clase, es decir, la clase es como una declaración 
 * de una forma y el objeto es un caso o elemento concreto que responde a esa forma.
 * 
 * Un tipo q se define como una clase es un tipo de referencia.En tiempo de ejecucion, cuando declara
 * una variable de un tipo de referencia la variable contiene valor NULL hasta q se crea 
 * explicitamente una instancia de la clase utilizando el operador NEW, o le saigna un objeto
 * de un tipo compatible que puede haber sido creado en otro lugar, ejemplo:
 * 
 * MyClass mc = new MyClass();
 * MyClass mc2 = mc;
 * 
 * Declaracion: Las clases se declaran utilizando la palabra reserverada class seguida de
 * un identificador:
 * 
 * public class Customer
 * 
 * 
 * la palabra class, esta precedida por un modificador de acceso.
 * 
 * Una clase y un objeto son cosas diferentes. Una clase define un tipo de objeto,
 * pero no es un objeto en si mismo. Un objeto es una entidad concreta basada en una clase y
 * a veces se lo denomina instancia de una clase.
 * 
 * Customer object1 = new Customer();
 *
 * Cuando se crea una instancia de una clase, se devuelve una referencia al objeto. En el ejemplo
 * anterior, object1 es una referencia a un objeto que se basa en Customer. Esta referencia apunta
 * al nuevo objeto pero no contiene los datos del objeto en sí.
 * 
 * Customer object3 = new Customer();
 * Customer object4 = object3;
 * 
 *Este código crea dos referencias a objetos que hacen referencia al mismo objeto. Por lo
 *tanto, cualquier cambio que se realice en el objeto object3 se refleja en los usos
 *posteriores de object4. Debido a que se hace referencia a los objetos que se basan
 *en clases, las clases se conocen como tipos de referencia.
 *
 * OBJETOS: 
 * Una clase es como un molde que especifica lo que puede hacer ese tipo. Un objeto es 
 * basicamente un bloque de memoria que se ha asignado y configurado al molde.
 * Un programa puede crear varios objetos de la misma clase. Los objetos tambien se denominan
 * instancias y se pueden almacenar en una variable con nombre o en una matriz o coleccion.
 * 
 * Se utilizan variables para llamar a los metodos y acceder a las propiedades publicas del
 * objeto, en C# varios objetos interactuan dinamicamente.
 * 
 * Instancias de una clase:
 * 
 * Instancias de una clase
Las instancias de las clases se crean utilizando el operador new. En el ejemplo siguiente, Persona es el tipo y persona1 y persona2 son instancias u objetos de ese tipo.

public class Persona
{
    public string nombre;
    public int edad;

    public Persona(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }
    // Otras propiedadse, metodos...
}

class Program
{
    static void Main()
    {
        Persona persona1 = new Persona("Leopold", 6);
        Console.WriteLine("persona1 Nombre = {0} Edad = {1}", persona1.nombre, persona1.edad);

        // Declaro nueva persona, asigno persona1 .
        Persona persona2 = persona1;

        // Modifico nomebre y edad de persona2, y persona1 también es modificada.
        persona2.nombre = "Molly";
        persona2.edad = 16;

        Console.WriteLine("persona2 Nombre = {0} Edad = {1}", persona2.nombre, persona2.edad);
        Console.WriteLine("persona1 Nombre = {0} Edad = {1}", persona1.nombre, persona1.edad);
    }
}
/*
    Output:
    persona1 Nombre = Leopold Edad = 6
    persona2 Nombre = Molly Edad = 16
    persona1 Nombre = Molly Edad = 16

 *Identidad de un objeto:
 *Cuando comparamos la igualda de dos objetos, primero debemos distinguir si se desea saber
 *si las dos variables representan el mismo objeto en la memoria o si los valores de uno
 *o mas de sus campos son equivalentes.
 *
 *Para determinar si dos instancias de clase se refieren a la misma ubicacion de memoria 
 *(lo que significa q tienen la misma identidad), se usa el moetodo estatico Object.Equals
 *o ReferenceEquals.
 *
 *Para deteminar si lso valores de lso campos de dos instancias de clase son iguales se puede
 usar el metodo Equals o el operador ==, sin embargo estos solo deben utilizarse si la clase
los ha anulado o sobrecargado para proporcionar una definicion personalizada de lo que 
significa "igualda" para objetos de este tipo.

Constructores: 
Los constructores permiten al programador establecer valores predeterminados, limitar la 
creacion de instancias y escribir codigo que sea flexible y facil de leer.

Constructores de instancia:

Cada vez que se crea una intancia de una clase, se llama a su constructor. Los constructores tienen el mismo nombre que la clase y, por lo general, inicializan los atributos/campos del nuevo objeto.

public class Taxi
{
    public bool IsInitialized;

    public Taxi()
    {
        IsInitialized = true;
    }
}

class Program
{
    static void Main()
    {
        Taxi t = new Taxi();
        Console.WriteLine(t.IsInitialized);
    }
}

Un constructor que no toma parametros se llama constructor sin parametros, se invocan cada
vez que se crea una instancia de un objeto mediante el operador new y no se proporcionan
argumentos.

Los constructores se pueden marcar como public , private , protected , internal , protected internal o private protected .

Una clase puede tener múltiples constructores que toman diferentes argumentos:

public class Empleado
{
    public int salario;

    public Empleado() { }

    public Empleado(int salarioAnual)
    {
        salario = salarioAnual;
    }

    public Empleado(int salarioSemanal, int cantidadDeSemanas)
    {
        salario = salarioSemanal * cantidadDeSemanas;
    }
}

Esta clase se puede crear usando cualquiera de las siguientes declaraciones:

Empleado e1 = new Empleado(30000);
Empleado e2 = new Empleado(500, 52);

Un constructor puede invocar a otro constructor en el mismo objeto usando la palabra reservada this . Puede usarse con o sin parámetros, y cualquier parámetro en el constructor está disponible como parámetro para this o como parte de una expresión. Por ejemplo, el segundo constructor del ejemplo anterior se puede reescribir usando this:

public Empleado(int salarioSemanal, int cantidadDeSemanas)
    : this(salarioSemanal * cantidadDeSemanas)
{
}

El uso de this en el ejemplo anterior hace que se llame a este constructor:

public Empleado(int salarioAnual)
{
    salario = salarioAnual;
}

Constructores Estáticos:

Un constructor estatico se usa para inicializar cualquier campo /atributo estatico o para
realizar una accion particular que deba realizarse una sola vez. Se llama automaticamente antes 
de que se cree la primer instancia o se haga referencia a cualquier miembro estatico.
Estos constructores no tienen ni parametros ni modificador de acceso. Si no se proporciona
un constructor estatico para inicializar los campos estaticos, el compilador de C# inicializa
los campos estaticos en su valor predeterminado.

En este ejemplo, la clase Bus tiene un constructor estático. Cuando se crea la primera instancia de Bus (bus1), se invoca el constructor estático para inicializar la clase. La salida de muestra verifica que el constructor estático se ejecuta solo una vez, aunque se crean dos instancias de Bus, y que se ejecuta antes de que se ejecute el constructor de instancia.

public class Bus
{
    // Atributo estático utilizada por todas las instancias de Bus.
     // Representa la hora en que el primer autobús del día inicia su ruta.
    public static DateTime horaDeInicio;

    //atributo de instancia
    public int numeroDeRuta;

    // Constructor estático para inicializar la variable estática.
    // Se invoca antes de que se ejecute el constructor de la primera instancia.
    static Bus()
    {
        horaDeInicio = DateTime.Now;

        // La siguiente declaración produce la primera línea de salida,
        // y la línea aparece solo una vez.
        Console.WriteLine("El constructor estático establece la hora de inicio en {0}",
            horaDeInicio.ToLongTimeString());
    }

    // Constructor de instancia.
    public Bus(int numeroDeRuta)
    {
        this.numeroDeRuta = numeroDeRuta;
        Console.WriteLine("Bus #{0} creado.", numeroDeRuta);
    }

    // Metodo de instancia.
    public void Conducir()
    {
        TimeSpan tiempoTrascurrido = DateTime.Now - horaDeInicio;

        // Para fines de demostración, tratamos los milisegundos como minutos para simular
         // tiempos reales de autobús. ¡No haga esto en su programa!
        Console.WriteLine("{0} está comenzando su ruta {1: N2} minutos después de la hora de inicio {2}.",
                                this.numeroDeRuta,
                                tiempoTrascurrido.Milliseconds,
                                horaDeInicio.ToShortTimeString());
    }
}

class TestBus
{
    static void Main()
    {
        // La creación de esta instancia activa el constructor estático.
        Bus bus1 = new Bus(71);

        // Crea un segundo autobús.
        Bus bus2 = new Bus(72);

        
        bus1.Conducir();

        // Espera 25 milisegundos
        System.Threading.Thread.Sleep(25);

       
        bus2.Conducir();

  
        Console.ReadKey();
    }
}
/* Sample output:
    El constructor estático establece la hora de inicio en 3:57:08 PM.
    Bus #71 creado.
    Bus #72 creado.
    71 está comenzando su ruta 6.00 minutos después de la hora de inicio 3:57 PM.
    72 está comenzando su ruta 31.00 minutos después de la hora de inicio 3:57 PM.

*/