/*
İki diziyi parametre olarak alan, bu dizileri yeni bir dizide birleştirip geri döndüren bir
metot yazınız.
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
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
        static int[] DizileriEkle(int[] x, int[] y)
        {
            int[] yeni = new int[x.Length + y.Length];

            for (int i = 0; i < x.Length; i++)
            {
                yeni[i] = x[i];
            }

            for (int i = 0; i < y.Length; i++)
            {
                yeni[x.Length + i] = y[i];
            }

            return yeni;
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int boyut = 5;

            int[] dizi1 = new int[boyut];
            int[] dizi2 = new int[boyut];

            Random rastgele = new Random();

            for (int i = 0; i < boyut; i++)
            {
                dizi1[i] = rastgele.Next(0, 21);
                dizi2[i] = rastgele.Next(0, 21);
            }

            DiziYazdir(dizi1, "Dizi 1\t\t");
            DiziYazdir(dizi2, "Dizi 2\t\t");

            int[] yeni = DizileriEkle(dizi1, dizi2);

            DiziYazdir(yeni, "Dizi1 + Dizi 2\t");
        }
    }
}
