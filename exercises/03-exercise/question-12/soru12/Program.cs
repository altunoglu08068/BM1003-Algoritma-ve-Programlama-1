// 2 boyutlu bir diziyi tek boyutlu bir diziye çeviren programı yazınız.

using System;

namespace Program
{
    internal class ProgramClass
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // 2 x 2'lik bir matris oluşturulup yazdır.

            int[,] matris = new int[2, 2];

            Random rastgele = new Random();

            Console.WriteLine("----- İki Boyutlu Matris -----\n");

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                Console.Write("\t  [");
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = rastgele.Next(0, 11);
                    Console.Write($"{matris[i, j], 2}");

                    if (j < matris.GetLength(1) - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("]");
            }

            Console.WriteLine();

            // Tek boyutlu diziye dönüştür.
            
            int[] dizi = new int[matris.Length];
            int index = 0;

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    dizi[index] = matris[i, j];
                    index++;
                }
            }

            // Oluşan diziyi yazdır.

            Console.WriteLine("\n------ Tek Boyutlu Hali ------\n");

            Console.Write("\t[");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i]);
                if (i < dizi.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]\n\n");
        }
    }
}
