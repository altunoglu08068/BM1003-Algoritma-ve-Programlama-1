using System;

class Program
{
    /*
    Verilen iki tam sayıdan 100 değerine en yakın sayıyı kontrol eden bir metot yazınız. İki sayı
    eşitse 0 dönsün.
    Örnek Giriş :
    78, 95
    95, 95
    99, 70
    Beklenen Çıkış :
    95
    0
    99
    */

    static int EnYakin100(int sayi1, int sayi2)
    {
        int fark1 = Math.Abs(100 - sayi1);
        int fark2 = Math.Abs(100 - sayi2);

        if (sayi1 == sayi2)
        {
            return 0;
        }
        else if (fark1 < fark2)
        {
            return sayi1;
        }
        else
        {
            return sayi2;
        }
    }
    static void Main(string[] args)
    {
        Console.Write("\n\nİlk sayıyı giriniz: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı giriniz: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int sonuc = EnYakin100(n1, n2);
        Console.WriteLine($"\n100'e en yakın sayı: {sonuc}\n");
    }
}
