/*
3'lerin sayısının 5'lerden büyük olup olmadığını kontrol eden bir C# Sharp programı yazın.
Örnek Giriş :
{ 1, 5, 6, 9, 3, 3 }
{ 1, 5, 5, 5, 10, 17 }
{ 1, 3, 3, 5, 5, 5 }
Beklenen Çıktı :
Doğru
Yanlış
Yanlış
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static int UcleriSay(int[] x)
        {
            int sayac = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 3)
                {
                    sayac++;
                }
            }
            return sayac;
        }

        static int BesleriSay(int[] x)
        {
            int sayac = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 5)
                {
                    sayac++;
                }
            }
            return sayac;
        }

        static bool Karsilastir(int x, int y)
        {
            if (x > y)
            {
                return true;
            }

            return false;
        }

        static void IslemVeYazdir(int[] x, string mesaj)
        {
            Console.WriteLine("\n-------------------------------\n");

            Console.Write($"{mesaj} [");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i]);
                if (i < x.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]\n");

            int sayac1 = UcleriSay(x);
            int sayac2 = BesleriSay(x);
            bool sonuc1 = Karsilastir(sayac1, sayac2);

            if (sonuc1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("✅ Doğru\n");
                Console.ResetColor();
                Console.WriteLine("-------------------------------\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌ Yanlış\n");
                Console.ResetColor();
                Console.WriteLine("-------------------------------\n");
            }
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi1 = { 1, 5, 6, 9, 3, 3 };
            int[] dizi2 = { 1, 5, 5, 5, 10, 17 };
            int[] dizi3 = { 1, 3, 3, 5, 5, 5 };

            IslemVeYazdir(dizi1, "Dizi 1:");
            IslemVeYazdir(dizi2, "Dizi 2:");
            IslemVeYazdir(dizi3, "Dizi 3:");
        }
    }
}
