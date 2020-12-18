// NOMBRE DEL PROGRAMA: Implementacion de lista doblemente enlazada circular
// NOMBRE DEL ESTUDIANTE: Jared Ampudia
// CURSO: 3er nivel
// PARALELO: 1
// FECHA DE ENTREGA: 26/oct/2020
// PROPOSITO DE ULTIMA MODIFICACION: Implementacion de lista doblemente enlazada circular
// FECHA DE ULTIMA MODIFICACION: 24/oct/2020

using System;
using System.Collections.Generic;
using System.Text;
/*
namespace LSE_3
{
    //clase que define el nodo de la lista
    public class Nodo
    {
        public Object dato; // dato contenido en el nodo
        public Nodo siguiente; // puntero al siguiente nodo
        public Nodo anterior;

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

        //devuelve dirección del anterior nodo
        public Nodo InformaAnteriorNodo()
        {
            return anterior;
        }

        //agrega al nodo la dirección del siguiente nodo
        public void AgregaSiguienteNodo(Nodo nodosiguiente)
        {
            siguiente = nodosiguiente;
        }

        //agrega al nodo la dirección del siguiente nodo
        public void AgregaAnteriorNodo(Nodo nodoAnterior)
        {
            anterior = nodoAnterior;
        }

        //agrega información dentro del nodo
        public void AgregaDato(Object nuevodato)
        {
            dato = nuevodato;
        }
    }
    
    // Definicion de la lista doblemente enlazada circular
    class ListaDobleCircular
    {
        public Nodo comienzo;
        private uint contar;

        // Insertar un nuevo nodo al final
        public void InsertarFinal(Object nuevoDato)
        {
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.AgregaDato(nuevoDato);
            if (comienzo == null)
            {
                comienzo = nuevoNodo;
                nuevoNodo.AgregaSiguienteNodo(nuevoNodo);
                nuevoNodo.AgregaAnteriorNodo(nuevoNodo);
            }
            else
            {
                Nodo ultimo = comienzo;
                while (ultimo.InformaSiguienteNodo() != comienzo)             // desplazarse hasta el ultimo nodo
                {
                    ultimo = ultimo.InformaSiguienteNodo();
                }
                ultimo.AgregaSiguienteNodo(nuevoNodo);
                nuevoNodo.AgregaSiguienteNodo(comienzo);
                nuevoNodo.AgregaAnteriorNodo(ultimo);
                comienzo.AgregaAnteriorNodo(nuevoNodo);
            }
            contar++;
        }

        // Imprimir lista de forma FIFO
        public void ImprimirComienzoAFin()
        {
            if (comienzo == null)
                Console.WriteLine("La lista esta vacia. (ImprimirComienzoAFin)");
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

        // Imprimir lista de forma LIFO
        public void ImprimirFinAComienzo()
        {
            if (comienzo == null)
                Console.WriteLine("La lista esta vacia. (ImprimirComienzoAFin)");
            else
            {
                Nodo porImprimir = comienzo.InformaAnteriorNodo();

                while(porImprimir != comienzo)
                {
                    porImprimir.PrintInfoNodo();
                    porImprimir = porImprimir.InformaAnteriorNodo();
                }
                porImprimir.PrintInfoNodo();
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
                comienzo.AgregaAnteriorNodo(ultimoNodo);
            }
            contar--;
            return dato;
        }

        // Remover el ultimo nodo de la lista y retornar su dato
        public Object RemoverFinal()
        {
            if (comienzo == null)
            {
                Console.WriteLine("La lista esta vacia. (RemoverFinal)");
                return null;
            }

            Nodo ultimoNodo = GetUltimoNodo();
            Nodo penultimoNodo = comienzo;
            Object dato = ultimoNodo.InfoNodo();

            // Si es que hay un unico nodo en la lista
            if (penultimoNodo == ultimoNodo)
                comienzo = null;
            else
            {
                while (penultimoNodo.InformaSiguienteNodo() != ultimoNodo)
                    penultimoNodo = penultimoNodo.InformaSiguienteNodo();

                penultimoNodo.AgregaSiguienteNodo(comienzo);
                comienzo.AgregaAnteriorNodo(penultimoNodo);
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

        // imprimir desde un nodo en especifico
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

                    for (uint i = 1; i < inicio; i++)                           // posicionarse en el nodo indicado por el usuario
                        porImprimir = porImprimir.InformaSiguienteNodo();

                    Nodo anterior = porImprimir.InformaAnteriorNodo();
                    Nodo siguiente = porImprimir.InformaSiguienteNodo();

                    Console.Write("Actual: \t");
                    porImprimir.PrintInfoNodo();
                    Console.Write("Siguiente: \t");
                    siguiente.PrintInfoNodo();
                    Console.Write("Anterior: \t");
                    anterior.PrintInfoNodo();
                }
            }
        }

        // Retornar el numero de nodos que contiene la lista
        public uint Contar()
        {
            return contar;
        }
    }

    //programa principal
    class Program
    {
        static void Main(string[] args)
        {
            ListaDobleCircular lista = new ListaDobleCircular();

            lista.InsertarFinal('a');
            lista.InsertarFinal('b');
            lista.InsertarFinal('c');
            lista.InsertarFinal('d');
            lista.InsertarFinal('e');
            lista.InsertarFinal('f');
            lista.InsertarFinal('g');

            Console.WriteLine("Imprimir de fin a comienzo:");
            lista.ImprimirFinAComienzo();
            
            Console.WriteLine("RemoverInicio: {0}", lista.RemoverInicio());
            Console.WriteLine("Imprimir de comienzo a fin:");
            lista.ImprimirComienzoAFin();
            
            Console.WriteLine("RemoverFinal: {0}", lista.RemoverFinal());
            Console.WriteLine("Imprimir de comienzo a fin:");
            lista.ImprimirComienzoAFin();

            Console.Write("\nLa lista tiene {0} nodos.\nIngresa el numero de nodo que deseas imprmir: ", lista.Contar());
            uint desde = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("\nContenido (imprimir actual, anterior y siguiente):");
            lista.ImprimirDesde(desde);

            Console.WriteLine("fin del programa");
        }
    }
}
*/