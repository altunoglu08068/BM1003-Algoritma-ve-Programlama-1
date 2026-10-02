/*
2x2 boyutunda bir matrisi parametre olarak alan ve transpozunu alıp sonucu geriye döndüren
bir metot yazınız.
*/

using System;

class Program
{
    static void MatrisDoldur(int[,] x)
    {
        Random rastgele = new Random();
        
        for (int i = 0; i < x.GetLength(0); i++)
        {
            for (int j = 0; j < x.GetLength(1); j++)
            {
                x[i, j] = rastgele.Next(0, 11);
            }
        }
    }

    static void MatrisYazdir(int[,] x)
    {
        for (int i = 0; i < x.GetLength(0); i++)
        {
            Console.Write("[");
            for (int j = 0; j < x.GetLength(1); j++)
            {
                Console.Write($"{x[i, j], 3}");
                if (j < x.GetLength(1) - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
    }

    static int[,] TranspozAl(int[,] matris)
{
    int satirSayisi = matris.GetLength(0);
    int sutunSayisi = matris.GetLength(1);

    int[,] transpoz = new int[sutunSayisi, satirSayisi];

    for (int i = 0; i < satirSayisi; i++)
    {
        for (int j = 0; j < sutunSayisi; j++)
        {
            transpoz[j, i] = matris[i, j];
        }
    }
    return transpoz;
}

    static void Main(string[] args)
    {
        int[,] matris = new int[2, 2];

        Console.Clear();

        MatrisDoldur(matris);

        Console.WriteLine("--------- 2 x 2'lik Matris ---------\n");
        
        MatrisYazdir(matris);

        int[,] transpozluHali = TranspozAl(matris);

        Console.WriteLine("\n--------- Matrisin Transpozu Alınmış Hali ---------\n");
        
        MatrisYazdir(transpozluHali);

        Console.WriteLine();
    }
}