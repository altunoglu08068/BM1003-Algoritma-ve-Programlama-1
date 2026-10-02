/*
Pozitif bir sayıyı parametre olarak alan ve bu sayının kaç basamaklı olduğunu hesaplayıp geri
döndüren bir metot tanımlayınız.
*/

using System;

namespace Program
{
    internal class Program
    {
        static int SayiGirisi(string mesaj)
        {
            Console.Write(mesaj);

            int sayi;

            while (!int.TryParse(Console.ReadLine(), out sayi) || sayi <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nHATA!");
                Console.ResetColor();

                Console.Write("Tekrar deneyin: ");
            }

            return sayi;
        }

        static int BasamakSayisiHesapla(int sayi)
        {
            int basamakSayisi = 0;

            while (sayi > 0)
            {
                sayi /= 10;

                basamakSayisi++;
            }

            return basamakSayisi;
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int sayi = SayiGirisi("Bir sayı giriniz: ");

            int basamakSayisi = BasamakSayisiHesapla(sayi);

            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine($"Sayı: {sayi} | Basamak sayısı: {basamakSayisi}");
            Console.WriteLine("---------------------------------------------------------\n");
        }
    }
}
