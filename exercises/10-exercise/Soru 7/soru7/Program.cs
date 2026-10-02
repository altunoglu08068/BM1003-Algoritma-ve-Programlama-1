/*
Bir dizideki ilk ve son elemanların yerini değiştiren ve yeni diziyi
döndüren bir metot yazınız.
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static int[] Degistir(int[] x)
        {
            int gecici = x[0];

            x[0] = x[x.Length - 1];
            x[x.Length - 1] = gecici;

            return x;
        }

        static void DiziYazdir(int[] x)
        {
            Console.Write("[");
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

            int[] dizi = new int[5];

            Random rastgele = new Random();

            Console.WriteLine("----- Dizi -----\n");

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rastgele.Next(0, 11);
            }

            DiziYazdir(dizi);

            Console.WriteLine("----- Yeni Dizi -----\n");

            dizi = Degistir(dizi);

            DiziYazdir(dizi);
        }
    }
}
