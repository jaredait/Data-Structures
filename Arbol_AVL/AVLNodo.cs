using System;
using System.Collections.Generic;
using System.Text;

namespace Arbol_AVL
{
    // Definicion de la clase Nodo
    public class AVLNodo<E>
    {
        // Atributos
        private AVLNodo<E> izquierdo;
        private AVLNodo<E> derecho;
        private E item;
        private int balance;

        // Propiedades de los atributos
        public virtual E Item
        {
            get { return this.item; }
            set { this.item = value; }
        }
        public virtual AVLNodo<E> Izquierdo
        {
            get { return this.izquierdo; }
            set { this.izquierdo = value; }
        }        
        public virtual AVLNodo<E> Derecho
        {
            get { return this.derecho; }
            set { this.derecho = value; }
        }
        public virtual int Balance
        {
            get { return balance; }
            set { this.balance = value; }
        }

        // Constructor
        public AVLNodo(E item = default(E), AVLNodo<E> left = null, AVLNodo<E> right = null)
        {
            this.Item = item;
            this.Izquierdo = left;
            this.Derecho = right;
        }

        // Imprimir el contenido que tiene el nodo
        public virtual void Visitar()
        {
            Console.Write("{0} ", this.Item.ToString());
        }
    }
}
