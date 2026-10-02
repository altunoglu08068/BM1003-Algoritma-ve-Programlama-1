/*
Bir tam sayı dizisindeki tüm sıfırları sola kaydıran bir metot yazınız.
Örnek Giriş : { 1, 2, 0, 3, 5, 7, 0, 9, 11 }
Beklenen Çıkış :
Yeni dizi: { 0, 0, 1, 2, 3, 5, 7, 9, 11 }
*/

using System;

namespace MyApp
{
    internal class Program
    {
        static int[] SifirlariSolaKaydir(int[] dizi)
        {
            int[] yeniDizi = new int[dizi.Length];

            int index = 0;

            for (int i = 0; i < yeniDizi.Length; i++)
            {
                if (dizi[i] == 0)
                {
                    yeniDizi[index] = dizi[i];
                    index++;
                }
            }

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] != 0)
                {
                    yeniDizi[index] = dizi[i];
                    index++;
                }
            }

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

            int[] dizi = { 1, 2, 0, 3, 5, 7, 0, 9, 11 };
            int[] yeniDizi = SifirlariSolaKaydir(dizi);

            Console.WriteLine("\n-------------------------------------------------");
            DiziYazdir(dizi, "Orijinal Dizi\t");
            Console.WriteLine();
            DiziYazdir(yeniDizi, "Yeni Dizi\t");
            Console.WriteLine("-------------------------------------------------\n");
        }
    }
}