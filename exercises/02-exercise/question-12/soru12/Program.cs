// Girilen bir tam sayının basamaklarındaki en büyük rakamı bulan programı yazınız.

using System;

namespace Program
{
    internal class ProgramClass
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Bir tam sayı giriniz: ");

            int sayi;

            while (!int.TryParse(Console.ReadLine(), out sayi))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("⚠️ Hatalı giriş!");
                Console.ResetColor();

                Console.Write("Lütfen bir tam sayı giriniz: ");
            }

            int islemSayisi = Math.Abs(sayi);
            int enBuyukRakam = 0;

            while (islemSayisi > 0)
            {
                int basamak = islemSayisi % 10;

                if (enBuyukRakam < basamak)
                {
                    enBuyukRakam = basamak;
                }

                islemSayisi /= 10;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine($"Girilen Sayı\t: {sayi}");
            Console.WriteLine($"En Büyük Rakam\t: {enBuyukRakam}");
            Console.WriteLine("-------------------------------\n");
            Console.ResetColor();
        }
    }
}
