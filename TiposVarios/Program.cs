using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            uint b = 5u;
            long c = 5L;
            byte d = 3;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            char copyrightSymbol = '\u00A9';
            char scissorSymbol = '\u2703';

            Console.WriteLine(copyrightSymbol);
            Console.WriteLine(scissorSymbol);
        }
    }
}
