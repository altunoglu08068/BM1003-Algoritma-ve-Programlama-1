/*
İki tamsayı dizisinin karşılık gelen elemanlarını çarpmak için bir C# programı yazın.
Örnek Çıktı:
Dizi1: [1, 3, -5, 4]
Dizi2: [1, 4, -5, -2]
Sonuç :
1 12 25 -8
*/

using System;

namespace MyApp
{
    internal class Program
    {
        static int[] DiziCarp(int[] dizi1, int[] dizi2)
        {
            // GÜVENLİK KONTROLÜ: Boyutlar eşit değilse hata fırlat veya null dön.
            if (dizi1.Length != dizi2.Length)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("⚠️ HATA: Dizilerin boyutları eşit olmalı!");
                Console.ResetColor();

                return new int[0]; // Boş dizi döndürerek hatayı engelleriz.
            }

            int[] yeniDizi = new int[dizi1.Length];

            for (int i = 0; i < dizi1.Length; i++)
            {
                yeniDizi[i] = dizi1[i] * dizi2[i];
            }
            return yeniDizi;
        }

        static void DiziYazdir(int[] dizi, string mesaj)
        {
            Console.Write($"{mesaj}: [");

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write($"{dizi[i],2}");

                if (i < dizi.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi1 = { 1, 3, -5, 4 };
            int[] dizi2 = { 1, 4, -5, -2 };

            int[] yeniDizi = DiziCarp(dizi1, dizi2);

            DiziYazdir(dizi1, "Dizi 1");
            DiziYazdir(dizi2, "Dizi 2");

            Console.WriteLine("\n-------------------------------------");
            DiziYazdir(yeniDizi, "Yeni Dizi");
            Console.WriteLine("-------------------------------------\n");
        }
    }
}