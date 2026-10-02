using System;

class Program
{
    /*
    10 elemanlı bir sayı dizisinin en büyük ve en küçük elemanlarını ve kaçıncı sırada olduklarını
    bulan programı yazınız.
    */

    static void Main(string[] args)
    {
        Console.Clear();

        int[] dizi = new int[10];
        Random rastgele = new Random();

        Console.WriteLine("-------------- DİZİ -------------");

        Console.Write("\n[");

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rastgele.Next(0, 11);
            Console.Write(dizi[i]);

            if (i < dizi.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine("]\n");

        int enKucuk = dizi[0];
        int enBuyuk = dizi[0];
        int sayacEnBuyuk = 1;
        int sayacEnKucuk = 1;

        for (int i = 1; i < dizi.Length; i++)
        {
            if (dizi[i] > enBuyuk)
            {
                enBuyuk = dizi[i];
                sayacEnBuyuk = i + 1;
            }
            if (dizi[i] < enKucuk)
            {
                enKucuk = dizi[i];
                sayacEnKucuk = i + 1;
            }
        }

        Console.WriteLine("-----------------------------------------");

        Console.WriteLine($"En büyük sayı: {enBuyuk}");
        Console.WriteLine($"En küçük sayı: {enKucuk}\n");
        Console.WriteLine($"En büyük sayının sırası: {sayacEnBuyuk}");
        Console.WriteLine($"En küçük sayının sırası: {sayacEnKucuk}");

        Console.WriteLine("-----------------------------------------\n");
    }
}
