using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a poem in a single line. Separate lines using semicolons.");
            string poem = Console.ReadLine();
            string replacedPoem = poem.Replace("o", "a");   //Latin letters
            string[] poemArray = replacedPoem.Split(';');
            foreach (string line in poemArray)
            {
                Console.WriteLine(line);
            }
            Console.Read();
        }
    }
}
