using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\nKaç adet sayı üretilsin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n----- DİZİNİN ELEMANLARI -----\n");

        int[] dizi = new int[sayi];
        Random r = new Random();
        int toplam = 0;

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = r.Next(0, 101);
            toplam += dizi[i];
        }

        for (int i = 0; i < dizi.Length; i++)
        {
            Console.WriteLine($"{i + 1}. dizi elemanı: {dizi[i]}");
        }
        Console.WriteLine();

        double ortalama = (double)toplam / sayi;
        Console.WriteLine($"Dizideki elemanların ortalaması: {ortalama}\n");
    }
}
