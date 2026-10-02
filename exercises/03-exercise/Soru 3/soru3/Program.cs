using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Rastgele sayılarla oluşturulan 20 elemanlı bir dizinin çift olanlarının toplamının tek olanlarının
        toplamına oranını bulunuz.
        */

        Console.Clear();

        int[] dizi = new int[20];
        Random rastgele = new Random();

        int tekToplam = 0;
        int ciftToplam = 0;

        Console.Write("----- Dizi -----\n");

        Console.Write("\n[");
        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rastgele.Next(0, 21);
            Console.Write(dizi[i]);
            
            if (i < dizi.Length - 1)
            {
                Console.Write(", ");
            }
            if (dizi[i] % 2 == 0)
            {
                ciftToplam += dizi[i];
            }
            else
            {
                tekToplam += dizi[i];
            }
        }
        Console.WriteLine("]\n");

        Console.WriteLine("--------------------------------");

        Console.WriteLine($"Çiftlerin Toplamı: {ciftToplam}");
        Console.WriteLine($"Teklerin Toplamı : {tekToplam}");

        if (tekToplam != 0)
        {
            double oran = (double)ciftToplam / tekToplam;
            Console.WriteLine($"\nOran (Çift/Tek): {oran:F2}");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nOran hesaplanamadı (Bölen sayı 0). Hiç tek sayı yok!");
            Console.ResetColor();
        }
        Console.WriteLine("--------------------------------\n");
    }
}
