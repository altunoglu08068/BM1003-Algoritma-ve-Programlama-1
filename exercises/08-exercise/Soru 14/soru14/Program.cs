using System;
using System.Globalization;

class Program
{
    // Bir üçgenin iki dik kenarını parametre olarak alan ve hipotenüsünü hesaplayan bir metot yazınız.
    static double HipotenusHesapla(double kenar1, double kenar2)
    {
        return Math.Sqrt((kenar1 * kenar1) + (kenar2 * kenar2));
    }

    static double GuvenliGirisAl(string mesaj)
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
        Console.Clear();

        double k1 = GuvenliGirisAl("1. Dik Kenarı giriniz: ");
        double k2 = GuvenliGirisAl("\n2. Dik Kenarı giriniz: ");

        double sonuc = HipotenusHesapla(k1, k2);

        Console.WriteLine("\n------------------------------");
        Console.WriteLine($"Hipotenüs: {sonuc.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine("------------------------------\n");
    }
}