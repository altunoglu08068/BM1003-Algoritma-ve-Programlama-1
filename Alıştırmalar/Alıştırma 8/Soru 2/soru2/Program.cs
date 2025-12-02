using System;

class Program
{
    /*
    Verilen üç tamsayı arasından en büyük sayıyı kontrol eden bir metot yazın.
    Örnek Giriş :
    1,2,3
    1,3,2
    1,1,1
    1,2,2
    Beklenen Çıkış :
    3
    3
    1
    2
    */

    static int EnBuyukSayi(int a, int b, int c)
    {
        if (a >= b && a >= c)
        {
            return a;
        }
        else if (b >= a && b >= c)
        {
            return b;
        }
        else
        {
            return c;
        }

    }
    static void Main(string[] args)
    {
        Console.Write("\n\nBir sayı giriniz: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Bir sayı daha giriniz: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Son sayıyı giriniz: ");
        int sayi3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nEn büyük sayı: {EnBuyukSayi(sayi1, sayi2, sayi3)}\n");
    }
}
