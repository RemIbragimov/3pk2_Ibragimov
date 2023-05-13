using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса MyOtherClass
            MyOtherClass myOtherClass = new MyOtherClass();
            myOtherClass.StringValue = "Hello, world!";

            // Создаем экземпляр класса MyClass
            MyClass myClass = new MyClass();
            myClass.IntValue = 42;
            myClass.DateValue = DateTime.Now;
            myClass.MyOtherClassValue = myOtherClass;

            // Создаем копию объекта MyClass при помощи метода Clone()
            MyClass clone = (MyClass)myClass.Clone();

            // Сравниваем объекты MyClass при помощи метода CompareTo()
            int result = myClass.CompareTo(clone);
            Console.WriteLine($"CompareTo result: {result}");

            // Проверяем, что копия объекта MyClass создана корректно
            Console.WriteLine($"Clone: {clone}");
        }
    }
}
