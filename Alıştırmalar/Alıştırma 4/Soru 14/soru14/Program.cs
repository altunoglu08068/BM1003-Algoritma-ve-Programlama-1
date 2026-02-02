/*
Bir üçgenin iki dik kenarını parametre olarak alan ve hipotenüsünü hesaplayan bir metot
yazınız.
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
                Console.WriteLine("\n⚠️ HATA: Geçersiz giriş veya negatif değer.");
                Console.ResetColor();

                Console.Write("Tekrar deneyin: ");
                giris = Console.ReadLine() ?? "";
                giris = giris.Replace(',', '.');
            }

            return uzunlukDegeri;
        }
        static double HipotenusHesapla(double dikKenar1, double dikKenar2)
        {
            return Math.Sqrt((dikKenar1 * dikKenar1) + (dikKenar2 * dikKenar2));
        }
        static void Main(string[] args)
        {
            Console.Clear();

            double dikKenar1 = UzunlukDegerGirisi("Birinci dik kenarın uzunluğunu girin\t: ");
            double dikKenar2 = UzunlukDegerGirisi("İkinci dik kenarın uzunluğunu girin\t: ");

            double hipotenus = HipotenusHesapla(dikKenar1, dikKenar2);

            Console.WriteLine("\n-----------------------------------------------------------");
            Console.WriteLine($"Birinci dik kenar\t: {dikKenar1.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"İkinci dik kenar\t: {dikKenar2.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Hipotenüs uzunluğu\t: {hipotenus.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ResetColor();
            Console.WriteLine("-----------------------------------------------------------\n");
        }
    }
}