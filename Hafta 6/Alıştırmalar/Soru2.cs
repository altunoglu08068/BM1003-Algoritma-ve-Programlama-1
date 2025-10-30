using System;

class Program
{
    static void Main(string[] args)
    {

        // Kullanıcıdan alınan bir sayı uzunluğunda olan ve rastgele sayılardan oluşan bir dizinin en büyük ve en küçük elemanını bulunuz.

        Console.Write("\nBir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int[] dizi = new int[sayi];
        Random r = new Random();

        Console.Write("\n[");

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = r.Next(0, 101);
            Console.Write(dizi[i]);

            if (i < dizi.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.Write("]\n\n");

        int en_buyuk = int.MinValue;
        int en_kucuk = int.MaxValue;

        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] > en_buyuk)
            {
                en_buyuk = dizi[i];
            }

            if (dizi[i] < en_kucuk)
            {
                en_kucuk = dizi[i];
            }
        }
        Console.WriteLine($"Dizinin en büyük elemanı: {en_buyuk}");
        Console.WriteLine($"Dizinin en küçük elemanı: {en_kucuk}\n");
    }
}
