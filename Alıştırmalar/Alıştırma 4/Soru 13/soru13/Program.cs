// Yarıçapı parametre olarak alan bir dairenin alanını ve çevresini hesaplayan bir metot yazınız.

using System;
using System.Globalization;

namespace DaireHesaplama
{
    internal class Program
    {
        static double YariCapAl(string mesaj)
        {
            Console.Write(mesaj);
            string giris = Console.ReadLine() ?? "";
            giris = giris.Replace(',', '.');

            double yaricap;
            while (!double.TryParse(giris, NumberStyles.Any, CultureInfo.InvariantCulture, out yaricap) || yaricap <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"⚠️ HATA! Lütfen pozitif bir sayı giriniz.");
                Console.ResetColor();
                Console.Write("Tekrar deneyin: ");
                giris = Console.ReadLine() ?? "";
                giris = giris.Replace(',', '.');
            }
            return yaricap;
        }

        static void DaireHesapla(double pi, double yaricap, out double cevre, out double alan)
        {
            cevre = 2 * pi * yaricap;
            alan = pi * yaricap * yaricap;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            const double pi = 3.14;

            double yaricap = YariCapAl("Yarıçap girin: ");

            double cevre, alan;

            DaireHesapla(pi, yaricap, out cevre, out alan);

            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine($"Pi: {pi.ToString("F2", CultureInfo.InvariantCulture)} | " +
                              $"Yarıçap: {yaricap.ToString("F2", CultureInfo.InvariantCulture)} | " +
                              $"Çevre: {cevre.ToString("F2", CultureInfo.InvariantCulture)} | " +
                              $"Alan: {alan.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("----------------------------------------------------------\n");
        }
    }
}