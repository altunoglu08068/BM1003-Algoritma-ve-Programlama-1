using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        A = [1, 2, 3, 4, 5, 6]
        dizisini elemanlarını yer değiştirerek aşağıdakiyi diziyi elde edin:
        A = [2, 1, 4, 3, 6, 5]
        
        1. A dizisini tanımla
        2. A dizisini ekrana yazdır
        3. A dizisinin elemanlarını yer değiştir. 0 1 2 3 4 5  0-1, 2-3, 4-5
        4. A dizisini ekrana yazdır
        */

        Console.WriteLine("\n\n----- DİZİ -----\n");

        int[] A = { 1, 2, 3, 4, 5, 6 };

        Console.Write("[");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i]);

            if (i < A.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write("]");

        Console.WriteLine("\n\n----- DİZİNİN ELEMANLARININ YER DEĞİŞTİRİLMİŞ HALİ -----\n");

        int gecici1 = A[0];
        A[0] = A[1];
        A[1] = gecici1;

        int gecici2 = A[2];
        A[2] = A[3];
        A[3] = gecici2;

        int gecici3 = A[4];
        A[4] = A[5];
        A[5] = gecici3;

        Console.Write("[");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i]);

            if (i < A.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write("]\n\n");
    }
}
