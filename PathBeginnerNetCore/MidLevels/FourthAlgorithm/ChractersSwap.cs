using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerLevelNetCore.MidLevels.FourthAlgorithm
{
    public static class ChractersSwap
    {
        public static void WriteToConsole()
        {
            Console.WriteLine("Bir şeyler yazınız : ");
            string text = Console.ReadLine();

            Console.WriteLine($"Çıktı : {SwapCharacters(text)}");
        }

        public static string SwapCharacters(string text)
        {
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] characters = words[i].ToCharArray();
                Array.Reverse(characters);
                words[i] = new string(characters);
            }
            return string.Join(" ", words);
        }
    }
}
