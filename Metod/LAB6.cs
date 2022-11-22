using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Print(int am, string symb)
        {
            char[] str = symb.ToCharArray();
            string output = "";
            for (int i = 0; i < am; i++)
            {
                output += str[i];
            }
            Console.WriteLine(output);
        }

        public static void Main()
        {
            int amount = int.Parse(Console.ReadLine());
            string symbols = Console.ReadLine();
            Print(amount, symbols);
        }
    }
}
