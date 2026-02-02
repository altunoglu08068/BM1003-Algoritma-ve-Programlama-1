/*
Bir sayı dizisini parametre olarak alan ve en büyük elemanı bulup geri döndüren metodu
yazınız.
*/

using System;

namespace MyApp
{
    internal class Program
    {
        static int enBuyukElemaniBul(int[] dizi)
        {
            int enBuyuk = dizi[0];

            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > enBuyuk)
                {
                    enBuyuk = dizi[i];
                }
            }

            return enBuyuk;
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi = new int[5];

            Random rnd = new Random();

            Console.Write("Dizi: [");
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1, 101);

                Console.Write(dizi[i]);

                if (i < dizi.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");

            int enBuyuk = enBuyukElemaniBul(dizi);

            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine($"Dizinin en büyük elemanı: {enBuyuk}");
            Console.WriteLine("---------------------------------------------\n");
        }
    }
}