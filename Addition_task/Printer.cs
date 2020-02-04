using System;

namespace Addition_task
{
    internal class Printer
    {
        readonly ConsoleColor color;

        protected Printer(ConsoleColor color)
        {
            this.color = color;
        }

        public void Print(string value)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
