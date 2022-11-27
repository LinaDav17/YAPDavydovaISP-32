using System;
using System.Collections.Generic;

public class MainClass
{
    public static void Main()
    {
        String text = Console.ReadLine();
        List<char> sourceText = new List<char>(text.ToCharArray());
        List<string> encryptedText = Encrypt(sourceText);

        foreach (string symbol in encryptedText)
        {
            Console.Write(symbol + " ");
        }
    }
    private static List<string> Encrypt(List<char> sourceText)
    {
        List<string> encryptedText = new List<string>(sourceText.Count);
        List<char> sortedList = new List<char>(sourceText);
        sortedList.Sort();

        for (int i = 0; i < sortedList.Count; i++)
        {
            for (int j = 0; j < sourceText.Count; j++)
            {
                if (sortedList[i] == sourceText[j] && encryptedText.Contains(j.ToString()) == false)
                {
                    if (encryptedText.Contains(sortedList[i].ToString()) == false)
                    {
                        encryptedText.Add(sortedList[i].ToString());
                    }

                    encryptedText.Add(j.ToString());
                }
            }
        }
        return encryptedText;
    }
}
