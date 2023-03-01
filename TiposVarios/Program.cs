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

            float e = 1.234f;
            double f = 1.2345;
            decimal g = 123.45m;

            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
        }
    }
}
