using System;

class Program
{
    // Kullanıcının girdiği 2 sayının karelerinin toplamını hesaplayıp geri döndüren bir metot yazınız.

    static int KarelerToplami(int sayi1, int sayi2)
    {
        int sonuc = (sayi1 * sayi1) + (sayi2 * sayi2);
        return sonuc;
    }
    static void Main(string[] args)
    {
        Console.Write("\n\nİlk sayıyı giriniz: ");
        int s1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nİkinci sayıyı giriniz: ");
        int s2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n----------------------------------------");

        Console.WriteLine($"Kareler Toplamı: {KarelerToplami(s1, s2)}");

        Console.WriteLine("----------------------------------------\n");
    }
}
