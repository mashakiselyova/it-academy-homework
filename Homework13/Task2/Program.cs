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
        private int _topItemPointer;
        public const int Capacity = 10;

        public Stack()
        {
            _stack = new List<T>();
            _topItemPointer = -1;
        }

        public void Push(T item)
        {
            if (_topItemPointer + 1 == Capacity)
            {
                throw new StackOverflowException();
            }
            _stack.Add(item);
            _topItemPointer++;
        }

        public T Pop()
        {
            if (_topItemPointer == -1)
            {
                throw new StackIsEmptyException();
            }
            _topItemPointer--;
            return _stack[_topItemPointer + 1];
        }

        public T Peek()
        {
            if (_topItemPointer == -1)
            {
                throw new StackIsEmptyException();
            }
            return _stack[_topItemPointer];
        }
    }
}
