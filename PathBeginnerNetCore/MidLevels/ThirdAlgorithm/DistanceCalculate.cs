using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PathBeginnerNetCore.MidLevels.ThirdAlgorithm
{
    public class DistanceCalculate
    {
        public void WriteToConsole()
        {
            Console.WriteLine("Sayıları girin (örnek: 56 45 68 77):");
            string input = Console.ReadLine();

            string[] tokens = input.Split(' ');
            int[] numbers = new int[tokens.Length];

            for (int i = 0; i < tokens.Length; i++)
            {
                numbers[i] = int.Parse(tokens[i]);
            }

            int result = CalculateAndPrint(numbers);

            Console.WriteLine("Sonuç: " + result);
        }
        public static int CalculateAndPrint(int[] numbers)
        {
            int totalDifference = 0;

            foreach (int number in numbers)
            {
                int difference = Math.Abs(67 - number);

                if (number < 67)
                {
                    totalDifference += difference;
                }
                else
                {
                    totalDifference += difference * difference; 
                }
            }

            return totalDifference;
        }
    }
}
