using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Girdi olarak bir sayı alan ve 10'a kadar olan çarpım tablosunu yazdıran programı yazınız.
        Test verisi:
        Bir sayı girin: 8
        Beklenen çıktı :
        8 x 1 = 8
        8 x 2 = 16
        8 × 3 = 24
        ···
        8 x 10 = 80
        */

        Console.Write("\n\nBir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        for (int i = 1; i <= 10; i++)
        {
            int sonuc = sayi * i;
            Console.WriteLine($"{sayi} x {i} = {sonuc}");
        }
        Console.WriteLine();
    }
}
