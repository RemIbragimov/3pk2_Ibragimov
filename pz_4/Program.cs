using System;
using System.Collections.Generic;

namespace pz_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Node root = null;
            //1
            for (int i = 0; i < 10; i++)
            {
                int key = random.Next(-1000, 1001);
                root = SearchTree.Insert(root, (char)('A' + i), key);

            }

            Console.WriteLine("Сумма значений дерева: " + SearchTree.Summa(root));

            //2
            Console.WriteLine("Кол-во внутренних узлов дерева: " + SearchTree.CountInternalNodes(root) + "");


            //3 
            List<int> negativeValues = SearchTree.GetNegativeValues(root);
            Console.WriteLine("\nОтрицательные значения информационных полей дерева:" + negativeValues.Count);
            foreach (var value in negativeValues)
            {
                Console.Write($"{value}, ");
            }
            Console.ReadLine();
        }
        //4
    }
}
