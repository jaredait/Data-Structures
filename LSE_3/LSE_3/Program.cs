// NOMBRE DEL PROGRAMA: Implementacion de lista circular
// NOMBRE DEL ESTUDIANTE: Jared Ampudia
// CURSO: 3er nivel
// PARALELO: 1
// FECHA DE ENTREGA: 26/oct/2020
// PROPOSITO DE ULTIMA MODIFICACION: Implementacion de lista simplemente enlazada circular
// FECHA DE ULTIMA MODIFICACION: 24/oct/2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LSE_3
{
    //clase que define el nodo de la lista
    public class Nodo
    {
        public Object dato; // dato contenido en el nodo
        public Nodo siguiente; // puntero al siguiente nodo

        // Retorna el objeto que almacena el nodo
        public Object InfoNodo()
        {
            return dato;
        }

        //imprime la información contenida en un nodo
        public void PrintInfoNodo()
        {
            Console.WriteLine(dato);
        }

        //devuelve dirección del siguiente nodo
        public Nodo InformaSiguienteNodo()
        {
            return siguiente;
        }

        //agrega al nodo la dirección del siguiente nodo
        public void AgregaSiguienteNodo(Nodo nodosiguiente)
        {
            siguiente = nodosiguiente;
        }

        //agrega información dentro del nodo
        public void AgregaDato(Object nuevodato)
        {
            dato = nuevodato;
        }
    }

    public class ListaSimpleCirular
    {
        public Nodo comienzo;
        private uint contar;

        // Insertar al final un nuevo nodo
        public void InsertarFinal(Object nuevoDato)
        {
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.AgregaDato(nuevoDato);
            if (comienzo == null)
            {
                comienzo = nuevoNodo;
                nuevoNodo.AgregaSiguienteNodo(nuevoNodo);
            }
            else
            {
                Nodo temporal = comienzo;
                while(temporal.InformaSiguienteNodo() != comienzo)
                {
                    temporal = temporal.InformaSiguienteNodo();
                }
                temporal.AgregaSiguienteNodo(nuevoNodo);
                nuevoNodo.AgregaSiguienteNodo(comienzo);
            }
            contar++;
        }

        // Imprimir lista de forma FIFO
        public void ImprimirLista()
        {
            if (comienzo == null)
                Console.WriteLine("La lista esta vacia. (ImprimirLista)");
            else
            {
                Nodo porImprimir = comienzo;

                while (porImprimir.InformaSiguienteNodo() != comienzo)
                {
                    porImprimir.PrintInfoNodo();
                    porImprimir = porImprimir.InformaSiguienteNodo();
                }
                porImprimir.PrintInfoNodo();                // Si es que hay mas de un nodo, imprime el dato del ultimo nodo de la lista,
                                                            // si solo hay un nodo,imprime el unico elemento, pues el bucle while no se efectua.
            }
        }

        // Remover el primer nodo de la lista y retornar su dato
        public Object RemoverInicio()
        {

            if (comienzo == null)
            {
                Console.WriteLine("La lista esta vacia. (RemoverInicio)");
                return null;
            }

            Object dato;

            if (comienzo == comienzo.InformaSiguienteNodo())
            {
                dato = comienzo.InfoNodo();
                comienzo = null;
            }
            else
            {
                Nodo ultimoNodo = comienzo;
                dato = comienzo.InfoNodo();

                // Llegar al ultimo nodo 
                while (ultimoNodo.InformaSiguienteNodo() != comienzo)
                    ultimoNodo = ultimoNodo.InformaSiguienteNodo();

                comienzo = comienzo.InformaSiguienteNodo();
                ultimoNodo.AgregaSiguienteNodo(comienzo);
            }
            contar--;
            return dato;
        }

        // Remover el ultimo nodo de la lista y retornar su dato
        public Object RemoverFinal()
        {
            if(comienzo == null)
            {
                Console.WriteLine("La lista esta vacia. (RemoverFinal)");
                return null;
            }

            Nodo ultimoNodo = GetUltimoNodo();
            Nodo penultimoNodo = comienzo;
            Object dato = ultimoNodo.InfoNodo();

            if (penultimoNodo == ultimoNodo)
                comienzo = null;
            else
            {
                while (penultimoNodo.InformaSiguienteNodo() != ultimoNodo)
                    penultimoNodo = penultimoNodo.InformaSiguienteNodo();

                penultimoNodo.AgregaSiguienteNodo(comienzo);
            }
            contar--;
            return dato;
        }

        // Obtener el ultimo nodo de la lista
        internal Nodo GetUltimoNodo()
        {
            if (comienzo == null)
                return null;
            else
            {
                Nodo ultimoNodo = comienzo;
                while (ultimoNodo.InformaSiguienteNodo() != comienzo)
                    ultimoNodo = ultimoNodo.InformaSiguienteNodo();
                return ultimoNodo;
            }
        }

        // imprimir la lista desde un nodo en especifico (el numero de nodo tiene que ser ingresado por el usuario).
        public void ImprimirDesde(uint inicio)
        {
            if (comienzo == null)
                Console.WriteLine("La lista esta vacia. (ImprimirLista)");
            else
            {
                if (inicio > contar)
                    Console.WriteLine("Valor fuera del rango");
                else
                {
                    Nodo porImprimir = comienzo;
                    Nodo limite;

                    for (uint i = 1; i < inicio; i++)                           // posicionarse en el nodo indicado por el usuario
                        porImprimir = porImprimir.InformaSiguienteNodo();

                    limite = porImprimir;

                    while (porImprimir.InformaSiguienteNodo() != limite)
                    {
                        porImprimir.PrintInfoNodo();
                        porImprimir = porImprimir.InformaSiguienteNodo();
                    }
                    porImprimir.PrintInfoNodo();                // Si es que hay mas de un nodo, imprime el dato del ultimo nodo de la lista,
                                                                // si solo hay un nodo,imprime el unico elemento, pues el bucle while no se efectua.
                }
            }
        }
    }
    
    //programa principal
    class Program
    {
        static void Main(string[] args)
        {
            ListaSimpleCirular lista = new ListaSimpleCirular();
            
            lista.InsertarFinal('a');
            lista.InsertarFinal('b');
            lista.InsertarFinal('c');
            lista.InsertarFinal('d');
            lista.InsertarFinal('e');
            lista.InsertarFinal('f');

            Console.WriteLine("Contenido:");
            lista.ImprimirLista();

            Console.WriteLine("RemoverInicio: {0}", lista.RemoverInicio());
            Console.WriteLine("Contenido:");
            lista.ImprimirLista();

            Console.WriteLine("RemoverFinal: {0}", lista.RemoverFinal());
            Console.WriteLine("Contenido:");
            lista.ImprimirLista();

            uint desde;
            Console.Write("Ingresa el numero de nodo para empezar a imprimir: ");
            desde = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Contenido (imprimir circularmente):");
            lista.ImprimirDesde(desde);


            Console.WriteLine("fin del programa");
        }
    }
}