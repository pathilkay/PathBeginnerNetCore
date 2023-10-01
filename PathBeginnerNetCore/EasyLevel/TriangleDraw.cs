using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathBeginnerNetCore.EasyLevel
{
    public static class TriangleDraw
    {
        public static void WriteToConsole()
        {
            Console.WriteLine("Üçgenin yüksekliğini girin : ");
            int high = int.Parse(Console.ReadLine());
            Draw(high);
        }
        public static void Draw(int high)
        {
            for (int i = 0; i < high; i++) 
            {
                for (int j = 0; j < i; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
        }
    }
}
