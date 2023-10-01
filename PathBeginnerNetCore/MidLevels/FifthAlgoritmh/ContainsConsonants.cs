using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathBeginnerNetCore.MidLevels.FifthAlgoritmh
{
    public static class ContainsConsonants
    {
        public static void WriteToConsole()
        {
            Console.WriteLine("Bir cümle girin:");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');
            bool[] results = new bool[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                results[i] = ContainsConsecutiveConsonants(words[i]);
            }

            Console.WriteLine("Sonuç:");
            foreach (bool result in results)
            {
                Console.Write(result + " ");
            }
        }

        public static bool ContainsConsecutiveConsonants(string word)
        {
            for (int i = 0; i < word.Length - 1; i++)
            {
                char currentChar = word[i];
                char nextChar = word[i + 1];

                if (IsConsonant(currentChar) && IsConsonant(nextChar))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsConsonant(char c)
        {
            // İngilizce sessiz harf kontrolü
            char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            return Array.IndexOf(consonants, char.ToLower(c)) != -1;
        }
    }
}
