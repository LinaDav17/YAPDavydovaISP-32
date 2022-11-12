using System;
using System.Linq;

namespace LAB2YAP
{
    class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            double[] n = s.Split(' ').Select(t => double.Parse(t)).ToArray();
            double x = double.Parse(Console.ReadLine());

            double[] m = n.Where(t => (int)t % 2 == 0).ToArray();
            foreach (double l in m)
            {
                Console.Write(l + " ");
            }
            Console.WriteLine();
            double[] d = n.Where(t => t > x && (int)t % 2 != 0).ToArray();
            foreach(double l in d)
            {
                Console.Write(l + " ");
            }
            Console.WriteLine();
        }
    }
}
