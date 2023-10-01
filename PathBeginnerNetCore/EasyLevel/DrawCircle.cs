using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathBeginnerNetCore.EasyLevel
{
    public static class DrawCircle
    {
        public static void WriteToConsole()
        {
            Console.WriteLine("Dairenin yarıçapını giriniz : ");
            double radius = Convert.ToDouble(Console.ReadLine());

            if (radius < 0)
                Console.WriteLine("Yarıçap pozitif olmalıdır");
            else
                Circle(radius);
        }

        public static void Circle(double radius)
        {
            int radiusRounding = (int)Math.Round(radius);

            int centerX = radiusRounding;
            int centerY = radiusRounding;

            for (int y = 0; y <= 2 * radiusRounding; y++)
            {
                for (int x = 0; x <= 2 * radiusRounding; x++)
                {
                    double distance = Math.Sqrt(Math.Pow(x - centerX, 2) + Math.Pow(y - centerY, 2));

                    if (Math.Abs(distance - radius) < 0.5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
