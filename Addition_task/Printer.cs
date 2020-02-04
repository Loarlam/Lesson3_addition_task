using System;
using System.Collections.Generic;
using System.Text;

namespace Addition_task
{
    class Printer
    {
        public void Print (string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
