using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = -10;
            string myStr;
            double xx = 0.12345;
            int ii = 18;

            Console.WriteLine("Hello, World!");
            Console.WriteLine(@"\nHello, World!\n");
            Console.WriteLine("\u00A9 \u2703");
            Console.WriteLine(@"\u00A9 \u2703");
            Console.WriteLine("\"This is in double quotes.\"");
            Console.WriteLine(@"""This is in double quotes.""");

            Console.WriteLine("a" + 2);
            Console.WriteLine("abc" + x);

            myStr = $"Valor de x é {x}.";
            Console.WriteLine(myStr);
            myStr = $"{x} mais {y} é igual a {x + y}.";
            Console.WriteLine(myStr);

            myStr = string.Format("Y é {1}, X é {0}.", x, y);
            Console.WriteLine(myStr);

            Console.WriteLine(@"Verbatim com x = {0}.", x);

            Console.WriteLine($"XX com duas casas decimais fica {xx:f2}.");
            Console.WriteLine($"XX em percentagem fica {xx:p1}.");

            Console.WriteLine($"II em hexadecimal fica {ii:x}.");
            Console.WriteLine($"II em moeda fica {ii:c}.");
        }
    }
}
