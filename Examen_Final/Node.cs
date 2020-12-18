using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Final
{
    class Node
    {
        // Properties
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public object Key { get; set; }
        public int Etiqueta { get; set; }

        // Constructor
        public Node(object item)
        {
            Key = item;
            LeftChild = null;
            RightChild = null;
        }

    }
}
