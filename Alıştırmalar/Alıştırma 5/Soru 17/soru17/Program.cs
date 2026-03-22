/*
Bir tam sayı dizisini parametre olarak alan bir metot yazınız. Bu metot dizideki her bir
elemanın 3 ile çarpılarak oluşturulmuş yeni diziyi dönsün.
Örnek Giriş : { 1, 2, 3, 4 }
Beklenen Çıkış :
Yeni dizi: { 3, 6, 9, 12 }
*/

using System;

namespace MyApp
{
    internal class Program
    {
        static void DiziYazdir(int[] dizi, string mesaj)
        {
            Console.Write($"{mesaj}: [");

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write($"{dizi[i],2}");
                Console.Write(i < dizi.Length - 1 ? ", " : "");
            }

            Console.WriteLine("]");
        }

        static int[] UcIleCarp(int[] dizi)
        {
            int[] yeniDizi = new int[dizi.Length];

            for (int i = 0; i < yeniDizi.Length; i++)
            {
                yeniDizi[i] = dizi[i] * 3;
            }

            return yeniDizi;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi = { 1, 2, 3, 4 };
            int[] yeniDizi = UcIleCarp(dizi);

            Console.WriteLine("\n------------------------------------------------");
            DiziYazdir(dizi, "Orijinal Dizi\t");
            DiziYazdir(yeniDizi, "Yeni Dizi\t");
            Console.WriteLine("------------------------------------------------\n");
        }
    }
}