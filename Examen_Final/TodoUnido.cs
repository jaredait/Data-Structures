// NOMBRE DEL PROGRAMA: Examen final
// NOMBRE DEL ESTUDIANTE: Ampudia Jared
// CURSO: 3er nivel
// PARALELO: 1
// FECHA DE ENTREGA: 11/dic/2020
// PROPOSITO DE ULTIMA MODIFICACION: Generacion de las clases Nodo, Lista y Program
// FECHA DE ULTIMA MODIFICACION: 11/dic/2020


using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Final
{
    // Definicion de la clase program
    class Program
    {
        // Programa principal
        static void Main(string[] args)
        {
            // Instanciar el objeto tipo Lista que va a ser usado y la variable tipo entero opc que almacenara la opcion del menu
            Lista L = new Lista();
            int opc;

            // Despliegue de opciones hasta que el usuario finalice el programa
            do
            {
                // Limpieza de consola, impresion del menu y lectura de la opcion
                L.Vaciar();
                Console.Clear();
                ImprimirMenu();
                opc = Convert.ToInt32(Console.ReadLine());

                // Opciones segun el usuario ingrese opc
                switch (opc)
                {
                    // Arbol - pendiente
                    case 1:
                        Console.WriteLine("Lo siento profe no alcance a hacer este literal :(");
                        break;
                    // Duro
                    case 2:
                        Op2_DuroDriverCode(L);
                        break;
                    // Lectura
                    case 3:
                        Op3_LecturaDriverCode(L);
                        break;
                    // Finalizar el programa
                    case 0:
                        Console.WriteLine("Fin del programa. ");
                        break;
                    // Si ninguna opcion es valida
                    default:
                        Console.Write("Opcion invalida. ");
                        break;
                }
                Console.Write("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();
            } while (opc != 0);

            Console.ReadKey();
        }

        // Nombre: ImprimirMenu()
        // Proposito: desplegar por consola el menu con las opciones disponibles
        public static void ImprimirMenu()
        {
            Console.WriteLine("1. Literal a, arbol");
            Console.WriteLine("2. Literal b, lista con datos en duro");
            Console.WriteLine("3. Literal b, lista con lectura de datos");
            Console.WriteLine("0. Finalizar");
        }

        // Nombre: Op2_DuroDriverCode
        // Proposito: demostrar la funcionalidad del metodo ROTA de la clase Lista con datos en duro
        public static void Op2_DuroDriverCode(Lista L)
        {
            // Llenar la lista con objetos tipo int
            for (int i = 0; i < 7; L.InsertarFinal(i++)) ;

            // Imprimir la lista inicial
            Console.WriteLine("Lista inicial:");
            L.ImprimirNodos();
            // Imprimir la lista luego de llamar al metodo ROTA
            Console.WriteLine("\nROTA(3):");
            L.ROTA(3);
            L.ImprimirNodos();
        }

        // Nombre: Op3_LecturaDriverCode
        // Proposito: demostrar la funcionalidad del metodo ROTA de la clase Lista con datos ingresados por el usuario
        public static void Op3_LecturaDriverCode(Lista L)
        {
            // Lectura del numero de elementos de la lista
            Console.Write("Numero de elementos a ingresar:\nn = ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Llenar la lista con objetos
            for (int i = 0; i < n; i++)
            {
                Console.Write("[{0}]: ", i + 1);
                L.InsertarFinal(Console.ReadLine());
            }

            // Lectura del numero de rotaciones a aplicar a la lista
            Console.Write("Rotaciones: ");
            int r = Convert.ToInt32(Console.ReadLine());

            // Impresion de la lista original y la lista luego de aplicar el metodo ROTA
            Console.WriteLine("Lista inicial:");
            L.ImprimirNodos();
            Console.WriteLine("\nROTA({0}):", r);
            L.ROTA(r);
            L.ImprimirNodos();
        }
    }

    // Definicion de la clase Nodo
    class Nodo
    {
        // Atributos
        public Object dato; // dato contenido en el nodo
        public Nodo siguiente; // puntero al siguiente nodo

        // Metodos clase Nodo

        // Nombre: ImfoNodo
        // Proposito: retorna el objeto que almacena el nodo
        public Object InfoNodo()
        {
            return dato;
        }

        // Nombre: PrintInfoNodo();
        // Proposito: imprime la información contenida en un nodo
        public void PrintInfoNodo()
        {
            Console.Write(dato);
        }

        // Nombre: InformaSiguienteNodo
        // Proposito: devuelve dirección del siguiente nodo
        public Nodo InformaSiguienteNodo()
        {
            return siguiente;
        }

        // Nombre: AgregaSiguienteNodo
        // Proposito: agrega al nodo la dirección del siguiente nodo
        public void AgregaSiguienteNodo(Nodo nodosiguiente)
        {
            siguiente = nodosiguiente;
        }

        // Nombre: AgregarDato
        // Proposito: agrega información dentro del nodo

        public void AgregaDato(Object nuevodato)
        {
            dato = nuevodato;
        }

    }

    // Definicion de la clase Lista
    class Lista
    {
        // Atributo
        public Nodo Comienzo; //Cabecera de la lista

        // Nombre: InsertarFinal
        // Proposito: inserta un nodo al final de la lista
        public void InsertarFinal(Object dato)
        {
            if (Comienzo == null)
            {
                Comienzo = new Nodo();

                Comienzo.AgregaDato(dato);
                Comienzo.AgregaSiguienteNodo(null);
            }
            else
            {
                Nodo Añadir = new Nodo();
                Añadir.AgregaDato(dato);

                Nodo actual = Comienzo;
                while (actual.InformaSiguienteNodo() != null)
                {
                    actual = actual.InformaSiguienteNodo();
                }

                actual.AgregaSiguienteNodo(Añadir);
            }
        }

        // Nombre: RemoverInicio
        // Proposito: remover el primer nodo de la lista y retornar su dato
        public Object RemoverInicio()
        {

            if (Comienzo == null)
            {
                Console.WriteLine("La lista esta vacia. (RemoverInicio)");
                return null;
            }
            object temp = Comienzo.dato;
            Comienzo = Comienzo.siguiente;
            return temp;
        }

        // Nombre: ImprimirNodos
        // Proposito: imprime todos los nodos incluidos en la lista
        public void ImprimirNodos()
        {
            Nodo actual = Comienzo;

            Console.Write("L = { ");
            while (actual != null)
            {
                actual.PrintInfoNodo();
                if (actual.siguiente != null)
                    Console.Write(", ");
                actual = actual.InformaSiguienteNodo();
            }

            Console.Write(" }");
        }

        // Nombre: Vaciar
        // Proposito: Vacia la lista mediante la asignacion del comienzo de la lista a null
        public void Vaciar()
        {
            Comienzo = null;
        }

        // Nombre: ROTA
        // Proposito: envia el primer elemento al final de la lista tantas veces como n lo indique
        public void ROTA(int n)
        {
            while (n > 0)
            {
                InsertarFinal(RemoverInicio());
                n--;
            }
        }
    }

}
