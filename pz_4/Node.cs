using System;
using System.Collections.Generic;
using System.Text;

namespace pz_4
{
    internal class Node
    {
        public char Info { get; set; }
        public int Key { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node() { }

        public Node(char info, int key)
        {
            Info = info; Key = key;
        }


        public Node(char info, int key, Node left, Node right)
        {
            Info = info; Key = key; Left = left; Right = right;
        }

    }
}

