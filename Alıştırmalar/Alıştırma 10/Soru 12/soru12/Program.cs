// Bir diziyi parametre olarak alan ve bu diziyi tersine çeviren bir metot yazınız.

using System;

namespace Program
{
    internal class ProgramClass
    {
        static void TersCevir(int[] x)
        {
            for (int i = 0; i < x.Length / 2; i++)
            {
                int sagIndeks = x.Length - i - 1;
                int sakla = x[i];
                x[i] = x[sagIndeks];
                x[sagIndeks] = sakla;
            }
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

            int[] dizi = new int[5];
            Random rastgele = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rastgele.Next(0, 21);
            }

            DiziYazdir(dizi, "Orijinal Dizi\t\t");

            TersCevir(dizi);

            DiziYazdir(dizi, "Değiştirilmiş Dizi\t");
        }
    }
}
