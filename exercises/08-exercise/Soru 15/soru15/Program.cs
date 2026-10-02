using System;
using System.Globalization;

class Program
{
    /*
    Bir dikdörtgenin 2 kenarını parametre olarak alan ve bu dikdörtgenin alanını ve çevresini
    hesaplayan programı yazınız.
    */

    static double AlanHesabi(double kenar1, double kenar2)
    {
        return kenar1 * kenar2;
    }
    static double CevreHesabi(double kenar1, double kenar2)
    {
        return 2 * (kenar1 + kenar2);
    }
    static double DogruVeriGirisi(string mesaj)
    {
        while (true)
        {
            Console.Write(mesaj);
            string giris = Console.ReadLine() ?? "";
            giris = giris.Replace(',', '.');

            if (double.TryParse(giris, NumberStyles.Any, CultureInfo.InvariantCulture, out double sayi) && sayi > 0)
            {
                return sayi;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n⚠️ Hata! ");
            Console.ResetColor();
            Console.WriteLine("\nLütfen geçerli, pozitif bir sayı giriniz.\n");
        }
    }
    static void Main(string[] args)
    {

        double k1 = DogruVeriGirisi("1. Dik Kenarı giriniz: ");
        double k2 = DogruVeriGirisi("\n2. Dik Kenarı giriniz: ");

        double alan = AlanHesabi(k1, k2);
        double cevre = CevreHesabi(k1, k2);

        Console.WriteLine("\n-----------------------------------");
        Console.WriteLine($"\nDikdörtgenin Alanı: {alan.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Dikdörtgenin Çevresi: {cevre.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine("-----------------------------------\n");
    }
}
