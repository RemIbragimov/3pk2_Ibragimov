using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace pz_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            int[] array = new int[10000];//Массив с данными 10000

            List<int> list = new List<int>();//Список данных

            Hashtable hash = new Hashtable();//Хэш-Таблица


            for (int i = 0; i < array.Length; i++)
            {
                int random = rand.Next(1, 1000);
                hash.Add(i, random);
                array[i] = random;
                list.Add(random);

            }


            Stopwatch stopWatch = new Stopwatch();

            Console.WriteLine($"Число,которое будем искать:");
            int target = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Прямой способ");
            Console.WriteLine();

            Console.WriteLine($"Ищем число {target} в массиве");

            stopWatch.Start();

            int index = 0;//Индекс для пробежки в цикле

            while (index < array.Length && array[index] != target)//Проверка на выход массива за границу
            {
                index++;
                if (index < array.Length)
                {
                    Console.WriteLine($"Найдено {target} число ");
                    break;
                }
                else
                {
                    Console.WriteLine($"Число {target} не найдено");
                    break;
                }
            }

            stopWatch.Stop();
            Console.WriteLine($"Stopwatch: {stopWatch.Elapsed}");

            Console.WriteLine($"Ищем число {target} в списке");
            stopWatch.Reset();
            stopWatch.Start();

            index = 0;
            while (index < list.Count && list[index] != target)
            {
                index++;
                if (index < list.Count)
                {
                    Console.WriteLine($"Найдено {target} число");
                    break;
                }
                else
                {
                    Console.WriteLine($"Число {target} не найдено");
                    break;
                }
            }

            stopWatch.Stop();
            Console.WriteLine($"Stopwatch: {stopWatch.Elapsed}");

            Console.WriteLine($"Ищем число {target} в хэш таблице");
            stopWatch.Reset();
            stopWatch.Start();

            index = 0;
            while (index < hash.Count && Convert.ToInt32(hash[index]) != target)
            {
                index++;
                if (index < hash.Count)
                {
                    Console.WriteLine($"Найдено {target} число");
                    break;
                }
                else
                {
                    Console.WriteLine($"Число {target} не найдено");
                    break;
                }
            }

            stopWatch.Stop();
            Console.WriteLine($"Stopwatch: {stopWatch.Elapsed}");

            Console.WriteLine();
            Console.WriteLine("Бинарный поиск");
            Console.WriteLine();

            Console.WriteLine($"Ищем число {target} в массиве");
            stopWatch.Reset();
            stopWatch.Start();

            int middle, left = 0, right = array.Length - 1;
            middle = (left + right) / 2;
            if (target > array.Length)
                left = middle + 1;
            else
                right = middle - 1;
            while ((array[middle] != target) && (left <= right))
            {
                if (array[middle] == target)
                {
                    Console.WriteLine($"Найдено {target} Число");
                    break;
                }
                else
                {
                    Console.WriteLine($"Число {target} не найдено");
                    break;
                }
            }

            stopWatch.Stop();
            Console.WriteLine($"Stopwatch: {stopWatch.Elapsed}");

            Console.WriteLine($"Ищем число {target} в списке");
            stopWatch.Reset();
            stopWatch.Start();

            left = 0;
            right = list.Count - 1;
            middle = (left + right) / 2;
            if (target > list.Count)
                left = middle + 1;
            else
                right = middle - 1;
            while ((list[middle] != target) && (left <= right))
            {
                if (list[middle] == target)
                {
                    Console.WriteLine($"Найдено {target} число");
                    break;
                }
                else
                {
                    Console.WriteLine($"Число {target} не найдено");
                    break;
                }
            }

            stopWatch.Stop();
            Console.WriteLine($"Stopwatch: {stopWatch.Elapsed}");

            Console.WriteLine($"Ищем число {target} в массиве");
            stopWatch.Reset();
            stopWatch.Start();

            left = 0;
            right = hash.Count - 1;
            middle = (left + right) / 2;
            if (target > hash.Count)
                left = middle + 1;
            else
                right = middle - 1;
            while ((Convert.ToInt32(hash[middle]) != target) && (left <= right))
            {
                if (Convert.ToInt32(hash[middle]) == target)
                {
                    Console.WriteLine($"Найдено {target} число");
                    break;
                }
                else
                {
                    Console.WriteLine($"Число {target} не найдено");
                    break;
                }
            }

            stopWatch.Stop();
            Console.WriteLine($"Stopwatch: {stopWatch.Elapsed}");
        }
    }
}

