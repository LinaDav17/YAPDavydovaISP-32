using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(new string(number.Reverse().ToArray()) + number.Max()+ number.Min());
        }
    }
}
