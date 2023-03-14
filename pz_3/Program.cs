using System;

namespace pz_3
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree(6);
            Console.Write("Среднее значение: ");
            BinaryTree.AverageArif(tree.Root);
            Console.WriteLine("Больше 0: " + BinaryTree.CountPlus(tree.Root));
            Console.WriteLine("Меньше 0: " + BinaryTree.CountMinus(tree.Root));

            Console.Write("Введите число, которое нужно найти: ");
            int verification = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Столько раз встречалось ваше число: " + BinaryTree.Countverification(tree.Root, verification));

        }
    }
}
