using System;
using System.Collections.Generic;

public class LAB5
{
    public static void Main()
    {
        char[] text = Console.ReadLine().ToCharArray();
        List<char> list = new List<char>(text);

        int index = list.IndexOf(',');
        int secondWordEndIndex = list.LastIndexOf(' ') - 1;

        char[] textEnd = new char[list.Count - secondWordEndIndex - 1];

        list.RemoveAt(index);
        list.CopyTo(secondWordEndIndex, textEnd, 0, list.Count - secondWordEndIndex);
        list.RemoveRange(secondWordEndIndex, list.Count - secondWordEndIndex);

        list.Add(',');
        list.AddRange(textEnd);

        list.ForEach(Console.Write);
        Console.ReadLine();
    }
}
