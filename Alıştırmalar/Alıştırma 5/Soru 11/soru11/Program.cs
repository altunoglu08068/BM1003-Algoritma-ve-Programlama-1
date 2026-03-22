/*
Parametre olarak verilen iki tam sayıyı kontrol eden ve biri 30 veya toplamları 30 ise true
değerini döndüren bir metot yazınız.
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

            while (!int.TryParse(Console.ReadLine(), out sayi))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ HATA: Geçersiz giriş!");
                Console.ResetColor();

                Console.Write("Tekrar deneyin: ");
            }
            return sayi;
        }

        static bool OtuzMu(int sayi1, int sayi2)
        {
            return (sayi1 == 30) || (sayi2 == 30) || (sayi1 + sayi2 == 30);
        }

        static void SonucYazdir(int sayi1, int sayi2, bool sonuc)
        {
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine($"1. Sayı\t\t\t: {sayi1}");
            Console.WriteLine($"2. Sayı\t\t\t: {sayi2}");
            Console.WriteLine($"\nSayıların toplamı\t: {sayi1 + sayi2}");

            if (sonuc)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nSonuç\t\t\t: {sonuc}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nSonuç\t\t\t: {sonuc}");
                Console.ResetColor();
            }
            Console.WriteLine("---------------------------------\n");
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int sayi1 = SayiGirisi("1. sayıyı girin\t: ");
            int sayi2 = SayiGirisi("2. sayıyı girin\t: ");

            bool sonuc = OtuzMu(sayi1, sayi2);

            SonucYazdir(sayi1, sayi2, sonuc);
        }
    }
}