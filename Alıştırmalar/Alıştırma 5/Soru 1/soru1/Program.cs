/*
2 tane 3x3 boyutundaki matrisi parametre olarak alıp toplayan ve sonucu geri döndüren bir
metot yazınız.
*/

using System;

namespace MyApp
{
    internal class Program
    {
        static void MatrisYazdir(int[,] matris)
        {
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                Console.Write("\t[");

                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write($"{matris[i, j],4}");

                    if (j < matris.GetLength(1) - 1)
                    {
                        Console.Write(",");
                    }
                }

                Console.WriteLine("]");
            }
        }
        static int[,] MatrisTopla(int[,] matris1, int[,] matris2)
        {
            int satirBoyutu = matris1.GetLength(0);
            int sutunBoyutu = matris1.GetLength(1);

            int[,] sonucMatris = new int[satirBoyutu, sutunBoyutu];

            for (int i = 0; i < sonucMatris.GetLength(0); i++)
            {
                for (int j = 0; j < sonucMatris.GetLength(1); j++)
                {
                    sonucMatris[i, j] = matris1[i, j] + matris2[i, j];
                }
            }

            return sonucMatris;
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int satirBoyutu = 3;
            int sutunBoyutu = 3;

            int[,] matris1 = new int[satirBoyutu, sutunBoyutu];
            int[,] matris2 = new int[satirBoyutu, sutunBoyutu];

            Random rnd = new Random();

            // Matris 1 doldurma
            for (int i = 0; i < matris1.GetLength(0); i++)
            {
                for (int j = 0; j < matris1.GetLength(1); j++)
                {
                    matris1[i, j] = rnd.Next(1, 11);
                }
            }

            // Matris 2 doldurma
            for (int i = 0; i < matris2.GetLength(0); i++)
            {
                for (int j = 0; j < matris2.GetLength(1); j++)
                {
                    matris2[i, j] = rnd.Next(1, 11);
                }
            }

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("\n\tMatris 1\n");
            MatrisYazdir(matris1);

            Console.WriteLine("\n-----------------------------------");

            Console.WriteLine("\n\tMatris 2\n");
            MatrisYazdir(matris2);

            Console.WriteLine("\n-----------------------------------");

            int[,] toplamMatris = MatrisTopla(matris1, matris2);

            Console.WriteLine("\n\tToplam Matris\n");
            MatrisYazdir(toplamMatris);

            Console.WriteLine("\n-----------------------------------");

            Console.WriteLine();
        }
    }
}