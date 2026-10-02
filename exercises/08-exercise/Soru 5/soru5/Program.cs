using System;

class Program
{
    // Santigrat dereceyi Fahrenheit'e çeviren bir metot yazınız.

    static double Cevirme(double x)
    {
        double sonuc = (x * 1.8) + 32;
        return sonuc;
    }
    static void Main(string[] args)
    {
        Console.Write("\n\nSantigrat değerini giriniz: ");

        double Santigrat;

        while (!double.TryParse(Console.ReadLine(), out Santigrat))
        {
            Console.Write("\nGeçersiz giriş. Lütfen bir sayı giriniz: ");
        }

        double Fahrenheit = Cevirme(Santigrat);

        Console.WriteLine($"\n{Santigrat} °C = {Fahrenheit} °F\n");
    }
}
