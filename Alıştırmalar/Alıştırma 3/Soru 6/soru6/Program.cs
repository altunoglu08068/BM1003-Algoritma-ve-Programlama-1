using System;

class Program
{
    /*
    0 ve 100 arasındaki rastgele sayılarla oluşturulan 20 elemanlı bir dizinin elemanlarının, 50’den
    büyük olanların toplamının 50'den küçük olanların toplamına oranını hesaplayınız.
    */
    static void Main(string[] args)
    {
        Console.Clear();

        int[] dizi = new int[20];
        Random rastgele = new Random();

        int kucuk = 0;
        int buyuk = 0;

        int toplamKucuk = 0;
        int toplamBuyuk = 0;

        Console.WriteLine("----------------------------------- DİZİ ---------------------------------------");
        Console.Write("[");
        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rastgele.Next(0, 101);
            Console.Write(dizi[i]);

            if (i < dizi.Length - 1)
            {
                Console.Write(", ");
            }

            if (dizi[i] < 50)
            {
                kucuk++;
                toplamKucuk += dizi[i];
            }
            if (dizi[i] > 50)
            {
                buyuk++;
                toplamBuyuk += dizi[i];
            }
        }
        Console.Write("]");

        Console.WriteLine("\n--------------------------------------------------------------------------------");

        Console.WriteLine($"50'den büyük sayıların toplamı: {toplamBuyuk}");
        Console.WriteLine($"50'den küçük sayıların toplamı: {toplamKucuk}");
        if (toplamKucuk > 0)
        {
            double oran = (double)toplamBuyuk / toplamKucuk; 
            Console.WriteLine($"\nOran (Büyük Toplam / Küçük Toplam): {oran:F2}"); 
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n⚠️ Oran hesaplanamaz (Bölen sayı 0).");
            Console.ResetColor();
        }

        Console.WriteLine("--------------------------------------------------------------------------------\n");
    }
}
