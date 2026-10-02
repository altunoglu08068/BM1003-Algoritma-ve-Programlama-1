// Parametre olarak üç sayı (x, y, z) alan ve (x + y) · z çıktısını geri döndüren bir metodu yazınız.

using System;
using System.Globalization;

namespace Program
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
                Console.WriteLine("\n⚠️ HATA!");
                Console.ResetColor();

                Console.Write("Tekrar deneyin: ");

                giris = (Console.ReadLine() ?? "").Replace(',', '.');

                Console.WriteLine();
            }

            return sayi;
        }

        static double Islem(double x, double y, double z)
        {
            return (x + y) * z;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            double x = SayiGirisi("x değerini girin: ");
            double y = SayiGirisi("y değerini girin: ");
            double z = SayiGirisi("z değerini girin: ");

            double sonuc = Islem(x, y, z);

            Console.WriteLine("\n----------------------------------------------------------------");
            Console.WriteLine($"Formül: (x + y) · z | İşlem: ({x} + {y}) · {z} | Sonuç: {sonuc.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("----------------------------------------------------------------\n");
        }
    }
}
