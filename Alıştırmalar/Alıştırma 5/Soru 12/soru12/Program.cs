// Bir diziyi parametre olarak alan ve bu diziyi tersine çeviren bir metot yazınız.

using System;

namespace MyApp
{
    internal class Program
    {
        static int[] TersCevir(int[] dizi)
        {
            if (dizi.Length == 0)
            {
                return dizi;
            }

            int[] tersDizi = new int[dizi.Length];

            for (int i = 0; i < tersDizi.Length; i++)
            {
                tersDizi[i] = dizi[dizi.Length - 1 - i];
            }

            return tersDizi;
        }

        static void DiziYazdir(int[] dizi, string mesaj)
        {
            Console.Write($"{mesaj}: [");

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
        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi = new int[5];

            Random rnd = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0, 11);
            }

            int[] tersDizi = TersCevir(dizi);

            Console.WriteLine("\n---------------------------------");
            DiziYazdir(dizi, "Orijinal dizi\t");
            Console.WriteLine();
            DiziYazdir(tersDizi, "Ters hali\t");
            Console.WriteLine("---------------------------------\n");
        }
    }
}