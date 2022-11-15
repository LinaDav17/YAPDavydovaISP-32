using  System;

class Tree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                string b = new String('*', j);
                Console.WriteLine(b.PadLeft(n + 3) + "*" + b);
            }
        }
    }
}
