/*
Bir diziyi parametre olarak alan ve elemanlarını sola kaydıran bir metot yazınız.
Örnek Giriş : { 10, 20, -30, -40, 50 }
Beklenen Çıkış :
Yeni dizi: { 20, -30, -40, 50, 10 }
*/

using System;

namespace MyApp
{
    internal class Program
    {
        static int[] SolaKaydir(int[] dizi)
        {
            if (dizi == null || dizi.Length == 0)
            {
                return new int[0];
            }

            int[] yeniDizi = new int[dizi.Length];

            for (int i = 1; i < dizi.Length; i++)
            {
                yeniDizi[i - 1] = dizi[i];
            }

            yeniDizi[dizi.Length - 1] = dizi[0];

            return yeniDizi;
        }

        static void DiziYazdir(int[] dizi, string mesaj)
        {
            Console.Write($"{mesaj}: [");

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i]);
                Console.Write(i < dizi.Length - 1 ? ", " : "");
            }

            Console.WriteLine("]");
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi = { 10, 20, -30, -40, 50 };

            int[] yeniDizi = SolaKaydir(dizi);

            Console.WriteLine("\n-------------------------------------------");
            DiziYazdir(dizi, "Orijinal Dizi\t");
            DiziYazdir(yeniDizi, "\nYeni Dizi\t");
            Console.WriteLine("-------------------------------------------\n");
        }
    }
}