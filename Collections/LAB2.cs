using System;
using System.Linq;

class LAB2
{
    static void Main()
    {
        Console.WriteLine("Введите числа через пробел");
        int[] Nums = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

        int IndexFirst = Array.IndexOf(Nums, 0);
        int IndexTwo = Array.LastIndexOf(Nums, 0);

        Array.Sort(Nums, IndexFirst, IndexTwo - IndexFirst);

        for (int A = IndexTwo - 1; A >= IndexFirst + 1; A--)
        {
            Console.Write(Nums[A] + " ");
        }

        Console.ReadLine();
    }
}
