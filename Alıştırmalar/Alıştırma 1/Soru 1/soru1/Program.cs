using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        // Klavyeden girilen 3 sayıyı küçükten büyüğe doğru ekrana yazan programı yazınız.

        Console.Write("\nBir sayı giriniz: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nBir sayı daha giriniz: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nSon sayıyı giriniz: ");
        int sayi3 = Convert.ToInt32(Console.ReadLine());

        int buyuk = 0;
        int orta = 0;
        int kucuk = 0;

        Console.WriteLine("\n------ SONUÇ -----\n");

        if (sayi1 == sayi2 && sayi2 == sayi3)
        {
            Console.WriteLine("Sayılar birbirine eşit.\n");
            return;
        }
        else if (sayi1 > sayi2 && sayi1 > sayi3)
        {
            buyuk = sayi1;

            if (sayi2 > sayi3)
            {
                orta = sayi2;
                kucuk = sayi3;
            }
            else
            {
                orta = sayi3;
                kucuk = sayi2;
            }
        }
        else if (sayi2 > sayi1 && sayi2 > sayi3)
        {
            buyuk = sayi2;

            if (sayi1 > sayi3)
            {
                orta = sayi1;
                kucuk = sayi3;
            }
            else
            {
                orta = sayi3;
                kucuk = sayi1;
            }
        }
        else if (sayi3 > sayi1 && sayi3 > sayi2)
        {
            buyuk = sayi3;

            if (sayi1 > sayi2)
            {
                orta = sayi1;
                kucuk = sayi2;
            }
            else
            {
                orta = sayi2;
                kucuk = sayi1;
            }
        }
        Console.WriteLine($"{kucuk} < {orta} < {buyuk}\n\n");
    }
}
