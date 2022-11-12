using System;

namespace LAB1YAP
{
    class Program
    {
        static void Main()
        {
                int metr = int.Parse(Console.ReadLine());

                while (metr >= 1000)
                {
                    metr = metr % 1000;
                }
                Console.WriteLine(1000 - metr);
            
        }
    }
}
