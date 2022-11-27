using System;
using System.Linq;

public class MainClass
{
    class MyString
    {
        public string str = string.Empty;

        public string Stroka { get => str; set => str = value; }

        public MyString() { }

        public MyString(string str) { this.Stroka = str; }
        
        public string Reverse()
        {
            if (string.IsNullOrWhiteSpace(str))
                return string.Empty;
            return string.Join("", str.Reverse());
        }
        
        public string UcFirst()
        {
            if (string.IsNullOrWhiteSpace(str))
                return string.Empty;
            return str[0].ToString().ToUpper() + str.Remove(0, 1);
        }
        
        public string UcWords()
        {
            if (string.IsNullOrWhiteSpace(str))
                return string.Empty;

            string[] words = str.Split(' ');

            for (int i = 0; i < words.Length; ++i)
            {
                words[i] = words[i][0].ToString().ToUpper() + words[i].Remove(0, 1);
            }
            return string.Join(" ", words);
        }
    }
    
    public static void Main()
    {
        var mystring = new MyString();
        mystring.str = Console.ReadLine();
        Console.WriteLine(mystring.Reverse());
        Console.WriteLine(mystring.UcFirst());
        Console.WriteLine(mystring.UcWords());
    }
}
