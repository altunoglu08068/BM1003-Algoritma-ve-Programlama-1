/*
0 sayısı girilene kadar sayı girişini sağlayan ve bu sayıların kaç tane olduğunu, toplamını ve
ortalamasını bulup sonucu ekrana yazdıran programı yazınız.
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int sayi;
            int sayac = 0;
            int toplam = 0;
            double ortalama = 0;

            while (true)
            {
                Console.Write("Bir sayı giriniz (Çıkış için 0): ");

                while (!int.TryParse(Console.ReadLine(), out sayi))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n⚠️ Hatalı giriş!");
                    Console.ResetColor();
                    Console.Write("Lütfen tekrar deneyin (Çıkış için 0): ");
                }

                if (sayi == 0)
                {
                    break;
                }

                toplam += sayi;
                sayac++;
            }

            Console.WriteLine("\n\nÇıkış yaptınız, güle güle! 👋");

            if (sayac > 0)
            {
                ortalama = (double)toplam / sayac;

                Console.WriteLine("\n\n\t   Sonuçlar");
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"Girilen sayı adedi\t: {sayac}");
                Console.WriteLine($"Sayıların toplamı\t: {toplam}");
                Console.WriteLine($"Sayıların ortalaması\t: {ortalama:F2}");
                Console.WriteLine("-------------------------------\n");
            }
            else
            {
                Console.WriteLine("Hiç sayı girmediniz, hesaplanacak bir şey yok.");
            }
        }
    }
}