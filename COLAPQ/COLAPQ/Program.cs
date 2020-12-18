// NOMBRE DEL PROGRAMA: Implementacion de Colas de Prioridad
// NOMBRE DEL ESTUDIANTE: Ampudia Jared
// CURSO: 3er nivel
// PARALELO: 1
// FECHA DE ENTREGA: 05/oct/2020
// PROPOSITO DE ULTIMA MODIFICACION:  Implementacion de ADT Colas de Prioridad
// FECHA DE ULTIMA MODIFICACION: 04/oct/202

using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace COLAPQ
{
    // Definicion de clases

    // Definicion de la clase del programa principal
    class Program
    {
        // Programa principal
        static void Main(string[] args)
        {
            ColaPQ pq = new ColaPQ();
            byte opcion;
            string menu = "\tOpciones cola de prioridad\n1. Insertar persona\n2. Remover persona\n3. Leer tope\n4. Imprimir cola" +
                "\n5. Finalizar programa";

            Console.Title = "Cola de Prioridad - Jared Ampudia";
            do
            {
                Console.Clear();
                Console.Write(menu + "\nOpción: ");
                opcion = Convert.ToByte(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        LeerPersona(pq);
                        ImprimirExito("Persona ingresada con éxito! (presiona cualquier tecla para continuar)");
                        break;
                    case 2:
                        if(pq.EstaVacia())
                            ImprimirError("Aún no hay personas en la cola (presiona cualquier tecla para continuar)");
                        else
                        {
                            pq.Remover();
                            ImprimirExito("Persona removida con éxito! (presiona cualquier tecla para continuar)");
                        }
                        break;
                    case 3:
                        ImprimirExito("Tope de la cola: " + pq.Tope() + "\n(presiona cualquier tecla para continuar)");
                        break;
                    case 4:
                        ImprimirInformacion(pq);
                        break;
                    case 5:
                        ImprimirExito("Programa finalizado con éxito");
                        break;
                    default:
                        ImprimirError("Ingresa una opción válida. (presiona cualquier tecla para continuar)");
                        break;
                }
                Console.ReadKey();
            } while (opcion != 5);
        }

        // Nombre: LeerPersona
        // Proposito: funcion que lee por consola el nombre y la edad de un nuevo objeto persona y lo inserta en la cola que recibe como argumento
        public static void LeerPersona(ColaPQ pq)
        {
            Persona persona;
            string nombre = string.Empty;
            short edad = -1;
            bool invalid;

            invalid = true;
            do
            {
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                if (nombre.Length <= 10)
                    invalid = false;
                if (invalid)
                    ImprimirError("Error, el nombre debe contener máximo 10 caracteres.");
            } while (invalid);

            Console.Write("Edad: ");
            edad = Convert.ToInt16(Console.ReadLine());
            persona = new Persona(nombre, edad);
            pq.Insertar(persona);
        }

        // Nombre: ImprimirInformacion
        // Proposito: funcion que imprime los elementos de la cola con un encabezado de referencia
        public static void ImprimirInformacion(ColaPQ pq)
        {
            Console.WriteLine("\n{0}\n{1,-10} {2,-2}", "Personas de la cola ordenadas según su edad:", "NOMBRE", "EDAD");
            pq.Imprimir();
            ImprimirExito("\n(presiona cualquier tecla para continuar)");
        }

        // Nombre: ImprimirError
        // Proposito: funcion que imprime un mensaje en caracteres rojos
        static void ImprimirError(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.White;
        }

        // Nombre: ImprimirExito
        // Proposito: funcion que imprime un mensaje en caracteres verdes
        static void ImprimirExito(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }


    // Definicion de la clase ColaPQ
    // Simula una cola de prioridad
    class ColaPQ
    {
        // Variables de instancia
        private Persona[] items;
        private int index;
        Persona pNull = new Persona("null");

        // Constructor
        public ColaPQ()
        {
            Index = 0;
            items = new Persona[Index];
        }

        // Propiedades get y set
        protected int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }

        // Nombre de la funcion: EstaVacia
        // Proposito: Verifica si la ColaPQ tiene elementos. Si hay elementos devuelve un booleano con el valor de false, caso contrario true
        public Boolean EstaVacia()
        {
            return items.Length == 0 ? true : false;
        }

        // Nombre de la funcion: Insertar
        // Proposito: Añade un nuevo elemento a la cola. Mediante una llamada al metodo OrdenarInsercion(), el la pila es ordenada de forma
        // descendente en funcion de la edad del objeto Persona añadido.
        public void Insertar(Persona element)
        {
            if (Index == 0)
            {
                Array.Resize(ref items, ++Index);
                items[Index - 1] = element;
            }
            else
            {
                Array.Resize(ref items, ++Index);           // Aumenta la longitud del arreglo en 1
                items[Index - 1] = element;
            }
            OrdenarInsercion();
        }

        // Nombre de la funcion: Remover
        // Proposito: Retorna el objeto Persona con la edad minima, el objeto retornado es eliminado de la cola
        public Persona Remover()
        {
            if (EstaVacia())
            {
                Console.WriteLine("queue underflow");
                return pNull;
            }
            else
            {
                Persona[] itemsCopy = new Persona[index];
                Persona result = items[0];
                itemsCopy = items;

                Array.Resize(ref items, --Index);              // Disminuye la longitud del arreglo en 1

                for (int i = 0; i < Index; i++)                // El arreglo items retoma los valores. El objeto Persona con la edad minima
                    items[i] = itemsCopy[i + 1];               // es retornado al programa principal

                return result;
            }
        }

        // Nombre de la funcion: Tope
        // Proposito: Retorna el objeto Persona con la edad minima sin removerlo de la cola
        public Persona Tope()
        {
            return EstaVacia() ? pNull : items[0];
        }

        // Nombre de la funcion: Imprimir
        // Proposito: Imprime los elementos de la cola
        public void Imprimir()
        {
            for (int i = 0; i < Index; i++)
                Console.WriteLine(items[i]);
        }

        // Nombre de la funcion: Contar
        // Proposito: Retorna el numero de elementos que existe en la cola
        public int Contar()
        {
            return Index;
        }

        // Nombre de la funcion: OrdenarInsercion
        // Proposito: Ordena el arreglo mediante la tecnica del ordenamiento por insercion
        private void OrdenarInsercion()
        {
            Persona anterior;
            Persona actual;
            for (int i = 0; i < items.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    anterior = items[j - 1];
                    actual = items[j];
                    if (anterior.Edad > actual.Edad)
                    {
                        Persona temp = items[j - 1];
                        items[j - 1] = items[j];
                        items[j] = temp;
                    }
                }
            }
        }
    }

    // Definicion de la clase Persona
    class Persona
    {
        // Variables de instancia
        private string nombre;
        private short edad;
        private const string NOMBRE_DEFAULT = "sin_nombre";
        private const short EDAD_DEFAULT = -1;

        // Constructores sobrecargados. Aquellos constructores que reciben menos de 2 parametros hacen referencia al constructor que recibe 2 parametros
        // a traves de la palabra reservada <<this>>
        public Persona(string elNombre, short laEdad)
        {
            Nombre = elNombre;
            Edad = laEdad;
        }
        public Persona(string elNombre) : this(elNombre, EDAD_DEFAULT) { }
        public Persona() : this(NOMBRE_DEFAULT, EDAD_DEFAULT) { }

        // Propiedades getters y setters
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
        public short Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }

        // Nombre de la funcion: ToString
        // Proposito: Imprime los atributos propios del objeto. Se redefinio el metodo ToString mediante el uso de la palabra reservada <<override>>
        public override string ToString()
        {
            return String.Format("{0,-10} {1,-2} años.", Nombre, Edad);
        }
    }

}
