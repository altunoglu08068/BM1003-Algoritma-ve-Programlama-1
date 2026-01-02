/*
Girilen bir sayının yaklaşık olarak kare kökünü hesaplayan programı yazınız.
Örnek:
5 -> yaklaşık karekökü 2.25
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static double YaklasikKarekokHesapla(double x)
        {
            if (x == 0)
            {
                return 0;
            }

            double tahmin = x / 2;
            double hataPayi = 0.01;

            while (Math.Abs(tahmin * tahmin - x) > hataPayi)
            {
                tahmin = (tahmin + (x / tahmin)) / 2;
            }
            return tahmin;
        }
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Bir sayı giriniz: ");

            double sayi;

            while (!double.TryParse(Console.ReadLine(), out sayi) || sayi < 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("⚠️ Hatalı giriş! Lütfen bir sayı giriniz: ");
                Console.ResetColor();

                Console.Write("Bir sayı giriniz: ");
            }

            double yaklasikKarekok = YaklasikKarekokHesapla(sayi);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nGirdiğiniz {sayi} sayısının yaklaşık karekökü: {yaklasikKarekok:F2}\n");
            Console.ResetColor();
        }
    }
}
