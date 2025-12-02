using System;
using System.Globalization;

class Program
{
    static double DaireninCevresi(double r)
    {
        double cevre = 2 * Math.PI * r;
        return cevre;
    }
    static double DaireninAlani(double r)
    {
        double alan = Math.PI * r * r;
        return alan;
    }

    static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Yarıçap giriniz (Örn: 5.5 veya 5,5): ");
        double sayi;

        string giris = (Console.ReadLine() ?? "").Replace(',', '.');

        while (!double.TryParse(giris, NumberStyles.Any, CultureInfo.InvariantCulture, out sayi) || sayi <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("⚠️ Geçersiz giriş. Lütfen pozitif bir sayı giriniz: ");
            Console.ResetColor();

            giris = (Console.ReadLine() ?? "").Replace(',', '.');
        }

        double cevrex = DaireninCevresi(sayi);
        double alany = DaireninAlani(sayi);

        Console.WriteLine("\n-------------------------");
        Console.WriteLine($"Dairenin Çevresi: {cevrex:F2}");
        Console.WriteLine($"Dairenin Alanı  : {alany:F2}");
        Console.WriteLine("-------------------------\n");
    }
}