using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan alınan sayının 0 ile 100 arasında olup olmadığını kontrol eden programı yazınız.

        Console.Write("\n\nBir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n----- SONUÇ -----");

        if (sayi > 0 && sayi < 100)
        {
            Console.WriteLine($"\nGirdiğiniz {sayi} sayısı, 0 ile 100 arasındadır.\n");
        }
        else
        {
            Console.WriteLine($"\nGirdiğiniz {sayi} sayısı, 0 ile 100 arasında değildir.\n");
        }
    }
}
