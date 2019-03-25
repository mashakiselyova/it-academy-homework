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
            Console.WriteLine("Enter a string. Separate words with whitespaces.");
            string words = Console.ReadLine();
            Console.WriteLine("String without the longest word: " + DeleteLongestWord(words));
            Console.WriteLine("Changed string: " + SwapWords(words));
            CountLetters(words);
            Console.WriteLine("Sorted string: " + Sorting(words));
            Console.Read();
        }

        static string DeleteLongestWord(string words)
        {
            List<string> wordList = words.Split(' ').ToList();
            int maxLength = 0;
            foreach (string word in wordList)
            {
                if (word.Length > maxLength)
                    maxLength = word.Length;
            }
            int i = 0;
            while (i < wordList.Count)
            {
                if (wordList[i].Length == maxLength)
                    wordList.Remove(wordList[i]);
                else
                    i++;
            }
            return String.Join(" ", wordList);
        }

        static string SwapWords(string words)
        {
            string[] wordList = words.Split(' ');
            string[] sortedWords = new string[wordList.Length];
            wordList.CopyTo(sortedWords, 0);
            Array.Sort(sortedWords, Comparing);
            int maxLength = sortedWords[0].Length;
            int minLength = sortedWords[sortedWords.Length - 1].Length;
            int i = 0;
            int j = 0;
            string temp = "";
            while (i < wordList.Length)
            {
                if (wordList[i].Length == maxLength && wordList[j].Length == minLength)
                {
                    temp = wordList[i];
                    wordList[i] = wordList[j];
                    wordList[j] = temp;
                    i++;
                    j++;
                }
                else if (wordList[i].Length == maxLength && wordList[j].Length != minLength)
                    j++;
                else if (wordList[i].Length != maxLength && wordList[j].Length == minLength)
                    i++;
                else if (wordList[i].Length != maxLength && wordList[j].Length != minLength)
                {
                    i++;
                    j++;
                }
            }
            return String.Join(" ", wordList);
        }

        static void CountLetters(string words)
        {
            int numberOfLetters = 0;
            int numberOfPunctuations = 0;
            foreach (char symbol in words)
            {
                if (char.IsLetter(symbol))
                    numberOfLetters++;
                if (char.IsPunctuation(symbol))
                    numberOfPunctuations++;
            }
            Console.WriteLine($"The number of letters is {numberOfLetters}.\nThe number of puctuations is {numberOfPunctuations}.");
        }

        static string Sorting(string words)
        {
            string[] wordList = words.Split(' ');
            Array.Sort(wordList, Comparing);
            return String.Join(" ", wordList);
        }

        static int Comparing(string word1, string word2)
        {
            if (word1.Length == word2.Length)
                return 0;
            else if (word1.Length > word2.Length)
                return -1;
            else
                return 1;
        }
    }
}
