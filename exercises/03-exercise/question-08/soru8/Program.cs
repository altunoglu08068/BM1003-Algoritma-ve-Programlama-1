using System;

class Program
{
    /*
    100 elemanlı bir dizi tanımlayınız. Bu diziye 0-10 arasında rastgele sayılar atayın. Dizideki
    elemanların ortalamasını bulup, dizi elemanlarından kaç tanesinin elde edilen bu ortalama
    değerine eşit olduğunu hesaplayınız.
    */
    static void Main(string[] args)
    {
        Console.Clear();

        int[] dizi = new int[100];
        Random rastgele = new Random();
        int toplam = 0;

        Console.WriteLine("---------- DİZİ ----------\n");

        Console.Write("[");

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rastgele.Next(0, 11);
            Console.Write(dizi[i]);
            toplam += dizi[i];

            if (i < dizi.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]\n");

        int ortalama = toplam / dizi.Length;
        int sayac = 0;

        for (int i = 0; i < dizi.Length; i++)
        {
            if (ortalama == dizi[i])
            {
                sayac++;
            }
        }

        Console.WriteLine("--------------------------");

        Console.WriteLine($"Dizideki elemanların ortalaması: {ortalama}");
        Console.WriteLine($"Ortalamaya eşit olan elemanların adedi: {sayac}");

        Console.WriteLine("--------------------------\n");
    }
}
