using System;

class Program
{
    /*
    Bir tam sayının rakamlarının toplamını hesaplayan programı yazınız.
    Giriş Verileri:
    Bir tamsayı girin: 253
    Beklenen çıktı:
    Rakamların toplamı: 10
    */
    static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Bir tam satı giriniz: ");

        int sayi;
        int toplam = 0;

        while (!int.TryParse(Console.ReadLine(), out sayi))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n⚠️ Hatalı giriş!\n");
            Console.ResetColor();

            Console.Write("Tekrar deneyin: ");
        }
        Console.WriteLine("\n--------------------");
        Console.WriteLine($"Girdiğiniz sayı: {sayi}");

        while (sayi > 0)
        {
            int sonbasamak = sayi % 10;
            sayi /= 10;
            toplam += sonbasamak;
        }

        Console.WriteLine($"Rakamlar toplamı: {toplam}");
        Console.WriteLine("--------------------\n");
    }
}
