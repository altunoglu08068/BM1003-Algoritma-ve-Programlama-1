using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nMerhaba Kerem!\n");

        Console.Write("Dizinin uzunluğunu giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        int[] dizi = new int[sayi];
        Random r = new Random();

        Console.WriteLine("\n----- Dizinin İlk Hali -----\n");

        Console.Write("[");
        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = r.Next(0, 101);
            Console.Write(dizi[i]);

            if (i < dizi.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write("]");

        Console.WriteLine("\n\n----- Dizinin Sonraki Hali -----\n");
        
        Array.Reverse(dizi);
        Console.Write("[");

        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write(dizi[i]);

            if (i < dizi.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write("]\n\n");
    }
}
