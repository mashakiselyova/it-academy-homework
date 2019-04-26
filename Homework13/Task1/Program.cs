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
            var stack = new Stack();
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
    
    public class Stack
    {
        private object[] _stack;
        private int _topItemPointer;
        public const int Capacity = 10;

        public Stack()
        {
            _stack = new object[Capacity];
            _topItemPointer = -1;
        }

        public void Push(object item)
        {
            if (_topItemPointer + 1 == Capacity)
            {
                throw new StackOverflowException();
            }
            _stack[++_topItemPointer] = item;
        }

        public object Pop()
        {
            if (_topItemPointer == -1)
            {
                throw new StackIsEmptyException();
            }
            _topItemPointer--;
            return _stack[_topItemPointer + 1];
        }

        public object Peek()
        {
            if (_topItemPointer == -1)
            {
                throw new StackIsEmptyException();
            }
            return _stack[_topItemPointer];
        }
    }

    public class StackIsEmptyException : Exception
    {
    }
}
