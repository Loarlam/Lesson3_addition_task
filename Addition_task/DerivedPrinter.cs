using System;
using System.Collections.Generic;
using System.Text;

namespace Addition_task
{
    class DerivedPrinter : Printer
    {
        public void Print (string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
