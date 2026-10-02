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

namespace Program
{
    internal class ProgramClass
    {
        static int BirSonrakiAsal(int sayiGirisi)
        {
            while (true)
            {
                int pozitifBolen = 0;

                for (int i = 1; i <= sayiGirisi; i++)
                {
                    if (sayiGirisi % i == 0)
                    {
                        pozitifBolen++;
                    }
                }

                if (pozitifBolen == 2)
                {
                    return sayiGirisi;
                }
                sayiGirisi++;
            }
        }
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Bir sayı giriniz: ");

            int sayiGirisi;

            while (!int.TryParse(Console.ReadLine(), out sayiGirisi))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ HATA!");
                Console.ResetColor();

                Console.Write("\nTekrar deneyiniz: ");
            }

            int giris = BirSonrakiAsal(sayiGirisi);

            Console.WriteLine("\n-------------------------------");
            Console.WriteLine($"Sonuç: {giris}");
            Console.WriteLine("-------------------------------\n");
        }
    }
}
