/*
2 x 3 boyutunda bir matris oluşturup, dışarıdan değer girilen ve matrisi ekrana yazdıran bir
program yazınız.
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static void MatrisYazdir(int[,] x)
        {
            int satir = x.GetLength(0);
            int sutun = x.GetLength(1);

            for (int i = 0; i < satir; i++)
            {
                Console.Write("[");
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write($"{x[i, j], 3}");
                    if (j < sutun - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("]");
            }
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int satirBoyut = 2;
            int sutunBoyut = 3;

            int[,] matris = new int[satirBoyut, sutunBoyut];

            for (int i = 0; i < satirBoyut; i++)
            {
                for (int j = 0; j < sutunBoyut; j++)
                {
                    Console.Write($"\n[{i + 1}, {j + 1}] elemanını girin: ");
                    int giris;
                    while (!int.TryParse(Console.ReadLine(), out giris))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n⚠️ HATA!");
                        Console.ResetColor();

                        Console.Write($"\n[{i + 1}, {j + 1}] elemanını tekrar girin: ");
                    }

                    matris[i, j] = giris;
                }
            }
            Console.WriteLine("\n----------------");
            MatrisYazdir(matris);
            Console.WriteLine("----------------\n");
        }
    }
}
