using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Kullanıcıdan sıcaklık türü (Santigrat için C, Fahrenheit için F) ve sıcaklık değeri alınız.
        Eğer tür C ise, girilen sıcaklığı Fahrenheit’a;
        eğer tür F ise, girilen sıcaklığı Santigrat’a dönüştürüp ekrana yazdırınız.
        Geçersiz tür girilirse “Hatalı seçim!” mesajı veriniz.
        */

        Console.Write("\n\nSıcaklık türünü giriniz (C / F): ");
        char derece_turu = Char.ToUpper(Convert.ToChar(Console.ReadLine() ?? ""));

        Console.WriteLine();

        Console.Write("Sıcaklık değerini giriniz: ");
        double sayi = Convert.ToDouble(Console.ReadLine());

        const double C_donma_derecesi = 0;
        const double C_kaynama_derecesi = 100;

        const double F_donma_derecesi = 32;
        const double F_kaynama_derecesi = 212;

        Console.WriteLine("\n----- SONUÇ -----");

        if (derece_turu == 'C')
        {
            double x = ((F_kaynama_derecesi * (C_kaynama_derecesi - C_donma_derecesi)) - ((F_kaynama_derecesi - F_donma_derecesi) * (C_kaynama_derecesi - sayi))) / (C_kaynama_derecesi - C_donma_derecesi);
            Console.WriteLine($"\n{x} °F\n");
        }
        else if (derece_turu == 'F')
        {
            double y = ((C_kaynama_derecesi * (F_kaynama_derecesi - F_donma_derecesi)) - ((C_kaynama_derecesi - C_donma_derecesi) * (F_kaynama_derecesi - sayi))) / (F_kaynama_derecesi - F_donma_derecesi);
            Console.WriteLine($"\n{y} °C\n");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nYanlış tür girdiniz!\n");
            Console.ResetColor();
        }
    }
}
