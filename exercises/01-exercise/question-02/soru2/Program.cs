using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Klavyeden girilen 3 basamaklı pozitif bir tam sayının basamakları toplamını bulan programı yazınız.
        Örnek: 123 sayısının basamakları toplam 1 + 2 + 3 = 6’dır.
        */

        Console.Write("\nÜç basamaklı bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int birler = sayi % 10;
        int onlar = sayi / 10 % 10;
        int yuzler = sayi / 100 % 10;
        int toplam = birler + onlar + yuzler;

        Console.WriteLine("\n------ SONUÇ ------");

        if (sayi >= 100 && sayi < 1000)
        {
            Console.WriteLine($"\nYüzler: {yuzler}, Onlar: {onlar}, Birler: {birler}");
            Console.WriteLine($"\nBasamkların Toplamı: {toplam}\n");
        }
        else
        {
            Console.WriteLine("\nÜzgünüm, girdiğiniz sayı üç basamaklı bir sayı değil.\n");
        }
    }
}
