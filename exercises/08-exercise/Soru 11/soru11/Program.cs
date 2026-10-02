using System;

class Program
{
    /*
    Herhangi bir sayının herhangi bir dereceden kuvvetini (üssünü) bulan metodu yazınız.
    Örnek:
    metot(2,3) -> 2^3 = 8
    */

    static double UsHesaplama(int taban, int us)
    {
        double sonuc = 1;

        if (taban != 0 && us == 0)
        {
            return 1;
        }
        else if (us > 0)
        {
            for (int i = 1; i <= us; i++)
            {
                sonuc *= taban;
            }
        }
        else if (us < 0)
        {
            for (int i = us; i < 0; i++)
            {
                sonuc *= (double)1 / taban;
            }
        }
        return sonuc;
    }
    static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Taban sayısını giriniz: ");
        int alinanTaban;
        while (!int.TryParse(Console.ReadLine(), out alinanTaban))
        {
            Console.Write("\nLütfen geçerli bir tamsayı giriniz: ");
        }
        
        Console.Write("\nÜs sayısını giriniz: ");
        int alinanUs;
        while (!int.TryParse(Console.ReadLine(), out alinanUs))
        {
            Console.Write("\nLütfen geçerli bir tamsayı giriniz: ");
        }

        if (alinanTaban == 0 && alinanUs <= 0)
        {
            Console.WriteLine($"\n{alinanTaban}^{alinanUs} matematiksel olarak tanımsızdır.\n");
            return;
        }

        double nihayiSonuc = UsHesaplama(alinanTaban, alinanUs);
        Console.WriteLine($"\n{alinanTaban}^{alinanUs} = {nihayiSonuc}\n");
    }
}
