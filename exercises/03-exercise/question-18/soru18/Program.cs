/*
Onluk tabanda bir sayıyı ikili sayıya çeviren bir program yazınız.
Giriş Verileri:
Bir Sayı Girin : 5
Beklenen çıktı:
İkili sayı: 101
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static void IkilikTabanaCevirme(int x)
        {
            if (x == 0)
            {
                Console.WriteLine("İkili sayı: 0");
                return;
            }

            string ikilikSayi = "";

            while (x > 0)
            {
                int kalan = x % 2;
                ikilikSayi = kalan + ikilikSayi;
                x /= 2;
            }
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine($"İkilik sayı karşılığı: {ikilikSayi}");
            Console.WriteLine("------------------------------------------------\n");
        }
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Bir sayı girin: ");

            int sayi;

            while (!int.TryParse(Console.ReadLine(), out sayi) || sayi < 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ HATA!");
                Console.ResetColor();

                Console.Write("\nTekrar deneyin: ");
            }

            IkilikTabanaCevirme(sayi);
        }
    }
}
