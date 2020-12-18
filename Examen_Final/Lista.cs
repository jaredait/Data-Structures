/*
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Final
{
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

            Console.Write("{ ");
            while (actual != null)
            {
                actual.PrintInfoNodo();
                if(actual.siguiente != null)
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
            while(n > 0)
            {
                InsertarFinal(RemoverInicio());
                n--;
            }
        }
    }
}
*/