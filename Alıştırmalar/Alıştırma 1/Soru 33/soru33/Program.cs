using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Taksi ücreti: Açılış 30 TL + km başı 12 TL. 
        Eğer saat (0–23) 22–06 arasındaysa toplam ücrete %20 gece zammı uygulayınız.
        */

        Console.WriteLine("\n\n---------- Taksi Ücreti Hesaplama ----------\n");

        const double acilis_ucreti = 30;
        const double km_basi_ucret = 12;

        Console.Write("Yolculuk saatini giriniz (0-23): ");
        int saat = Convert.ToInt32(Console.ReadLine());

        Console.Write("Yolculuk mesafesini giriniz (km): ");
        double mesafe = Convert.ToDouble(Console.ReadLine());

        double toplam_ucret = acilis_ucreti + (mesafe * km_basi_ucret);

        if (saat >= 22 || saat < 6)
        {
            toplam_ucret *= 1.20;
        }

        Console.WriteLine($"-----------------------------");
        Console.WriteLine($"Hesaplanan Tutar: {toplam_ucret} TL");
    }
}