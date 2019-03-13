using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                          
                string input = Console.ReadLine();
                if (input == "")
                    break;
                else
                {
                    char letter = Convert.ToChar(input);
                    switch (letter)
                    {
                        case 'W':
                        case 'w':
                            Console.WriteLine("Move up");
                            break;
                        case 'S':
                        case 's':
                            Console.WriteLine("Move down");
                            break;
                        case 'A':
                        case 'a':
                            Console.WriteLine("Move left");
                            break;
                        case 'D':
                        case 'd':
                            Console.WriteLine("Move right");
                            break;
                        default:
                            Console.WriteLine("Nowhere to move");
                            break;
                    }
                
                }
            }
        }
    }
}
