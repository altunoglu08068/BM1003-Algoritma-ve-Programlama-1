using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\nDizinin Elemanlarını Yazdırma Programı\n\n");

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

        Console.WriteLine("-------- Ortalamadan Büyük Olanlar --------");

        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] > ortalama)
            {
                Console.WriteLine($"{i + 1}. dizi elemanı ortalamadan büyüktür: {dizi[i]}");
            }
        }
        Console.WriteLine();

        Console.WriteLine("-------- Ortalamaya Olan Uzaklık ---------");

        for (int i = 0; i < dizi.Length; i++)
        {
            double uzaklik = Math.Abs(dizi[i] - ortalama);
            Console.WriteLine($"{i + 1}. dizi elemanının ortlamaya uzaklığı: {uzaklik}");
        }
        Console.WriteLine();

        Console.WriteLine("-------- Ortalamaya En Yakın Olan Dizinin Elemanı --------");

        double en_yakin_uzaklik = double.MaxValue;
        int en_yakin_indis = 0;

        for (int i = 0; i < dizi.Length; i++)
        {
            double uzaklik = Math.Abs(dizi[i] - ortalama);

            if (uzaklik < en_yakin_uzaklik)
            {
                en_yakin_uzaklik = uzaklik;
                en_yakin_indis = i;
            }
        }
        Console.WriteLine($"Dizinin ortalamaya en yakın elemanı {en_yakin_indis + 1}. elemandır ve değeri: {dizi[en_yakin_indis]}\n");
    }
}
