/*
2x2 boyutunda bir matrisi parametre olarak alan ve transpozunu alıp sonucu geriye döndüren
bir metot yazınız.
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
                Console.Write("[");
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write($"{matris[i, j],2}");

                    if (j < matris.GetLength(1) - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine("]");
            }
        }
        static int[,] TranspozAl(int[,] matris)
        {
            int[,] transpozMatris = new int[matris.GetLength(1), matris.GetLength(0)];

            for (int j = 0; j < matris.GetLength(1); j++)
            {
                for (int i = 0; i < matris.GetLength(0); i++)
                {
                    transpozMatris[j, i] = matris[i, j];
                }
            }
            return transpozMatris;
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int satirBoyutu = 2;
            int sutunBoyutu = 2;

            int[,] matris = new int[satirBoyutu, sutunBoyutu];

            Random rnd = new Random();

            Console.WriteLine("Orijinal Matris\n");

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = rnd.Next(1, 11);
                }
            }

            MatrisYazdir(matris);

            int[,] transpozMatris = TranspozAl(matris);

            Console.WriteLine("\n--------------------\n");

            Console.WriteLine("Transpoz Matris\n");

            MatrisYazdir(transpozMatris);

            Console.WriteLine();
        }
    }
}