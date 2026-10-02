/*
Bir tam sayı dizisini parametre olarak alan en büyük ve en küçük de değerleri arasındaki farkı
hesaplayıp döndüren bir metot yazınız.
*/

using System;

namespace MyApp
{
    internal class Program
    {
        static int EnBuyukEnKucukFarkiniBul(int[] dizi)
        {
            if (dizi.Length == 0)
            {
                return 0;
            }

            int enBuyuk = dizi[0];
            int enKucuk = dizi[0];

            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > enBuyuk)
                {
                    enBuyuk = dizi[i];
                }

                if (dizi[i] < enKucuk)
                {
                    enKucuk = dizi[i];
                }
            }

            return enBuyuk - enKucuk;
        }

        static void DiziYazdir(int[] dizi, string mesaj)
        {
            Console.Write($"{mesaj}: [");

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i]);

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

            int[] dizi = new int[5];

            Random rnd = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0, 101);
            }

            int fark = EnBuyukEnKucukFarkiniBul(dizi);

            Console.WriteLine("\n------------------------------------------------");
            DiziYazdir(dizi, "Oluşturulan Dizi");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"En Büyük ve En Küçük Arasındaki Fark: {fark}");
            Console.ResetColor();

            Console.WriteLine("------------------------------------------------\n");
        }
    }
}