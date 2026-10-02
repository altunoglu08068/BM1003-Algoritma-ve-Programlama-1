/*
10 elemanlı bir tam sayı dizisini kullanıcıdan alınan değerlerle dolduran ve dizideki elemanları
yazdıran kodu yazınız.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        int[] dizi = new int[10];

        int sayi;

        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write($"\nDizinin {i + 1}. elemanını girin: ");
            while (!int.TryParse(Console.ReadLine(), out sayi))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ Bir şeyler ters gitti...");
                Console.ResetColor();

                Console.Write("\nLütfen tekrar deneyin: ");
            }
            dizi[i] = sayi;
        }
        Console.Write("\n\nDizi: ");
        Console.Write("[");

        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write(dizi[i]);

            if (i < dizi.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]\n");
    }
}
