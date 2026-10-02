using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Kullanıcıdan toplam dakika alınız; saat ve dakika cinsinden yazdırınız.
        (Örn. 135 → 2 saat 15 dakika).
        */

        Console.Write("\n\nToplam dakikayı giriniz: ");
        int dakika = Convert.ToInt32(Console.ReadLine());

        int saat = dakika / 60;
        int kalan_dakika = dakika % 60;

        if (kalan_dakika == 0)
        {
            Console.WriteLine($"\nToplam dakika: {dakika} = {saat} saat\n");
        }
        else
        {
            Console.WriteLine($"\nToplam dakika: {dakika} = {saat} saat {kalan_dakika} dakika\n");
        }
    }
}
