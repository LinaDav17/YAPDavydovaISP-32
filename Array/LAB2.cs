using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = 0;
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] == num2[i])
                    g++;
            }
            Console.WriteLine("Совпадение " + g + " элементов");
        }
    }
}
