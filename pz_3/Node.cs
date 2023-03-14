using System;
using System.Collections.Generic;
using System.Text;

namespace pz_3
{
    internal class Node
    {
        public string Info { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node() { }
        public Node(string info) { Info = info; }
        public Node(string info, Node left, Node right)
        {
            Info = info;
            Left = left;
            Right = right;
        }
    }
}