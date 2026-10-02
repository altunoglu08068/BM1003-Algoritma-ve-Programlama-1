using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Soru 2’de tanımladığınız dizi (A) için:
        1. A dizisinin elemanlarını yer değiştirerek B dizisini oluştur.
        1 2 3 4 5 6 → 1-6, 2-5, 3-4
        1. B dizisini ekrana yazdır.
        */

        int[] A = new int[6];
        Console.Write("\n\nA: [");

        for (int i = 0; i < A.Length; i++)
        {
            A[i] = i + 1;
            Console.Write(A[i]);

            if (i < A.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");

        int[] B = new int[A.Length];
        for (int i = 0; i < A.Length; i++)
        {
            B[i] = A[A.Length - 1 - i];
        }

        Console.Write("\nB: [");
        for (int i = 0; i < B.Length; i++)
        {
            Console.Write(B[i]);
            if (i < B.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]\n");
    }
}
