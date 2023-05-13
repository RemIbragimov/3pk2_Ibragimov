using System;

namespace pz_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Client client1 = new Client("Рэм");
            Client client2 = new Client("Катя");

            Product1 product1 = new Product1("Продукт1", 100, "Type1");
            Product2 product2 = new Product2("Продукт2", 200, "Brand1");
            Product3 product3 = new Product3("Продукт3", 300, "Material1");

            store.SaveOrder(product1, client1);
            store.SaveOrder(product2, client1);
            store.SaveOrder(product3, client2);

            foreach (string purchase in store.AllPurchases)
            {
                Console.WriteLine(purchase);
            }
        }
    }
}

//В данном примере переопределение методов имеет следующую полезность:

//1.Методы ToString и Equals переопределены в классе Product. Это позволяет удобно выводить информацию о товаре на экран и сравнивать товары между собой, используя их свойства. 
//2. Метод GetHashCode переопределен в классе Product, что позволяет использовать товары в качестве ключей в словарях и хеш-таблицах, обеспечивая быстрый доступ к данным. 
//3. Методы CompareTo и Compare переопределены в классе Product, что позволяет сортировать товары в списках и массивах по заданным критериям.

//Однако, в данном примере можно реализовать тот же функционал без переопределения методов. Например, для сравнения товаров можно использовать методы CompareTo и Compare из класса Comparer, который позволяет задавать критерии сортировки через лямбда-выражения.