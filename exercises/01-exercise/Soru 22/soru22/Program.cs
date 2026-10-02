using System;
using System.Net.Mail;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan alınan sayının kaç basamaklı olduğunu bulan programı yazınız. (örn. 3456 → 4 basamaklıdır.)

        Console.Write("\n\nBir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        sayi = Math.Abs(sayi);

        int basamak_sayisi = 0;

        Console.WriteLine("\n----- SONUÇ -----");

        if (sayi == 0)
        {
            basamak_sayisi = 1;
        }
        else
        {
            while (sayi > 0)
            {
                sayi = sayi / 10;
                basamak_sayisi++;
            }
        }
        Console.WriteLine($"\nGirdiğiniz sayı {basamak_sayisi} basamaklı bir sayıdır.\n");
    }
}
