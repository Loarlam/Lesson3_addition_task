/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создайте класс Printer.  
В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.  
Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов, выводились разными цветами.  
Обязательно используйте приведение типов
 */
using System;

namespace Addition_task
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DerivedPrinter instance1 = new DerivedPrinter(ConsoleColor.Blue);
            instance1.Print("Hi");
            Console.WriteLine($"Хэш-код первого экземпляра = {instance1.GetHashCode()}");

            DerivedPrinter instance2 = new DerivedPrinter(ConsoleColor.Green);
            instance2.Print("Hi");
            Console.WriteLine($"Хэш-код первого экземпляра = {instance2.GetHashCode()}");

            Printer newInstance = instance2 as Printer;
            newInstance.Print("Qq");
            Console.WriteLine($"Хэш-код второго экземпляра = {newInstance.GetHashCode()}");

            Console.ReadKey();
        }
    }
}
