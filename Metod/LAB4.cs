using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        private static void PrintEven(List<int> numbers)
        {
            for (var i = 0; i < numbers.Count; i+=2)
            {
                 Console.Write(numbers[i] + " ");         
            }
        }

        private static List<int> GetMultiple(int startValue, int endValue)
        {
            List<int> nums = new List<int>();
            for(int i =startValue; i<=endValue; i++)
            {
                if (i % 7 == 0)
                {
                    nums.Add(i);
                }
            }
            return nums;
        }
        public static void Main()
        {
            int startValue = int.Parse(Console.ReadLine());
            int endValue = int.Parse(Console.ReadLine());

            PrintEven(GetMultiple(startValue, endValue));
        }

    }
}
