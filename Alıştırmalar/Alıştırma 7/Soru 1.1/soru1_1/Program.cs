using System;
using System.Formats.Asn1;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        /*
        Soru 1’de oluşturduğunuz matrisin asal köşegenleri üzerindeki sayıların
        toplamını ekrana yazdırın.
        */

        Console.Write("\n\nBir N (tamsayı) giriniz: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int[,] matris = new int[N, N];
        Random r = new Random();

        Console.WriteLine("\n----- MATRİS -----\n");
        for (int i = 0; i < N; i++)
        {
            Console.Write("[");
            for (int j = 0; j < N; j++)
            {
                matris[i, j] = r.Next(-9, 10);
                Console.Write($"{matris[i, j],3}");

                if (j < N - 1)
                {
                    Console.Write(" , ");
                }
            }
            Console.Write("]");
            Console.WriteLine();
        }
        Console.WriteLine();

        int asal_kosegen_toplami = 0;
        bool ilk = true;

        Console.Write("Asal köşegen toplamı: ");

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i == j)
                {
                    asal_kosegen_toplami += matris[i, j];

                    if (ilk)
                    {
                        Console.Write($"{matris[i, j]}");
                        ilk = false;
                    }
                    else if (matris[i, j] < 0)
                    {
                        Console.Write($" + ({matris[i, j]})");
                    }
                    else if (matris[i, j] > 0)
                    {
                        Console.Write($" + {matris[i, j]}");
                    }
                    else
                    {
                        Console.Write($" + {matris[i, j]}");
                    }
                }
            }
        }
        Console.WriteLine($" = {asal_kosegen_toplami}\n");
    }
}
