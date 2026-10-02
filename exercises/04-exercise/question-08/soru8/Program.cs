/*
Bir sayıyı parametre olarak alan ve bu sayının faktöriyelini hesaplayıp sonucu geri döndüren
bir metot tanımayız.
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

            while (!int.TryParse(Console.ReadLine(), out sayi) || sayi < 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ HATA!");
                Console.ResetColor();

                Console.Write("Tekrar deneyin: ");
            }

            return sayi;
        }

        static int FaktoriyelHesapla(int sayi)
        {
            if (sayi == 0)
            {
                return 1;
            }

            int faktoriyel = 1;

            for (int i = sayi; i > 0; i--)
            {
                faktoriyel *= i;
            }

            return faktoriyel;
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int sayi = SayiGirisi("Bir sayı giriniz: ");

            int faktoriyel = FaktoriyelHesapla(sayi);

            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine($"{sayi}! = {faktoriyel}");
            Console.WriteLine("--------------------------------------------------------\n");
        }
    }
}
