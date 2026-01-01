/*
Parametre olarak verilen iki tam sayıyı kontrol eden ve biri 30 veya toplamları 30 ise true
değerini döndüren bir metot yazınız.
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static int SayiKontrol()
        {
            int sayi;

            while (!int.TryParse(Console.ReadLine(), out sayi))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ HATA!");
                Console.ResetColor();

                Console.Write("\nTekrar deneyin: ");
            }

            return sayi;
        }

        static bool OtuzMu(int sayi1, int sayi2)
        {
            return sayi1 == 30 || sayi2 == 30 || sayi1 + sayi2 == 30;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Bir sayı girin\t\t: ");
            int sayi1 = SayiKontrol();

            Console.Write("\nBir sayı daha girin\t: ");
            int sayi2 = SayiKontrol();

            bool deger = OtuzMu(sayi1, sayi2);

            Console.ForegroundColor = deger ? ConsoleColor.Green : ConsoleColor.Red;

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine(deger ? "✅ True" : "❌ False");
            Console.WriteLine("-------------------------------------------\n");

            Console.ResetColor();
        }
    }
}
