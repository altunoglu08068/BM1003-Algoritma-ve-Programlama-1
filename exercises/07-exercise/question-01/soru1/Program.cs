using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        1. 2. Kullanıcıdan N (tamsayı) değerini alın.
        N x N boyutunda bir matris oluşturun.
        3. Matrisi -9 ile +9 arasında (dahil) rastgele sayılarla doldurun.
        4. Matrisi ekrana yazdırın. (5dk)
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
    }
}
