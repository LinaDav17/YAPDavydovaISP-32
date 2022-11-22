using System;

namespace ConsoleApp4
{
    class Program
    {
        static int[] Factorize(int value)
        {
            int index = 0;
            int size = 100;
            int[] multypliers = new int[size];

            int i = 1, k;

            while (i * i <= value)
            {
                if ((value % i) == 0)
                {
                    if (index >= size) Array.Resize(ref multypliers, multypliers.Length + size);
                    multypliers[index++] = i;

                    k = value / i;
                    if (k != i)

                        if (index >= size) Array.Resize(ref multypliers, multypliers.Length + size);
                    multypliers[index++] = k;

                }
                i++;
            }
            Array.Resize(ref multypliers, index);
            return multypliers;
        }

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int[] divs = Factorize(number);

            int k = divs.Length;

            for (int i = 0; i < k; i += 2)
            {
                if ((i + 1) < k)
                    Console.WriteLine($"{number} = {divs[i]} * {divs[i + 1]}");
                else
                    Console.WriteLine($"{number} = {divs[i]} * {divs[i]} ");
            }
        }
    }
}
