// s = x + y² denklemin sonucunu hesaplayan bir metot yazınız.

using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static double SayiGirisi(string mesaj)
        {
            Console.Write(mesaj);

            string giris = Console.ReadLine() ?? "";
            giris = giris.Replace(',', '.');

            double sayi;

            while (!double.TryParse(giris, NumberStyles.Any, CultureInfo.InvariantCulture, out sayi))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("⚠️ HATA: Hatalı giriş yaptınız.");
                Console.ResetColor();

                Console.Write("Tekrar deneyiniz: ");
                giris = Console.ReadLine() ?? "";
                giris = giris.Replace(',', '.');
            }

            return sayi;
        }

        static double FormulHesapla(double x, double y)
        {
            return x + (y * y);
        }
        static void Main(string[] args)
        {
            Console.Clear();

            double x = SayiGirisi("x değerini giriniz: ");
            double y = SayiGirisi("y değerini giriniz: ");
            double s = FormulHesapla(x, y);

            Console.WriteLine("\n--------------------------------------------------------------");
            Console.WriteLine($"Girilen değerler için s = x + y² denkleminin sonucu: {s}");
            Console.WriteLine("--------------------------------------------------------------\n");
        }
    }
}