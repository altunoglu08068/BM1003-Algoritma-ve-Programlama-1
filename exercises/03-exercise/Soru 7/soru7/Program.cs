using System;

class Program
{
    /*
    10 elemanlı bir sayı dizisinde en küçük elemanının bu dizinin kaçıncı elemanı olduğunu bulan
    programı yazınız.
    */
    static void Main(string[] args)
    {
        Console.Clear();
        int[] dizi = new int[10];
        Random rastgele = new Random();

        int sira = 0;
        int enKucuk = int.MaxValue;

        Console.WriteLine("-------------------- DİZİ --------------------\n");

        Console.Write("[");
        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rastgele.Next(0, 101);
            Console.Write(dizi[i]);

            if (i < dizi.Length - 1)
            {
                Console.Write(", ");
            }
            if (dizi[i] < enKucuk)
            {
                enKucuk = dizi[i];
                sira = i + 1;
            }
        }
        Console.WriteLine("]\n");

        Console.WriteLine("----------------------------------------------");

        Console.WriteLine($"Dizinin en küçük elemanı: {enKucuk}");
        Console.WriteLine($"Sıra: {sira}");
        Console.WriteLine("----------------------------------------------\n");
    }
}
