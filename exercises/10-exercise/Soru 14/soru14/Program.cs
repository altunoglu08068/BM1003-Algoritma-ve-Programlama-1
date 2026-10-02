/*
Bir tam sayı dizisini parametre olarak alan en büyük ve en küçük de değerleri arasındaki farkı
hesaplayıp döndüren bir metot yazınız.
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static int FarkBul(int[] x)
        {
            int enBuyuk = x[0];
            int enKucuk = x[0];

            for (int i = 0; i < x.Length; i++)
            {
                if (enBuyuk < x[i])
                {
                    enBuyuk = x[i];
                }
                if (enKucuk > x[i])
                {
                    enKucuk = x[i];
                }
            }
            return enBuyuk - enKucuk;
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi = new int[5];

            Random rastgele = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rastgele.Next(1, 101);
            }
            Console.Write("Dizi: [");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i]);

                if (i < dizi.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]\n");

            int fark = FarkBul(dizi);

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine($"Dizideki en büyük ve en küçük değerler arasındaki fark: {fark}");
            Console.WriteLine("--------------------------------------------------------------\n");
        }
    }
}
