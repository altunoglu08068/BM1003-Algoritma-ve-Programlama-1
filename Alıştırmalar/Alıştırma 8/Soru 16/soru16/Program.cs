using System;
using System.Globalization;

class Program
{
    // s = x + y^2 denklemin sonucunu hesaplayan bir metot yazınız.

    static double Hesap(double x, double y)
    {
        double s = x + Math.Pow(y, 2);
        return s;
    }
    static double GuvenliGiris(string mesaj)
    {

        while (true)
        {
            Console.Write(mesaj);
            string giris = Console.ReadLine() ?? "";
            giris = giris.Replace(',', '.');

            if (double.TryParse(giris, NumberStyles.Any, CultureInfo.InvariantCulture, out double sayi))
            {
                return sayi;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n⚠️ Hata! ");
            Console.ResetColor();
            Console.WriteLine("\nLütfen geçerli bir sayı giriniz.\n");
        }
    }
    static void Main(string[] args)
    {
        Console.Clear();

        double deger1 = GuvenliGiris("x değerini giriniz: ");
        double deger2 = GuvenliGiris("\ny değerini giriniz: ");

        double sonuc = Hesap(deger1, deger2);
        Console.WriteLine("\n---------------------");
        Console.WriteLine($"Sonuç: {sonuc.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine("---------------------\n");
    }
}
