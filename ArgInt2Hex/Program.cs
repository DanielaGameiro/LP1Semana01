using System;

namespace ArgInt2Hex
{
    class Program
    {
        static void Main(string[] args)
        {
            int itemInt;
            bool condition = false;

            foreach (var item in args)
            {
                condition = int.TryParse(item, out itemInt);

                if (condition)
                {
                    Console.WriteLine(
                        $"{itemInt} -> É inteiro, valor hexadecimal: {itemInt:x}");
                }

                else
                {
                    Console.WriteLine("{0} -> Não é inteiro", item);
                }
            }
        }
    }
}
