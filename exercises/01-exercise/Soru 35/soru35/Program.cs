using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Kullanıcıdan vize ve final notlarını alınız.
        Ortalama, vize × 0.4 + final × 0.6 formülüyle hesaplanacaktır.
        Hesaplanan ortalamaya göre harf notunu belirleyiniz:
        90 ve üzeri → AA
        80–89 → BA
        70–79 → BB
        60–69 → CB
        50–59 → CC
        50’den düşük → FF
        Sonuç olarak ekrana “Ortalama = …, Harf Notu = …” şeklinde yazdırınız.
        */

        Console.WriteLine("\n\n------ Not Hesaplama Programı ------\n");

        Console.Write("Vize notunu giriniz: ");
        double vize;
        while (!double.TryParse(Console.ReadLine(), out vize) || vize < 0 || vize > 100)
        {
            Console.WriteLine("\nGeçersiz giriş! Lütfen 0 ile 100 arasında bir sayı giriniz.");
            Console.Write("\nVize notunu giriniz: ");
        }

        Console.Write("\nFinal notunu giriniz: ");
        double final;
        while (!double.TryParse(Console.ReadLine(), out final) || final < 0 || final > 100)
        {
            Console.WriteLine("\nGeçersiz giriş! Lütfen 0 ile 100 arasında bir sayı giriniz.");
            Console.Write("\nFinal notunu giriniz: ");
        }

        double ortalama = (vize * 0.4) + (final * 0.6);

        string harfNotu;
        if (ortalama >= 90)
        {
            harfNotu = "AA";
        }
        else if (ortalama >= 80)
        {
            harfNotu = "BA";
        }
        else if (ortalama >= 70)
        {
            harfNotu = "BB";
        }
        else if (ortalama >= 60)
        {
            harfNotu = "CB";
        }
        else if (ortalama >= 50)
        {
            harfNotu = "CC";
        }
        else
        {
            harfNotu = "FF";
        }

        Console.WriteLine($"\nOrtalama = {ortalama:F2}, Harf Notu = {harfNotu}\n");
    }
}
