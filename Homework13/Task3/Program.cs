using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
            }
            Console.WriteLine(stack.RemainingCapacity());
            Console.ReadLine();
        }
    }

     public static class StackExtensions
    {
        public static int RemainingCapacity(this Stack stack)
        {
            return Stack.Capacity - stack.TopItemPointer - 1;
        }

        public static int RemainingCapacity<T>(this Stack<T> stack)
        {
            return Stack.Capacity - stack.TopItemPointer - 1;
        }
    }

}
