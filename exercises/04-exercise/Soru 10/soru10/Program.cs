using System;

namespace Program
{
    internal class Program
    {
        static bool EsitMi(int sayi)
        {
            int birler = sayi % 10;
            int onlar = sayi / 10 % 10;
            int yuzler = sayi / 100 % 10;

            int kuplerToplami = (birler * birler * birler) +
                                (onlar * onlar * onlar) +
                                (yuzler * yuzler * yuzler);

            return kuplerToplami == sayi;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Üç basamaklı bir sayı giriniz: ");

            int sayi;

            while (!int.TryParse(Console.ReadLine(), out sayi) || sayi < 100 || sayi > 999)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ HATA! Lütfen 3 basamaklı (100-999 arası) sayısal bir değer giriniz.");
                Console.ResetColor();
                Console.Write("Tekrar deneyin: ");
            }

            bool esitMi = EsitMi(sayi);

            Console.WriteLine("\n-------------------------------------------------------------");

            if (esitMi)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Girdiğiniz sayının rakamlarının küpleri toplamı kendisine eşittir.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Girdiğiniz sayının rakamlarının küpleri toplamı kendisine eşit değil.");
                Console.ResetColor();
            }

            Console.WriteLine("-------------------------------------------------------------\n");
        }
    }
}