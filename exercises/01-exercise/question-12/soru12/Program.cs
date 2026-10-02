using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan 3 sayı alıp en büyüğünü bulan programı yazınız (if-else kullanarak).

        Console.Write("\n\nBir sayı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nBir sayı daha girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nSon sayıyı girin: ");
        int sayi3 = Convert.ToInt32(Console.ReadLine());

        int en_buyuk = int.MinValue;

        Console.WriteLine("\n----- SONUÇ -----");

        if (sayi1 == sayi2 && sayi2 == sayi3)
        {
            Console.WriteLine("Tüm sayılar eşit.");
            en_buyuk = sayi1;
        }
        else
        {
            if (sayi1 > en_buyuk)
            {
                en_buyuk = sayi1;
            }
            if (sayi2 > en_buyuk)
            {
                en_buyuk = sayi2;
            }
            if (sayi3 > en_buyuk)
            {
                en_buyuk = sayi3;
            }
        }
        Console.WriteLine($"\nGirdiğiniz en büyük sayı: {en_buyuk}\n");
    }
}
