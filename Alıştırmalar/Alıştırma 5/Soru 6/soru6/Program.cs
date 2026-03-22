/*
Belirli bir sayıdan sonra gelen, bir sonraki asal sayıyı bulan bir metot yazın. Verilen sayı bir asal
sayıysa, sayının kendisini döndürün.
Örnek Çıktı:
Giriş : 120
Sonraki asal sayı/Mevcut asal sayı: 127
Giriş : 321
Sonraki asal sayı/Mevcut asal sayı: 331
*/

using System;

namespace MyApp
{
    internal class Program
    {
        static int SayiGirisi(string mesaj)
        {
            Console.Write(mesaj);

            int sayi;

            while (!int.TryParse(Console.ReadLine(), out sayi) || sayi < 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ HATA: Geçersiz giriş.");
                Console.ResetColor();
                Console.Write("Tekrar deneyin: ");
            }
            return sayi;
        }

        static bool AsalMi(int sayi)
        {
            if (sayi < 2) return false;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0) return false;
            }
            return true;
        }

        static int BirSonrakiAsaliBul(int sayi)
        {
            if (sayi < 2) return 2;

            while (true)
            {
                if (AsalMi(sayi) == true)
                {
                    return sayi;
                }

                sayi++;
            }
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int girilenSayi = SayiGirisi("Bir sayı giriniz: ");

            int bulunanAsal = BirSonrakiAsaliBul(girilenSayi);

            Console.WriteLine("\n--------------------------------------");

            if (girilenSayi == bulunanAsal)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"✅ Girdiğiniz {girilenSayi} sayısı zaten asal.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Giriş: {girilenSayi}");
                Console.WriteLine($"Sonraki Asal Sayı: {bulunanAsal}");
            }

            Console.ResetColor();
            Console.WriteLine("--------------------------------------\n");
        }
    }
}