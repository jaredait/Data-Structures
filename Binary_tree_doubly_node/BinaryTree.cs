using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_tree_doubly_node
{
    class BinaryTree
    {
        // Properties
        public Node Root { get; private set; }

        // Constructors
        public BinaryTree()
        {
            Root = null;
        }

        // Insert. Inserts a new node in the tree using a queue
        public void Insert(object key)
        {
            
            if (Root == null)
                Root = new Node(key);
            else
            {
                Node temp = Root;
                Queue<Node> q = new Queue<Node>();
                q.Enqueue(temp);
                while(q.Count > 0)
                {
                    temp = q.Dequeue();
                    if (temp.LeftChild == null)
                    {
                        temp.LeftChild = new Node(key);
                        break;
                    }
                    else
                        q.Enqueue(temp.LeftChild);

                    if (temp.RightChild == null)
                    {
                        temp.RightChild = new Node(key);
                        break;
                    }
                    else
                        q.Enqueue(temp.RightChild);
                }
            }
        }
    }
}
