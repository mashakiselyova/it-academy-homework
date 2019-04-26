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
            var stack = new Stack<int>();
            for (int i = 0; i < Stack.Capacity; i++)
            {
                try
                {
                    stack.Push(i);
                }
                catch (StackOverflowException e)
                {
                    Console.WriteLine("Stack overflow occured.");
                }
            }
            for (int i = 0; i < Stack.Capacity; i++)
            {
                try
                {
                    Console.WriteLine(stack.Peek());
                    Console.WriteLine(stack.Pop());
                }
                catch
                {
                    Console.WriteLine("Stack is empty.");
                }
            }
            Console.ReadLine();
        }
    }
    
    public class Stack<T>
    {
        private List<T> _stack;
        public int TopItemPointer { get; private set; }
        public const int Capacity = 10;

        public Stack()
        {
            _stack = new List<T>();
            TopItemPointer = -1;
        }

        public void Push(T item)
        {
            if (TopItemPointer + 1 == Capacity)
            {
                throw new StackOverflowException();
            }
            _stack.Add(item);
            TopItemPointer++;
        }

        public T Pop()
        {
            if (TopItemPointer == -1)
            {
                throw new StackIsEmptyException();
            }
            TopItemPointer--;
            return _stack[TopItemPointer + 1];
        }

        public T Peek()
        {
            if (TopItemPointer == -1)
            {
                throw new StackIsEmptyException();
            }
            return _stack[TopItemPointer];
        }
    }
}
