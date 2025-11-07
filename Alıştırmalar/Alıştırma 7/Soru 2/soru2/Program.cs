using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        A = [1, 2, 3, 4, 5, 6]
        
        1. A dizisini tanımla
        2. A dizisini ekrana yazdır.
        */

        int[] dizi = new int[6];

        Console.Write("\n\nA: [");

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = i + 1;
            Console.Write(dizi[i]);
            
            if (i < dizi.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]\n\n");
    }
}
