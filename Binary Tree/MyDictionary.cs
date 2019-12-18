using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree
{
    class MyDictionary<K, V> where K : IComparable where V : IComparable
    {
        private Node root;
        public MyDictionary()
        {
            root = null;
        }
        public int count
        {
            get
            {
                if(root!= null)
                {
                    return Count(root);
                }
                return 0;
            }
        }
        public int depth
        {
            get
            {
                if (root != null)
                {
                    return Depth(root);
                }
                return -1;
            }
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
            if (root.key.CompareTo(newroute.key) > 0)                   //left
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
            else                                                        //right
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
            string temp = "";
            if (root != null)
            {
                temp = ToString2(root);
            }
            return temp;
            
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
        private int Count(Node temp)
        {
            int count = 1;
            if (temp.left != null)
            {
                count += Count(temp.left);

            }
            
            if (temp.right != null)
            {
                count += Count(temp.right);

            }
            return count;
        }
        public V Min(Node temp)
        {
            V min = temp.left.value;
            while(temp.left != null)
            {
                min = temp.left.value;

            }
            return min;
        }
        public V Max(Node temp)
        {
            V max =temp.right.value;
            while (temp.right != null)
            {
                max = temp.right.value;

            }
            return max;
        }
        public int Depth(Node temp)
        {

        }
        public void Delete(V value)
        {
            //https://www.geeksforgeeks.org/binary-search-tree-set-2-delete/
        }
    }
}
