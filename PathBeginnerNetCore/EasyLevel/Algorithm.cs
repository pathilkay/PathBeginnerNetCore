using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathBeginnerNetCore.EasyLevel
{
    public static class Algoritm
    {
        public static void Write()
        {
            Console.Write("Bir metin ve bir indeks (örneğin, 'metin,indeks' şeklinde) girin: ");
            string input = Console.ReadLine();

            string[] inputParts = input.Split(',');

            if (inputParts.Length != 2)
            {
                Console.WriteLine("Geçersiz giriş formatı. Lütfen 'metin,indeks' formatını kullanın.");
            }
            else
            {
                string text = inputParts[0].Trim();
                int index;

                if (int.TryParse(inputParts[1].Trim(), out index))
                {
                    if (index >= 0 && index < text.Length)
                    {
                        string newText = text.Remove(index, 1);
                        Console.WriteLine(newText);
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz indeks. Metin uzunluğunu aşmamalıdır.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz indeks. Bir tam sayı giriniz.");
                }
            }

            Console.ReadLine();
        }
    }
}
