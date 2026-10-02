// Bir dizideki ilk ve son elemanların yerini değiştiren ve yeni diziyi döndüren bir metot yazınız.

using System;

namespace MyApp
{
    internal class Program
    {
        static void DiziYazdir(int[] dizi, string mesaj)
        {
            Console.Write($"{mesaj}\t: [");
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

        static int[] IlkIleSonElemaniDegistir(int[] dizi)
        {
            int[] yeniDizi = new int[dizi.Length];

            // Önce yeni diziye kopyala
            for (int i = 0; i < yeniDizi.Length; i++)
            {
                yeniDizi[i] = dizi[i];
            }

            // Sonra yeni dizi üzerinde değişim yap
            int gecici = yeniDizi[0];
            yeniDizi[0] = yeniDizi[yeniDizi.Length - 1];
            yeniDizi[yeniDizi.Length - 1] = gecici;

            return yeniDizi;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi = new int[5];

            Random rnd = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0, 11);
            }

            int[] yeniDizi = IlkIleSonElemaniDegistir(dizi);

            DiziYazdir(dizi, "Orijinal Dizi");

            Console.WriteLine();

            DiziYazdir(yeniDizi, "Yeni Dizi");

            Console.WriteLine();
        }
    }
}