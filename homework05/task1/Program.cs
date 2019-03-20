using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = new int[10];
            int[] keyboardArray = new int[10];
            int[] sumArray = new int[10];
            Random randomNumber = new Random();        
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = randomNumber.Next(0, 1000);
            }
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < keyboardArray.Length; i++)
            {
                keyboardArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = randomArray[i] + keyboardArray[i];
            }

            Console.WriteLine("randomArray:");
            foreach(int number in randomArray)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("keyboardArray:");
            foreach (int number in keyboardArray)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("sumArray:");
            foreach (int number in sumArray)
            {
                Console.WriteLine(number);
            }

            Console.Read();
        }
    }
}
