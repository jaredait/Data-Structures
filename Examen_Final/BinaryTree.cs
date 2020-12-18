using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Final
{
    class BinaryTree
    {
        // Properties
        public Node Root { get; set; }
        public int Indice { get; set; }

        // Constructors
        public BinaryTree(object item)
        {
            Root.Key = item;
            Indice = 0;
        }
        public BinaryTree()
        {
            Root = null;
            Indice = 0;
        }

        // SETNODE (overloaded method). Places the nodes so that a binary search could be used to search for a value
        public void SetNode(int key)
        {
            Root = SetNode(key, Root);
        }
        private Node SetNode(int key, Node temp)
        {
            // Base case
            if (temp == null)
            {
                temp = new Node(key);
                temp.Etiqueta = Indice;
                Indice++;
            }
            // Recursive case
            else
            {
                if (key < (int)temp.Key)
                    temp.LeftChild = SetNode(key, temp.LeftChild);
                else
                    temp.RightChild = SetNode(key, temp.RightChild);
            }
            return temp;
        }

        // PRINT. (overloaded) Prints the tree using recursion
        public void Print()
        {
            Print(Root, 4);
        }
        private void Print(Node p, int padding)
        {
            if (p != null)
            {
                if (p.RightChild != null)
                    Print(p.RightChild, padding + 4);

                if (padding > 0)
                    Console.Write(" ".PadLeft(padding));

                if (p.RightChild != null)
                {
                    Console.Write("/\n");
                    Console.Write(" ".PadLeft(padding));
                }
                Console.Write(p.Key.ToString() + "\n ");
                if (p.LeftChild != null)
                {
                    Console.Write(" ".PadLeft(padding) + "\\\n");
                    Print(p.LeftChild, padding + 4);
                }
            }
        }

        public int Contains(int num)
        {
            return Contains(Root, 0);
        }
        private int Contains(Node temp, int MAX)
        {
            // Base cases
            if (temp == null)
                return MAX;
            else
            {
                if (temp.Etiqueta % 2 == 0)
                    MAX += temp.Etiqueta;
            }
            return Contains(temp, MAX);

        }
    }
