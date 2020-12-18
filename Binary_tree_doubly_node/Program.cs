using System;

namespace Binary_tree_doubly_node
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            for (int i = 0; i < 7; tree.Insert(i++)) ;
        }
    }
}
