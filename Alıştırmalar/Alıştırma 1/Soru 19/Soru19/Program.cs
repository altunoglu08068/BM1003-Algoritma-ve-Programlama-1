using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan bir sayı alınız. Sayı negatifse işaretini pozitife çevirerek mutlak değerini ekrana yazdırınız.

        Console.Write("\n\nBir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int mutlak = Math.Abs(sayi);

        Console.WriteLine($"\nSonuç: {mutlak}\n");
    }
}
