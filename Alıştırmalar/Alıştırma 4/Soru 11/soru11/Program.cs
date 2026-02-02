// Herhangi bir sayının herhangi bir dereceden kuvvetini (üssünü) bulan metodu yazınız.

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
                giris = Console.ReadLine() ?? "";
                giris = giris.Replace(',', '.');
            }
            return sayi;
        }

        static void UsAlma(double taban, double us)
        {
            // 1. ÖZEL DURUM: 0 üzeri 0 durumu
            if (taban == 0 && us == 0)
            {
                Console.Write("\nSonuç: Belirsiz\n\n");
                return;
            }

            // 2. ÖZEL DURUM: Negatif tabanın kesirli kuvveti (Karmaşık Sayı)
            if (taban < 0 && us != (int)us)
            {
                Console.Write("\nSonuç: Karmaşık sayı (Reel sayılarda tanımsız)\n\n");
                return;
            }

            double sonuc = 1;

            // Üs tam sayı ise...
            if (us % 1 == 0)
            {
                int tamSayiUs = (int)us;
                int pozitifUs = tamSayiUs > 0 ? tamSayiUs : -tamSayiUs;

                for (int i = 0; i < pozitifUs; i++)
                {
                    sonuc *= taban;
                }

                // Eğer üs negatifse...
                if (tamSayiUs < 0)
                {
                    if (taban == 0)
                    {
                        Console.Write("\nSonuç: Sonsuz (Tanımsız)\n\n");
                        return;
                    }
                    sonuc = 1.0 / sonuc;
                }
            }

            // Kesirli üs durumu...
            else
            {
                sonuc = Math.Pow(taban, us);
            }

            Console.WriteLine($"\nSonuç: {sonuc.ToString(CultureInfo.InvariantCulture)}\n\n");
        }

        static void Main(string[] args)
        {
            Console.Clear();

            double taban = SayiGirisi("Bir sayı giriniz (taban): ");
            double us = SayiGirisi("Bir sayı giriniz (üs)\t: ");

            UsAlma(taban, us);

            Console.ReadLine();
        }
    }
}