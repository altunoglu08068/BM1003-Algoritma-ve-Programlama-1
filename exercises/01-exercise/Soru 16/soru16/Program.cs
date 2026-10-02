using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan alınan sayının hem pozitif hem de çift olup olmadığını bulan programı yazınız.

        Console.Write("\n\nBir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi > 0 && sayi % 2 == 0)
        {
            Console.WriteLine($"\nGirdiğiniz {sayi} sayısı hem pozitif hem de çifttir.");
        }
        else
        {
            Console.WriteLine($"\nGirdiğiniz {sayi} sayısı hem pozitif hem de çift değildir.");
        }
    }
}