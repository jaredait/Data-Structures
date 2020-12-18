using System;
using System.Collections.Generic;
using System.Text;

namespace Arbol_AVL
{
    // Definicion de la clase AVLArbol
    public class AVLArbol<E> where E : IComparable
    {
        // Atributo
        private AVLNodo<E> root;

        // Propiedad del atributo
        protected virtual AVLNodo<E> Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        // Constructor
        public AVLArbol()
        {
            this.Root = null;
        }

        // Determinar si un elemento se encuentra en el arbol (sobrecargado)
        public virtual Boolean Contiene(E item)
        {
            return Contiene(this.Root, item);
        }
        protected virtual Boolean Contiene(AVLNodo<E> root, E item)
        {
            if (root == null)
            {
                return false;
            }
            if (item.CompareTo(root.Item) < 0)
            {
                return Contiene(root.Izquierdo, item);
            }
            else
            {
                if (item.CompareTo(root.Item) > 0)
                {
                    return Contiene(root.Derecho, item);
                }
            }
            return true;
        }

        // Agregar un elemento al arbol (sobrecargado)
        public virtual void Agregar(E item)
        {
            bool flag = false;
            this.Root = Agregar(this.Root, item, ref flag);
        }
        protected virtual AVLNodo<E> Agregar(AVLNodo<E> root, E item, ref bool flag)
        {
            AVLNodo<E> n1;
            // Si el árbol está vacio, simplement se agrega 
            // y se indica que cambió la altura
            if (root == null)
            {
                root = new AVLNodo<E>(item);
                flag = true;
            }
            else
            {
                // El valor del elemento a agregar es menor
                // que el valor de la raíz del subárbol a considerar
                if (item.CompareTo(root.Item) < 0)
                {
                    // Se agrega recursivamente por la izquierda
                    root.Izquierdo = Agregar(root.Izquierdo, item, ref flag);
                    if (flag) // si cambió la altura ?
                    {
                        switch (root.Balance)
                        {
                            case -1:
                                // antes izquierda < derecha, después se equilibra
                                // y cambia la bandera
                                root.Balance = 0;
                                flag = false;
                                break;
                            case 0:
                                // antes izquierda = derecha, después izquierda mas grande
                                // en algún nivel superior puede hacer falta un rebalanceo
                                // la bandera queda como estaba (true)
                                root.Balance = 1;
                                break;
                            case 1:
                                // antes izquierda > derecha, hay que rebalancear
                                n1 = root.Izquierdo;
                                if (n1.Balance == 1)
                                {
                                    // la izquierda de la izquierda es mayor
                                    // rotación simple izquierda-izquierda
                                    root = RotacionIzquierda(root, n1);
                                }
                                else
                                {
                                    // rotación doble izquierda-derecha
                                    root = RotacionIzquierdaDerecha(root, n1);
                                }
                                // subárbol ajustado cambia la bandera
                                flag = false;
                                break;
                        }
                    }
                }
                else
                {
                    // El valor del elemento a agregar es mayor
                    // que el valor de la raíz del subárbol a considerar
                    if (item.CompareTo(root.Item) > 0)
                    {
                        // Se agrega recursivamente por la derecha
                        root.Derecho = Agregar(root.Derecho, item, ref flag);
                        if (flag) // si cambió la altura ?
                        {
                            switch (root.Balance)
                            {
                                case -1:
                                    // antes izquierda < derecha, hay que rebalancer
                                    n1 = root.Derecho;
                                    if (n1.Balance == -1)
                                    {
                                        // la derecha de la derecha es mayor
                                        // rotación simple derecha-derecha
                                        root = RotacionDerecha(root, n1);
                                    }
                                    else
                                    {
                                        // rotación doble derecha-izquierda
                                        root = RotacionDerechaIzquierda(root, n1);
                                    }
                                    // subárbol ajustado cambia la bandera
                                    flag = false;
                                    break;
                                case 0:
                                    // antes izquierda = derecha, después la derecha mas grande
                                    // en algún nivel superior puede hacer falta un rebalanceo
                                    // la bandera queda como estaba (true)
                                    root.Balance = -1;
                                    break;
                                case 1:
                                    // antes izquierda > derecha, despues se equilibra
                                    // y cambia la bandera
                                    root.Balance = 0;
                                    flag = false;
                                    break;
                            }
                        }
                    }
                    else
                    {
                        // No se puede almacenar claves repetidas
                        throw new Exception("Claves repetidas");
                    }
                }
            }
            return root;
        }

        // Eliminar un elemento del arbol (sobrecargado)
        public virtual void Remover(E item)
        {
            bool flag = false;
            this.Root = Remover(this.Root, item, ref flag);
        }
        protected virtual AVLNodo<E> Remover(AVLNodo<E> root, E item, ref bool flag)
        {
            // No se puede extraer nodos de un árbol vacío
            if (root == null)
            {
                throw new Exception("No existe");
            }
            // El valor del elemento a extraer es menor
            // que el valor de la raíz del subárbol a considerar
            if (item.CompareTo(root.Item) < 0)
            {
                // Se procesa recursivamente por la izquierda
                root.Izquierdo = Remover(root.Izquierdo, item, ref flag);
                if (flag)
                {
                    // Cambió la altura, analizar el balance
                    root = BalanceIzquierdo(root, ref flag);
                }
            }
            else
            {
                // El valor del elemento a extraer es mayor 
                // que el valor de la raíz del subárbol a considerar
                if (item.CompareTo(root.Item) > 0)
                {
                    // Se procesa recursivamente por la derecha
                    root.Derecho = Remover(root.Derecho, item, ref flag);
                    if (flag)
                    {
                        // Cambió la altura, analizar el balance
                        root = BalanceDerecho(root, ref flag);
                    }
                }
                else
                { // encontrado
                    AVLNodo<E> q;
                    q = root;
                    if (q.Izquierdo == null)
                    {
                        // Un único descendiente, cambia la altura
                        root = q.Derecho;
                        flag = true;
                    }
                    else
                    {
                        if (q.Derecho == null)
                        {
                            // Un único descendiente, cambia la altura
                            root = q.Izquierdo;
                            flag = true;
                        }
                        else
                        { // tiene dos subárboles !!!
                            root.Izquierdo = Reemplazar(root, root.Izquierdo, ref flag);
                            if (flag)
                            {
                                // Cambió la altura, analizar el balance
                                root = BalanceIzquierdo(root, ref flag);
                            }
                            q = null;
                        }
                    }
                }
            }
            return root;
        }

        // Reemplaza un nodo n con el nodo act.
        protected virtual AVLNodo<E> Reemplazar(AVLNodo<E> n, AVLNodo<E> act, ref bool flag)
        {
            if (act.Derecho != null)
            {
                // hay algo a la derecha, es mayor que el actual
                act.Derecho = Reemplazar(n, act.Derecho, ref flag);
                if (flag)
                {
                    // Cambió la altura, analizar el balance
                    act = BalanceDerecho(act, ref flag);
                }
            }
            else
            {
                // act es el mayor de los menores
                // copiar el elemento y anular la referencia
                // cambia la altura
                n.Item = act.Item;
                n = act;
                act = act.Izquierdo;
                n = null;
                flag = true;
            }
            return act;
        }
        
        // Analiza las posibles rotaciones cuando se extrajo un nodo de la izquierda
        protected virtual AVLNodo<E> BalanceIzquierdo(AVLNodo<E> n, ref bool flag)
        {
            AVLNodo<E> n1;
            switch (n.Balance)
            {
                case 1:
                    // antes derecha < izquierda, después se equilibra
                    n.Balance = 0;
                    break;
                case 0:
                    // antes derecha = izquierda, despues se ajusta y cambia la altura
                    n.Balance = -1;
                    flag = false;
                    break;
                case -1:
                    // antes derecha > izquierda, hay que rebalancer
                    n1 = n.Derecho;
                    if (n1.Balance <= 0)
                    {
                        flag = false;
                        n = RotacionDerecha(n, n1);
                    }
                    else
                    {
                        n = RotacionDerechaIzquierda(n, n1);
                    }
                    break;
            }
            return n;
        }
        
        // Analiza las posibles rotaciones cuando se extrajo un nodo de la derecha 
        protected virtual AVLNodo<E> BalanceDerecho(AVLNodo<E> n, ref bool flag)
        {
            AVLNodo<E> n1;
            switch (n.Balance)
            {
                case 1:
                    // antes derecha < izquierda, hay que rebalancer
                    n1 = n.Izquierdo;
                    if (n1.Balance >= 0)
                    {
                        if (n1.Balance == 0)
                        {
                            flag = false;
                        }
                        n = RotacionIzquierda(n, n1);
                    }
                    else
                    {
                        n = RotacionIzquierdaDerecha(n, n1);
                    }
                    break;
                case 0:
                    // antes derecha = izquierda, después se ajusta y cambia la altura
                    n.Balance = 1;
                    flag = false;
                    break;
                case -1:
                    // antes derecha > izquierda, después se equilibra
                    n.Balance = 0;
                    break;
            }
            return n;
        }

        // Rotacion simple a la izquierda
        protected virtual AVLNodo<E> RotacionIzquierda(AVLNodo<E> n, AVLNodo<E> n1)
        {
            n.Izquierdo = n1.Derecho;
            n1.Derecho = n;
            if (n1.Balance == 1)
            {
                n.Balance = 0;
                n1.Balance = 0;
            }
            else
            {
                n.Balance = 1; // CUIDADO !!!
                n1.Balance = -1;
            }
            return n1;
        }
        
        // Rotacion doble izquierda - derecha
        protected virtual AVLNodo<E> RotacionIzquierdaDerecha(AVLNodo<E> n, AVLNodo<E> n1)
        {
            // Nodo a la derecha del nodo que está a la izquierda del nodo a considerar
            AVLNodo<E> n2;
            n2 = n1.Derecho;
            n.Izquierdo = n2.Derecho;
            n2.Derecho = n;
            n1.Derecho = n2.Izquierdo;
            n2.Izquierdo = n1;
            n1.Balance = (n2.Balance == -1) ? 1 : 0; // CUIDADO !!!
            n.Balance = (n2.Balance == 1) ? -1 : 0;
            n2.Balance = 0;
            return n2;
        }
        
        // Rotacion simple derecha
        protected virtual AVLNodo<E> RotacionDerecha(AVLNodo<E> n, AVLNodo<E> n1)
        {
            n.Derecho = n1.Izquierdo;
            n1.Izquierdo = n;
            if (n1.Balance == -1)
            {
                n.Balance = 0;
                n1.Balance = 0;
            }
            else
            {
                n.Balance = -1; // CUIDADO !!!
                n1.Balance = 1;
            }
            return n1;
        }
        
        // Rotacion doble derecha - izquierda
        protected virtual AVLNodo<E> RotacionDerechaIzquierda(AVLNodo<E> n, AVLNodo<E> n1)
        {
            // Nodo a la izquierda del nodo que está a la derecha del nodo a considerar
            AVLNodo<E> n2;
            n2 = n1.Izquierdo;
            n.Derecho = n2.Izquierdo;
            n2.Izquierdo = n;
            n1.Izquierdo = n2.Derecho;
            n2.Derecho = n1;
            n.Balance = (n2.Balance == -1) ? 1 : 0; // CUIDADO !!!
            n1.Balance = (n2.Balance == 1) ? -1 : 0;
            n2.Balance = 0;
            return n2;
        }

        // Immprime el arbol por consola de manera grafica (sobrecargado)
        public void Imprimir()
        {
            Print(root, 4);
        }
        private void Print(AVLNodo<E> p, int padding)
        {
            if (p != null)
            {
                if (p.Derecho != null)
                    Print(p.Derecho, padding + 4);

                if (padding > 0)
                    Console.Write(" ".PadLeft(padding));

                if (p.Derecho != null)
                {
                    Console.Write("/\n");
                    Console.Write(" ".PadLeft(padding));
                }
                Console.Write(p.Item.ToString() + "\n ");
                if (p.Izquierdo != null)
                {
                    Console.Write(" ".PadLeft(padding) + "\\\n");
                    Print(p.Izquierdo, padding + 4);
                }
            }
        }
    }
}
