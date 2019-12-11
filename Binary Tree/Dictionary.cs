using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree
{
    class Dictionary<K, V>
    {
        private Node root;
        public Dictionary()
        {
            root = null;
        }
        internal class Node
        {
            public K key;
            public V value;
            public Node left;
            public Node right;

        }
        public void Add(K Key, V Value)
        {
            var newnode = new Node()
            {
                key = Key,
                value = Value,
                left = null,
                right = null
            };
            if (root == null)
            {
                root = newnode;
            }
            else
            {
                Insert(root, newnode);
            }

        }
        public void Insert(Node newroute, Node newnode)
        {
            if (root.key.Equals(newroute))
            {
                throw new System.ArgumentException("Position is larger than number of items");
            }
            if (root.key.ToString().CompareTo(newroute.ToString()) > 0) //Root Key 
            {
                if (root.left == null)
                {
                    root.left = newnode;
                }
                else
                {
                    Insert(root.left, newnode);
                }
            }
            else                                                        //Root Key > Key
            {
                if (root.right == null)
                {
                    root.right = newnode;
                }
                else
                {
                    Insert(root.right, newnode);
                }
            }
        }
        public override string ToString()
        {
            return ToString2(root);
        }
        private string ToString2(Node temp)
        {
            string result = "";
            if (temp.left != null)
            {
                result += ToString2(temp.left) + " ";
            }
            result += root.value.ToString() + " ";
            if (temp.right != null)
            {
                result += ToString2(temp.right) + " ";
            }
            return result;
        }
    }
}
