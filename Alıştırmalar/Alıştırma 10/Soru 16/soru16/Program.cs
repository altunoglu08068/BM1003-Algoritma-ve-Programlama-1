/*
Bir tam sayı dizisindeki tüm sıfırları sola kaydıran bir metot yazınız.
Örnek Giriş :
{ 1, 2, 0, 3, 5, 7, 0, 9, 11 }
Beklenen Çıkış :
Yeni dizi: 0 0 1 3 5 7 2 9 11
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static int[] SifirlariSolaKaydir(int[] x)
        {
            int[] y = new int[x.Length];
            int index = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 0)
                {
                    y[index++] = 0;
                }
            }

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != 0)
                {
                    y[index++] = x[i];
                }
            }

            return y;
        }
        static void DiziYazdir(int[] x, string mesaj)
        {
            Console.Write($"{mesaj}: [");

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i]);

                if (i < x.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("]\n");
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi = { 1, 2, 0, 3, 5, 7, 0, 9, 11 };
            DiziYazdir(dizi, "Orijinal dizi\t");
            
            int[] yeniDizi = SifirlariSolaKaydir(dizi);
            DiziYazdir(yeniDizi, "Yeni dizi\t");
        }
    }
}
