/*
İki diziyi parametre olarak alan, bu dizileri yeni bir dizide birleştirip geri döndüren bir metot
yazınız.
*/

using System;

namespace MyApp
{
    internal class Program
    {
        static int BoyutGirisi(string mesaj)
        {
            Console.Write(mesaj);

            int sayi;

            while (!int.TryParse(Console.ReadLine(), out sayi) || sayi < 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("⚠️ HATA: Geçersiz giriş (pozitif sayı gerekli)!");
                Console.ResetColor();
                Console.Write("Tekrar deneyin: ");
            }

            return sayi;
        }

        static int RastgeleSayiGirisi(string mesaj)
        {
            Console.Write(mesaj);

            int sayi;

            while (!int.TryParse(Console.ReadLine(), out sayi))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("⚠️ HATA: Geçersiz giriş!");
                Console.ResetColor();
                Console.Write("Tekrar deneyin: ");
            }

            return sayi;
        }

        static int[] DizileriBirlestir(int[] dizi1, int[] dizi2)
        {
            int boyut1 = dizi1.Length;
            int boyut2 = dizi2.Length;

            int[] birlestirilmisDizi = new int[boyut1 + boyut2];

            for (int i = 0; i < boyut1; i++)
            {
                birlestirilmisDizi[i] = dizi1[i];
            }

            for (int i = 0; i < boyut2; i++)
            {
                birlestirilmisDizi[boyut1 + i] = dizi2[i];
            }

            return birlestirilmisDizi;
        }

        static void DiziYazdir(int[] dizi, string mesaj)
        {
            Console.Write($"{mesaj}: [");

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i]);

                if (i < dizi.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("]");
        }

        static bool GecerliMi(int altDeger, int ustDeger)
        {
            return altDeger < ustDeger;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int boyut1 = BoyutGirisi("1. dizinin boyutunu girin: ");
            int boyut2 = BoyutGirisi("2. dizinin boyutunu girin: ");

            int[] dizi1 = new int[boyut1];
            int[] dizi2 = new int[boyut2];

            Random rnd = new Random();

            int d1_alt = RastgeleSayiGirisi("\n1. dizi - Alt değer: ");
            int d1_ust = RastgeleSayiGirisi("1. dizi - Üst değer: ");

            if (!GecerliMi(d1_alt, d1_ust))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("⚠️ HATA: Alt değer, üst değerden küçük olmalı!");
                Console.ResetColor();
                return;
            }

            int d2_alt = RastgeleSayiGirisi("\n2. dizi - Alt değer: ");
            int d2_ust = RastgeleSayiGirisi("2. dizi - Üst değer: ");

            if (!GecerliMi(d2_alt, d2_ust))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("⚠️ HATA: Alt değer, üst değerden küçük olmalı!");
                Console.ResetColor();
                return;
            }

            for (int i = 0; i < boyut1; i++)
            {
                dizi1[i] = rnd.Next(d1_alt, d1_ust + 1);
            }
            for (int i = 0; i < boyut2; i++)
            {
                dizi2[i] = rnd.Next(d2_alt, d2_ust + 1);
            }

            int[] sonuc = DizileriBirlestir(dizi1, dizi2);

            Console.WriteLine("\n------------------------------------------------");
            DiziYazdir(dizi1, "1. Dizi");
            DiziYazdir(dizi2, "2. Dizi");
            Console.ForegroundColor = ConsoleColor.Green;
            DiziYazdir(sonuc, "\nBirleşmiş Dizi");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------\n");
        }
    }
}