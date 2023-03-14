using System;

namespace pz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] A = new bool[4, 4]
            {
                {false, true, false, true},
                {true, false, false, false},
                {true, true, false, true},
                {false, true, false, false}
            };

            Graph graph = new Graph(4, A);

            graph.Depth(1);
        }
        public class Graph
        {
            public int Size { get; set; } // Вершины
            public bool[,] Adjacency { get; set; }// Матрица
            public bool[] Vector { get; set; }// Вектор

            public Graph(int size, bool[,] B) // Конструктор
            {
                Adjacency = new bool[size, size]; // Инициализация матрицы
                Adjacency = B;
                Vector = new bool[size];
                for (int i = 0; i < size; i++)
                    Vector[i] = false; // Инициализация вектора
                Size = size;
            }
            public void Depth(int i) //i Начало (Вершина)
            {
                Vector[i] = true;
                Console.Write("{0}" + ' ', i);
                for (int k = 0; k < Size; k++) // Поиск первой 
                    if (Adjacency[i, k] && !(Vector[k]))
                        Depth(k); // Переход к k
            }

        }
    }
}
