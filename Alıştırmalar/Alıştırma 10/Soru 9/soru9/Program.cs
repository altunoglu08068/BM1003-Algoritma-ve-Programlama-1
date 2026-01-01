/*
Bir tam sayı dizisinin tüm öğelerinin toplamını hesaplayan bir C# programı yazın.
Test Verileri:
Dizi1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7,8, 8, 1, 1]
Örnek Çıktı
Toplamı : 70
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static int Toplam(int[] x)
        {
            int toplam = 0;

            for (int i = 0; i < x.Length; i++)
            {
                toplam += x[i];
            }
            return toplam;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1, 1 };

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

            int elemanToplam = Toplam(dizi);

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Dizinin elemalarının toplamı: {elemanToplam}");
            Console.WriteLine("--------------------------------\n");
        }
    }
}
