using System;

class Program
{
    /*
    Bir sayı dizisini parametre olarak alan ve en büyük elemanı bulup geri döndüren metodu
    yazınız.
    */

    static int EnBuyukElamaniBul(int[,] x)
    {
        int enBuyuk = int.MinValue;

        for (int i = 0; i < x.GetLength(0); i++)
        {
            for (int j = 0; j < x.GetLength(1); j++)
            {
                if (x[i, j] > enBuyuk)
                {
                    enBuyuk = x[i, j];
                }
            }
        }
        return enBuyuk;
    }
    static void Main(string[] args)
    {
        Console.Clear();

        int[,] dizi = new int[3, 3];
        Random r = new Random();

        for (int i = 0; i < dizi.GetLength(0); i++)
        {
            Console.Write("[");
            for (int j = 0; j < dizi.GetLength(1); j++)
            {
                dizi[i, j] = r.Next(-10, 11);
                Console.Write($"{dizi[i, j], 4}");

                if (j < dizi.GetLength(1) - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
        int sonuc = EnBuyukElamaniBul(dizi);
        Console.WriteLine($"\nDizinin en büyük elemanı: {sonuc}\n");
    }
}
