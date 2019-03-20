using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("Enter 4 numbers:");
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Enter a number:");
            int newNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an index of the array (count from 0):");
            int index = Convert.ToInt32(Console.ReadLine());

            for (int i = array.Length - 1; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = newNumber;

            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.Read();
        }
    }
}
