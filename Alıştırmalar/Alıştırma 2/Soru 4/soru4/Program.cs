using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        1 ile 1000 arasındaki sayılardan 12 ye tam bölünenlerin ortalamasını hesaplayıp ekrana
        yazdıran programı yazınız.
        */

        int toplam = 0;
        int sayac = 0;

        for (int i = 1; i <= 1000; i++)
        {
            if (i % 12 == 0)
            {
                sayac++;
                toplam += i;
            }
        }
        double ortalama = (double)toplam / sayac;
        Console.WriteLine($"1 ile 1000 arasındaki 12'ye tam bölünen sayıların ortalaması: {ortalama}");
    }
}
