using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABYAP
{
    public class Tree
    {
        public Tree(string name, int n) { Console.WriteLine(name + " " + n); }
    }
    class Prorgram
    {
        public static void Main()
        {
            var tree1 = new Tree("сосна", -6);
            var tree2 = new Tree("береза", 80);
        }
    }
}
