// NOMBRE DEL PROGRAMA: Implementacion de Clae Lista Simplemente Ligada
// NOMBRE DEL ESTUDIANTE: Ampudia Jared
// CURSO: 3er nivel
// PARALELO: 1
// FECHA DE ENTREGA: 14/oct/2020
// PROPOSITO DE ULTIMA MODIFICACION:  Implementacion de metodos retirar comienzo y retirar final de la lista
// FECHA DE ULTIMA MODIFICACION: 14/oct/2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSE
{
    //clase que define el nodo de la lista
    public class ListaSimple
    {
        public Object dato; // dato contenido en el nodo
        public ListaSimple siguiente; // puntero al siguiente nodo
        public ListaSimple comienzo; //Cabecera de la lista


        // Nombre: InsertarComienzo
        // Proposito: Insertar un nuevo elemento al inicio de la lista (un nuevo nodo)
        public void InsertarComienzo(Object dato)
        {
            ListaSimple Nodo = new ListaSimple();

            Nodo.dato = dato;
            Nodo.siguiente = comienzo;
            comienzo = Nodo;
        }

        // Nombre: InsertarFinal
        // Proposito: Insertar un nuevo al final de la lista (un nuevo nodo)
        public void InsertarFinal(Object dato)
        {

            if (comienzo == null)
            {
                comienzo = new ListaSimple();

                comienzo.dato = dato;
                comienzo.siguiente = null;
            }
            else
            {
                ListaSimple añadir = new ListaSimple();
                añadir.dato = dato;

                ListaSimple actual = comienzo;
                while (actual.siguiente != null)
                {
                    actual = actual.siguiente;
                }

                actual.siguiente = añadir;
            }
        }

        // Nombre: imprimeTodosLosNodos
        // Proposito: imprime por consola todos los elementos contenidos en la lista
        public void imprimeTodosLosNodos()
        {
            Console.WriteLine("Imprime:");

            ListaSimple actual = comienzo;
            while (actual != null)
            {
                Console.WriteLine(actual.dato);
                actual = actual.siguiente;
            }
        }

        // Nombre: RetirarComienzo
        // Proposito: Elimina el primer elemento de la lista y lo retorna al programa principal
        public Object RetirarComienzo()
        {
            if (comienzo != null)
            {
                ListaSimple retirar = comienzo;
                comienzo = retirar.siguiente;
                return retirar.dato;
            }
            else
                Console.WriteLine("Lista vacia");
            return null;

        }

        // Nombre: RetirarFinal
        // Proposito: Elimina el ultimo elemento de la lista y lo retorna al programa principal
        public Object RetirarFinal()
        {
            if(comienzo != null)
            {
                ListaSimple actual = comienzo;
                ListaSimple anterior = comienzo;

                while (actual.siguiente != null)
                {
                    anterior = actual;
                    actual = actual.siguiente;
                }
                anterior.siguiente = actual.siguiente;

                return actual.dato;
            }
            else
            {
                Console.WriteLine("Lista vacia");
                return null;
            }

        }
    }

    // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Añade al inicio:");
            ListaSimple miLista1 = new ListaSimple();

            // Intentar retirar un elemento de la lista vacia
            miLista1.RetirarComienzo();

            miLista1.InsertarComienzo("Hola");
            miLista1.InsertarComienzo("Mundo");
            miLista1.InsertarComienzo("Dato3");
            miLista1.imprimeTodosLosNodos();

            Console.WriteLine("\nDato retirado del final: {0}", miLista1.RetirarFinal());
            miLista1.imprimeTodosLosNodos();
            Console.WriteLine("\nDato retirado del inicio: {0}", miLista1.RetirarComienzo());
            miLista1.imprimeTodosLosNodos();

            Console.ReadKey();
        }
    }
}
