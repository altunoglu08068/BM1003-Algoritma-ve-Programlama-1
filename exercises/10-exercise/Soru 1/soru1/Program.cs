/*
2 tane 3x3 boyutundaki matrisi parametre olarak alıp toplayan ve sonucu geri döndüren bir
metot yazınız.
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static int[,] MatrisTopla(int[,] x, int[,] y)
        {
            int satirSayisi = x.GetLength(0);
            int sutunSayisi = x.GetLength(1);
            int[,] yeniMatris = new int[satirSayisi, sutunSayisi];

            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < sutunSayisi; j++)
                {
                    yeniMatris[i, j] = x[i, j] + y[i, j];
                }
            }
            return yeniMatris;
        }

        static void MatrisYazdir(int[,] matris, string baslik)
        {
            Console.WriteLine($"\n------------- {baslik} -------------\n");
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                Console.Write("\t[");
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write($"{matris[i, j],4}");

                    if (j < matris.GetLength(1) - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("]");
            }
        }

        static void MatrisDoldur(int[,] matris, Random rastgele)
        {
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = rastgele.Next(-10, 11);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int[,] matris1 = new int[3, 3];
            int[,] matris2 = new int[3, 3];

            Random rastgele = new Random();

            MatrisDoldur(matris1, rastgele);
            MatrisDoldur(matris2, rastgele);

            MatrisYazdir(matris1, "MATRİS 1");
            MatrisYazdir(matris2, "MATRİS 2");

            int[,] toplamMatris = MatrisTopla(matris1, matris2);
            MatrisYazdir(toplamMatris, "TOPLAM");

            Console.WriteLine("\n");
        }
    }
}