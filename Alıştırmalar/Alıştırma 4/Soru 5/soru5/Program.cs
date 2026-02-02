// Santigrat dereceyi Fahrenheit'e çeviren bir metot yazınız.

using System;
using System.Globalization;

namespace Program
{
    internal class Program
    {
        static double SayiGirisi(string mesaj)
        {
            Console.Write(mesaj);

            string giris = (Console.ReadLine() ?? "").Replace(',', '.');
            double sayi;

            while (!double.TryParse(giris, NumberStyles.Any, CultureInfo.InvariantCulture, out sayi))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ HATA!");
                Console.ResetColor();

                Console.Write("Tekrar deneyin: ");

                giris = (Console.ReadLine() ?? "").Replace(',', '.');
            }

            return sayi;
        }

        static double FahrenheitaDonustur(double x)
        {
            return (x * 1.8) + 32;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            double santigrat = SayiGirisi("Santigrat (℃) değerini girin: ");

            double fahrenheit = FahrenheitaDonustur(santigrat);

            Console.WriteLine("\n---------------------------------------------------");
            Console.WriteLine($"{santigrat} ℃ = {fahrenheit.ToString("F2", CultureInfo.InvariantCulture)} ℉");
            Console.WriteLine("---------------------------------------------------\n");
        }
    }
}
