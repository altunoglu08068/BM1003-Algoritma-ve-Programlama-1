using System;

class Program
{
    /*
    Girilen 3 basamaklı bir sayının basamaklarının küplerinin toplamının kendisine eşit olup
    olmadığını kontrol eden bir metot yazınız.
    */

    static int BasamakKupToplami(int x)
    {
        int toplam = 0;

        int birler = x % 10;
        int onlar = x / 10 % 10;
        int yuzler = x / 100 % 10;

        int birlerKup = birler * birler * birler;
        int onlarKup = onlar * onlar * onlar;
        int yuzlerKup = yuzler * yuzler * yuzler;

        toplam = birlerKup + onlarKup + yuzlerKup;

        return toplam;
    }
    static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Üç basamaklı bir sayı giriniz: ");
        
        int sayi;
        
        while (!int.TryParse(Console.ReadLine(), out sayi) || sayi < 100 || sayi > 999)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n❌ Hatalı giriş!");
            Console.ResetColor();
            Console.Write("\nLütfen üç basamaklı bir sayı giriniz: ");
        }

        int KupToplam = BasamakKupToplami(sayi);

        Console.WriteLine($"\n\nGirdiğiniz {sayi} sayısının basamaklarının küplerinin toplamı: {KupToplam}\n");

        if (sayi == KupToplam)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(new string('-', 64));
            Console.WriteLine("\n✅ Girdiğiniz sayı, basamaklarının küplerinin toplamına eşittir.\n");
            Console.WriteLine(new string('-', 64));
            Console.WriteLine();
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('-', 69));
            Console.WriteLine("\n⚠️ Girdiğiniz sayı, basamaklarının küplerinin toplamına eşit değildir.\n");
            Console.WriteLine(new string('-', 69));
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
