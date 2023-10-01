using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathBeginnerNetCore.EasyLevel
{
    public static class CalculateAverage
    {
        public static void WriteToConsole()
        {
            Console.WriteLine("Kaç fibonacci sayısının ortalaması yazılsın ? : ");
            int depth = int.Parse(Console.ReadLine());
            Calculate(depth);
        }

        public static void Calculate(int depth)
        {
            int[] fibonacci = new int[depth];
            
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            
            for (int i = 2; i < depth; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            double average = fibonacci.Sum() / fibonacci.Length;

            Console.WriteLine("[{0}]", string.Join(" - ", fibonacci));
            System.Console.WriteLine("Fibonachi dizinin ortalama ağırlığı : {0}", average);
        }
    }
}
