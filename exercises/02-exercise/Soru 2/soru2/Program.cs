using System;

class Program
{
    static void Main(string[] args)
    {
        // 10 sayıyı kullanıcıdan alıp bunların ortalamasını ve toplamını bulan bir C# programı yazın.

        int toplam = 0;
        int sayiAdedi = 10;

        for (int i = 1; i <= sayiAdedi; i++)
        {
            Console.Write($"\nLütfen {i}. sayıyı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            toplam += sayi;
        }

        double ortalama = (double)toplam / sayiAdedi;
        
        Console.WriteLine("\n------------------------------------");
        Console.WriteLine($"\nGirilen sayıların toplamı: {toplam}");
        Console.WriteLine($"\nGirilen sayıların ortalaması: {ortalama:F2}");
        Console.WriteLine("\n------------------------------------");
    }
}
