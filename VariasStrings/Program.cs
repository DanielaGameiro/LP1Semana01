using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(@"\nHello, World!\n");
            Console.WriteLine("\u00A9 \u2703");
            Console.WriteLine(@"\u00A9 \u2703");
            Console.WriteLine("\"This is in double quotes.\"");
            Console.WriteLine(@"""This is in double quotes.""");
        }
    }
}
