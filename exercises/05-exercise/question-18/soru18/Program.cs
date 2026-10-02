/*
Bir tam sayı dizisini parametre olarak alan bir metot yazınız. Bu metot dizideki her bir
elemanın 3 kez kendisiyle çarparak oluşturulmuş yeni diziyi dönsün.
Örnek Giriş : { 1, 2, 3 , 4 }
Beklenen Çıkış : Yeni dizi: { 1, 8, 27, 64 }
*/

using System;

namespace MyApp
{
    internal class Program
    {
        static int[] KupleriniAl(int[] dizi)
        {
            int[] yeniDizi = new int[dizi.Length];

            for (int i = 0; i < yeniDizi.Length; i++)
            {
                yeniDizi[i] = dizi[i] * dizi[i] * dizi[i];
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

            int[] dizi = { 1, 2, 3, 4 };

            int[] yeniDizi = KupleriniAl(dizi);

            Console.WriteLine("\n----------------------------------");
            DiziYazdir(dizi, "Orijinal dizi\t");
            DiziYazdir(yeniDizi, "Yeni dizi\t");
            Console.WriteLine("----------------------------------\n");
        }
    }
}