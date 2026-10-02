using System;

class Program
{
    static void Main(string[] args)
    {
        // İki tamsayı a ve b (b ≠ 0) için bölüm ve kalanı hesaplayıp yazdırınız.

        Console.Write("\n\na sayısını giriniz: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nb sayısını giriniz: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n----- SONUÇ -----");

        if (b != 0)
        {
            double bolum = (double)a / b;
            int kalan = a % b;
        
            Console.WriteLine($"\nBölüm: {bolum}");
            Console.WriteLine($"Kalan: {kalan}\n");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nSıfıra bölme hatası!\n");
            Console.ResetColor();
        }
    }
}
