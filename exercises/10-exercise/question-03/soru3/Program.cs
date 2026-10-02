/*
Belirli bir sayının bir sayı dizisinde olup olmadığını kontrol eden bir C# programı yazın.
Örnek Giriş :
{1,2,9,3}, 3
{1,2,2,3}, 2
{1,2,2,3}, 9
Beklenen Çıkış :
True
True
False
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static bool BulunduMu(int[] x, int AranacakSayi)
        {
            bool bulunduMu = false;

            for (int i = 0; i < x.Length; i++)
            {
                if (AranacakSayi == x[i])
                {
                    bulunduMu = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n✅ True");
                    Console.ResetColor();
                    break;
                }
            }
            if (!bulunduMu)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n❌ False");
                Console.ResetColor();
            }
            return bulunduMu;
        }
        static int SayiIste(string mesaj)
        {
            int sayi;
            Console.Write(mesaj);
            while (!int.TryParse(Console.ReadLine(), out sayi))
            {
                Console.WriteLine("\nBir şeyler ters gitti...");
                Console.Write("\nLütfen tekrar deneyiniz: ");
            }
            return sayi;
        }
        static void DiziYazdir(int[] x)
        {
            Console.Write("\n[");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i]);

                if (i < x.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]\n");
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi1 = { 1, 2, 9, 3 };
            int[] dizi2 = { 1, 2, 2, 3 };
            int[] dizi3 = { 1, 2, 2, 3 };

            int s1 = SayiIste("\n\n1. Dizide aranacak sayıyı giriniz: ");
            Console.WriteLine("\n-----------------------------");
            BulunduMu(dizi1, s1);
            DiziYazdir(dizi1);
            Console.WriteLine("-----------------------------\n");

            int s2 = SayiIste("\n\n2. Dizide aranacak sayıyı giriniz: ");
            Console.WriteLine("\n-----------------------------");
            BulunduMu(dizi2, s2);
            DiziYazdir(dizi2);
            Console.WriteLine("-----------------------------\n");

            int s3 = SayiIste("\n\n3. Dizide aranacak sayıyı giriniz: ");
            Console.WriteLine("\n-----------------------------");
            BulunduMu(dizi3, s3);
            DiziYazdir(dizi3);
            Console.WriteLine("-----------------------------\n");
        }
    }
}
