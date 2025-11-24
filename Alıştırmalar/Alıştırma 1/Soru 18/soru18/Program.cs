using System;

class Program
{
    static void Main(string[] args)
    {
        // 3 dersten alınan notların ortalamasını bulan ve ortalama 50’nin altındaysa “Kaldı”, aksi halde “Geçti” yazan programı yazınız.

        Console.WriteLine("\n\nBilgilendirme: Geçmesi için ortalamanın 50 ve üzerinde olması gerekiyor.");

        int toplam = 0;
        int ders_sayisi = 3;

        for (int i = 1; i <= ders_sayisi; i++)
        {
            Console.Write($"\n{i}. ders notunu giriniz: ");
            int ders_notu = Convert.ToInt32(Console.ReadLine());
            toplam += ders_notu;
        }

        double ortalama = (double)toplam / ders_sayisi;

        Console.WriteLine("\n----- SONUÇ -----");
        Console.WriteLine($"\nOrtalama: {ortalama}");

        if (ortalama < 50)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nKaldı.\n");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nGeçti.\n");
            Console.ResetColor();
        }
    }
}
