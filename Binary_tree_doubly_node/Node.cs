using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_tree_doubly_node
{
    class Node
    {
        // Properties
        public object Key { get; set; }
        public Node Father { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        // Constructors
        public Node(object item)
        {
            Key = item;
            LeftChild = null;
            RightChild = null;
            Father = null;
        }
        public Node() : this(null) { }

        // Methods
        // Brother. Returns the brother of the node which is sent as argument
        public static Node Brother(Node actual)
        {
            Node brother;
            Node temp = actual.Father;
            if (temp.LeftChild == actual)
                brother = temp.RightChild;
            else
                brother = temp.LeftChild;
            return brother;
        }

        // IsLeft. Returns true if the node is a left child
        public static bool IsLeft(Node actual)
        {
            Node temp = actual.Father;

            if (temp == null)
                return false;
            if (temp.LeftChild == actual)
                return true;
            return false;
        }

        // IsRight. Returns true if the node is a right child
        public static bool IsRight(Node actual)
        {
            Node temp = actual.Father;

            if (temp == null)
                return false;
            if (temp.RightChild == actual)
                return true;
            return false;
        }
    }
}
