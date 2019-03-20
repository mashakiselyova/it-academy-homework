using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            Reverse(array);
            foreach(int number in array)
            {
                Console.WriteLine(number);
            }

            Console.Read();
        }

        static void Reverse(int[] array)
        {
            int[] array2 = new int[array.Length];
            for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
            {
                array2[i] = array[j];
            }
            array2.CopyTo(array, 0);
        }
    }
}
