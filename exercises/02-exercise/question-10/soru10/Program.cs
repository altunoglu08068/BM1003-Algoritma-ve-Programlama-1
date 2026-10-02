/*
Klavyeden girilen 10 adet sayıdan en büyüğünün kaçıncı sırada olduğunu yazan programı
yazınız.
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int enBuyuk = int.MinValue;
            int sira = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Lütfen, {i}. sayıyı giriniz: ");

                int sayi;

                while (!int.TryParse(Console.ReadLine(), out sayi))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n⚠️ Hatalı giriş!");
                    Console.ResetColor();

                    Console.Write("\nLütfen tekrar giriniz: ");
                }

                if (enBuyuk < sayi)
                {
                    enBuyuk = sayi;
                    sira = i;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine($"En büyük sayı ({enBuyuk}) {sira}. sırada.");
            Console.WriteLine("-------------------------------\n");
            Console.ResetColor();
        }
    }
}
