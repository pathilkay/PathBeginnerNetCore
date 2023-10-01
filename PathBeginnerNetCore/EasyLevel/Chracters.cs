using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathBeginnerNetCore.EasyLevel
{
    public static class SwapCharacters
    {
        public static void Write()
        {
            Console.Write("Bir metin girin: ");
            string input = Console.ReadLine();

            string newText = SwapChacters(input);
            Console.WriteLine("Sonuç: " + newText);

            Console.ReadLine();
        }

        static string SwapChacters(string text)
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
