/*
Bir tamsayı dizisinde 4 ve 4’ten büyük elemanları kaldırarak yeni bir dizi oluşturan bir metot
yazınız.

Örnek Giriş: {0, -2, 1, 2, 3, 5 , 4, 7, 8}
Beklenen Çıkış : {0, -2, 1, 2, 3}
*/

using System;

namespace MyApp
{
    internal class Program
    {
        static int[] YenDizi(int[] dizi)
        {
            int sayac = 0;

            foreach (int sayi in dizi)
            {
                if (sayi < 4)
                {
                    sayac++;
                }
            }

            int[] yeni = new int[sayac];

            int yeniIndex = 0;

            foreach (int eleman in dizi)
            {
                if (eleman < 4)
                {
                    yeni[yeniIndex] = eleman;
                    yeniIndex++;
                }
            }
            return yeni;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi = { 0, -2, 1, 2, 3, 5, 4, 7, 8 };
            int[] yeni = YenDizi(dizi);

            Console.WriteLine($"Orijinal Dizi\t: [{string.Join(", ", dizi)}]");
            Console.WriteLine($"Yeni Dizi\t: [{string.Join(", ", yeni)}]\n");
        }
    }
}