using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        int[] dizi = new int[10];
        Random rastgele = new Random();

        int toplam1 = 0;
        int toplam2 = 0;

        Console.WriteLine("----------------- DİZİ -------------------");
        
        Console.Write("[");

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rastgele.Next(0, 101);

            Console.Write(dizi[i]);

            toplam1 += dizi[i];

            if (i < dizi.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.Write("]");

        int enBuyuk = dizi[0]; 
        int enKucuk = dizi[0];
        
        for (int i = 1; i < dizi.Length; i++)
        {
            if (dizi[i] > enBuyuk)
            {
                enBuyuk = dizi[i];
            }
            if (dizi[i] < enKucuk)
            {
                enKucuk = dizi[i];
            }
        }

        double ortalama1 = (double)toplam1 / dizi.Length;

        toplam2 = enBuyuk + enKucuk;
        double ortalama2 = (double)toplam2 / 2;
        
        double fark = ortalama1 - ortalama2; 

        Console.WriteLine("\n------------------------------------------");

        Console.WriteLine($"\nEn büyük sayı: {enBuyuk}");
        Console.WriteLine($"En küçük sayı: {enKucuk}\n");

        Console.WriteLine($"Sayıların ortalaması: {ortalama1:F2}");
        Console.WriteLine($"En büyük ve en küçük sayının ortalaması: {ortalama2:F2}");
        
        Console.WriteLine($"\nOrtalamaların farkı: {fark:F2}");

        Console.WriteLine("------------------------------------------\n");
    }
}