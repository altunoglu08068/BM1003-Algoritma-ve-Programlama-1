using System;

class Program
{
    /*
    Pozitif bir sayıyı parametre olarak alan ve bu sayının kaç basamaklı olduğunu hesaplayıp geri
    döndüren bir metot tanımlayınız.
    */

    static int BasamakSayisiHesapla(int sayi)
    {
        if (sayi == 0)
        {
            return 1;
        }
        
        int basamak = 0;

        while (sayi != 0)
            {
                sayi /= 10;
                basamak++;
            }
        return basamak;
    }
    static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("\n\nLütfen pozitif bir sayı giriniz: ");

        int n;
        
        while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            Console.Write("\nLütfen pozitif bir sayı giriniz: ");
        }

        int BasamakSayisi = BasamakSayisiHesapla(n);
        
        Console.WriteLine("\n-----------------------------------");
        Console.WriteLine($"{n} sayısı {BasamakSayisi} basamaklıdır.");
        Console.WriteLine("-----------------------------------\n");
    }
}
