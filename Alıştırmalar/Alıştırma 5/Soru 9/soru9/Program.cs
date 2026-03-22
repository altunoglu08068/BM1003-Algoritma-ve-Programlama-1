/*
Bir tam sayı dizisinin tüm öğelerinin toplamını hesaplayan bir C# programı yazın.
Test Verileri:
Dizi1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7,8, 8, 1, 1]
Örnek Çıktı
Toplamı : 70
*/

using System;

namespace MyApp
{
    internal class Program
    {
        static int DiziElemanlariniTopla(int[] dizi)
        {
            int toplam = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                toplam += dizi[i];
            }
            return toplam;
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1, 1 };

            int toplam = DiziElemanlariniTopla(dizi);

            Console.Write("Dizi: [");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i]);

                if (i < dizi.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");

            Console.WriteLine("\n------------------------------");
            Console.WriteLine($"Dizinin elemanları toplamı: {toplam}");
            Console.WriteLine("------------------------------\n");
        }
    }
}