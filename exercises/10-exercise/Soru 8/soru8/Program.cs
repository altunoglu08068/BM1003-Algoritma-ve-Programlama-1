/*
İki tamsayı dizisinin karşılık gelen elemanlarını çarpmak için bir C# programı yazın.
Örnek Çıktı:
Dizi1: [1, 3, -5, 4]
Dizi2: [1, 4, -5, -2]
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static void DiziYazdir(int[] x)
        {
            Console.Write("[");

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"{x[i],3}");

                if (i < x.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]\n");
        }

        static int[] Carpma(int[] x, int[] y)
        {
            int[] yeniDizi = new int[x.Length];

            for (int i = 0; i < yeniDizi.Length; i++)
            {
                yeniDizi[i] = x[i] * y[i];
            }

            return yeniDizi;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int boyut = 4;

            int[] dizi1 = new int[boyut];
            int[] dizi2 = new int[boyut];

            Random rastgele = new Random();

            for (int i = 0; i < dizi1.Length; i++)
            {
                dizi1[i] = rastgele.Next(-10, 11);
                dizi2[i] = rastgele.Next(-10, 11);
            }
            Console.Write("Dizi 1\t: ");
            DiziYazdir(dizi1);

            Console.Write("Dizi 2\t: ");
            DiziYazdir(dizi2);

            int[] sonuc = Carpma(dizi1, dizi2);

            Console.WriteLine("-----------------------------------\n");
            Console.Write("Sonuç\t: ");
            DiziYazdir(sonuc);
            Console.WriteLine("-----------------------------------\n");
        }
    }
}
