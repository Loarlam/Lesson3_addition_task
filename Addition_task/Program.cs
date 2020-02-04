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
    class Program
    {
        static void Main(string[] args)
        {
            DerivedPrinter instance = new DerivedPrinter();
            instance.Print("Hi");
            Console.WriteLine($"Хэш-код первого экземпляра = {instance.GetHashCode()}");

            Printer newInstance = instance as Printer;
            newInstance.Print("Qq");
            Console.WriteLine($"Хэш-код второго экземпляра = {newInstance.GetHashCode()}");

            Console.ReadKey();
        }
    }
}
