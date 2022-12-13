using System;
using System.Linq;

namespace ConsoleApp3
{
    class Vasya
    {
        public string name = "Василий";
        public int age;

        public Vasya(string name_, int age)
        {
            Name = name_;
            Age = age;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value != "Василий")
                {
                    name = $"Я не {value}, а Василий!";
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0) age = 0;
                else if (value > 122) age = 122;
                else age = value;
            }
        }
    }
   class Surprise
    {
        public static void RunMe() { }
    }
    class Program
    {
        static void Main()
        {
            Vasya person = new Vasya("Максим", 123);

            string personName = person.Name;
            int personAge = person.Age;

            Console.WriteLine(personName);

            if (personAge <= 0 || personAge >= 5 && personAge !=122)
                Console.WriteLine($"Мне {personAge} лет");
            if (personAge == 1)
                Console.WriteLine($"Мне {personAge} год");
            else
                Console.WriteLine($"Мне {personAge} годa");

            Surprise.RunMe();
        }
    }
}
