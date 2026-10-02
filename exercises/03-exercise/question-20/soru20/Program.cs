/*
Girilen bir sayının 5’in kuvveti olup olmadığını hesaplayınız.
Örnek:
125 -> 5’in kuvvetidir.
10 -> 5’in kuvveti değildir.
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Bir sayı giriniz: ");

            int sayi;

            while (!int.TryParse(Console.ReadLine(), out sayi) || sayi <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ Geçersiz giriş. Lütfen '0'dan büyük' bir tam sayı giriniz: ");
                Console.ResetColor();

                Console.Write("Bir sayı giriniz: ");
            }

            int originalSayi = sayi;

            while (sayi > 1 && sayi % 5 == 0)
            {
                sayi /= 5;
            }

            if (sayi == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine($"{originalSayi} -> 5’in kuvvetidir.");
                Console.WriteLine("-----------------------------\n");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine($"{originalSayi} -> 5’in kuvveti değildir.");
                Console.WriteLine("-----------------------------\n");
                Console.ResetColor();
            }
        }
    }
}