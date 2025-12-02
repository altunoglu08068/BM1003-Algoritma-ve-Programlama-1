using System;

class Program
{
    /*
    Parametre olarak ikili bir sayıyı alan ve bu sayıyı onluk tabana dönüştüren bir metot yazınız.
    Örnek:
    101 -> 5
    */
    static int IkiliktenOnlugaCevirme(int ikilikSayi)
    {
        int tabandegeri = 1;
        int toplam = 0;

        while (ikilikSayi > 0)
        {
            int SonBasamak = ikilikSayi % 10;
            
            ikilikSayi /= 10;

            if (SonBasamak == 1)
            {
                toplam += tabandegeri;
            }

            tabandegeri *= 2;
        }

        return toplam;
    }

    static bool SadeceSifirVeBirMi(int sayi)
    {
        while (sayi > 0)
        {
            int basamak = sayi % 10;

            if (basamak > 1)
            {
                return false;
            }

            sayi /= 10;
        }
        return true;
    }
    static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("İkilik tabanda bir sayı giriniz: ");
        int giris;
        while (!int.TryParse(Console.ReadLine(), out giris) || giris < 0 || !SadeceSifirVeBirMi(giris))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("\nGeçersiz giriş. (Şart: İkilik taban sıfır ve birlerden oluşur.)\n");
            Console.WriteLine("--------------------------------------------------------------");
            Console.ResetColor();
            Console.Write("İkilik tabanda bir sayı giriniz: ");
        }
        int onlukSayi = IkiliktenOnlugaCevirme(giris);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine($"\nİkilik tabandaki {giris} sayısının onluk tabandaki karşılığı: {onlukSayi}\n");
        Console.WriteLine("---------------------------------------------------------------");
        Console.ResetColor();
    }
}
