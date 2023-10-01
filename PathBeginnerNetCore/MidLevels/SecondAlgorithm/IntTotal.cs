using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathBeginnerNetCore.MidLevels.SecondAlgorithm
{
    public static class IntTotal
    {
        public static void WriteToConsole()
        {
            Console.WriteLine("İkili sayıları girin (örnek: 2 3 1 5 2 5 3 3):");
            string input = Console.ReadLine();

            string[] tokens = input.Split(' ');
            List<int> numbers = tokens.Select(int.Parse).ToList();

            List<int> results = CalculateSumAndPrint(numbers);

            Console.WriteLine("Sonuç:");
            foreach (int result in results)
            {
                Console.Write(result + " ");
            }
        }
        public static List<int> CalculateSumAndPrint(List<int> numbers)
        {
            List<int> results = new List<int>();

            for (int i = 0; i < numbers.Count; i += 2)
            {
                int firstNumber = numbers[i];
                int secondNumber = numbers[i + 1];

                if (firstNumber != secondNumber)
                {
                    int sum = firstNumber + secondNumber;
                    results.Add(sum);
                }
                else
                {
                    int squareOfSum = (firstNumber + secondNumber) * (firstNumber + secondNumber);
                    results.Add(squareOfSum);
                }
            }

            return results;
        } 
    }
}
