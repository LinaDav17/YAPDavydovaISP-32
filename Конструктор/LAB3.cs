using System;
using System.Linq;

public class Program
{
    public class Sequence
    {
        private int? intStart, intEnd;
        private char? charStart, charEnd;
        public Sequence(int end, int start = 0) { this.intStart = start; this.intEnd = end; }
        public Sequence(char end, char start = 'a')
        {
            this.charStart = start;
            this.charEnd = end;
        }
        public string Generate()
        {
            var result = string.Empty;
            if (intEnd.HasValue)
            {
                Enumerable.Range(intStart.Value, intEnd.Value - intStart.Value + 1).ToList().ForEach(r => result += r + " ");
            }
            else if (charEnd.HasValue)
            {
                Enumerable.Range((int)charStart.Value, (int)charEnd.Value - (int)charStart.Value + 1).ToList().ForEach(r => result += (char)r + " ");
            }
            return result;
        }
    }
    static void Main()
    {
        Sequence sequence = new Sequence(10);
        Console.WriteLine(sequence.Generate());
        sequence = new Sequence(start: 'a', end: 'z');
        Console.WriteLine(sequence.Generate());
        Console.ReadLine();
    }
}
