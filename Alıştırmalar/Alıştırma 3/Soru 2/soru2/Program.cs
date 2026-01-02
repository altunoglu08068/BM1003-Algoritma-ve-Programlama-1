/*
Rastgele sayılarla oluşturulan 20 elemanlı bir dizinin, elemanlarından kaç tanesinin dışarıdan
girilen bir sayıdan küçük olduğunu bulunuz.
*/

using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        int[] dizi = new int[20];
        Random rastgele = new Random();

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rastgele.Next(0, 21);
        }

        int sinir;

        Console.Write("\nBir sınır değeri girin. (0 - 20): ");

        while (!int.TryParse(Console.ReadLine(), out sinir) || sinir < 0 || sinir > 20)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n⚠️ Bir şeyler ters gitti...");
            Console.ResetColor();
            
            Console.Write("\nLütfen bir sayı girin. (0 - 20): ");
        }

        int sayac = 0;

        Console.Write("\nDizi: [");

        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write(dizi[i]);
            if (i < dizi.Length - 1)
            {
                Console.Write(", ");
            }
            if (dizi[i] < sinir)
            {
                sayac++;
            }
        }
        Console.WriteLine("]");

        Console.WriteLine($"\n----------------------------------------");
        Console.WriteLine($"Girdiğiniz ({sinir}) sayısından küçük olan");
        Console.WriteLine($"Toplam {sayac} adet sayı bulundu.");
        Console.WriteLine($"----------------------------------------\n");
    }
}
