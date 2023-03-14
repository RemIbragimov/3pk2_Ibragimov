using System;
using System.Collections.Generic;
using System.Text;

namespace pz_4
{
    class SearchTree
    {
        //1
        public static Node Insert(Node node, char info, int key)
        {
            if (node == null)
                return new Node(info, key);
            else if (key < node.Key)
                node.Left = Insert(node.Left, info, key);
            else
                node.Right = Insert(node.Right, info, key);
            return node;
        }

        public static int Summa(Node node)
        {
            if (node == null)
                return 0;
            return node.Key + Summa(node.Left) + Summa(node.Right);
        }
        //2
        public static int CountInternalNodes(Node node)
        {
            if (node == null)
                return 0;
            else if (node.Left == null && node.Right == null)
                return 0;
            else
                return 1 + CountInternalNodes(node.Left) + CountInternalNodes(node.Right);
        }
        //3
        public static List<int> GetNegativeValues(Node node)
        {

            List<int> result = new List<int>();
            if (node == null)
                return result;

            if (node.Key < 0)
            {
                result.Add(node.Key);
                Console.WriteLine($"Узел: {node.Info}, Кол-во отрицательный: {result.Count}: {node.Key} ");

            }
            else
            {
                Console.WriteLine($"Узел: {node.Info}, Кол-во отрицательный: {result.Count}: {node.Key} ");

            }

            result.AddRange(GetNegativeValues(node.Left));
            result.AddRange(GetNegativeValues(node.Right));

            return result;
        }
        //4

    }

}

