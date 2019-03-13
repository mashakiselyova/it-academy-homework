using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char i = 'Z'; i >= 'A'; i--)
            {
                Console.Write(i);
            }
            for (char i = 'z'; i >= 'a'; i--)
            {
                Console.Write(i);
            }

            Console.Read();
        }
    }
}
