/*
Bir dikdörtgenin 2 kenarını parametre olarak alan ve bu dikdörtgenin alanını ve çevresini
hesaplayan programı yazınız.
*/

using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static double UzunlukDegerGirisi(string mesaj)
        {
            Console.Write(mesaj);

            string giris = Console.ReadLine() ?? "";
            giris = giris.Replace(',', '.');

            double uzunlukDegeri;

            while (!double.TryParse(giris, NumberStyles.Any, CultureInfo.InvariantCulture, out uzunlukDegeri) || uzunlukDegeri <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ HATALI GİRİŞ!");
                Console.ResetColor();

                Console.Write("Tekrar deneyiniz: ");
                giris = Console.ReadLine() ?? "";
                giris = giris.Replace(',', '.');
            }

            return uzunlukDegeri;
        }
        static void DikdortgeninAlanVeCevresiniHesapla(double kenar1, double kenar2, out double cevre, out double alan)
        {
            cevre = 2 * (kenar1 + kenar2);
            alan = kenar1 * kenar2;
        }
        static void Main(string[] args)
        {
            Console.Clear();

            double kenar1 = UzunlukDegerGirisi("Dikdörtgenin 1. kenar uzunluğunu giriniz: ");
            double kenar2 = UzunlukDegerGirisi("Dikdörtgenin 2. kenar uzunluğunu giriniz: ");

            DikdortgeninAlanVeCevresiniHesapla(kenar1, kenar2, out double cevre, out double alan);

            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine($"Dikdörtgenin 1.Kenarı: {kenar1.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Dikdörtgenin 2.Kenarı: {kenar2.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nDikdörtgenin Çevresi\t: {cevre.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Dikdörtgenin Alanı\t: {alan.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ResetColor();
            Console.WriteLine("--------------------------------------------------\n");
        }
    }
}