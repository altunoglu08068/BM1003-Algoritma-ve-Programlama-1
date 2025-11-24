using System;

class Program
{
    static void Main(string[] args)
    {
        // İki tam sayıyı kabul eden ve eşit olup olmadıklarını kontrol eden programı yazın.

        Console.Write("\n\nBir tam sayı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nBir tam sayı daha girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n----- SONUÇ -----");
        
        if (sayi1 == sayi2)
        {
            Console.WriteLine("\nSayılar birbirine eşittir.\n");
        }
        else
        {
            Console.WriteLine("\nSayılar birbirine eşit değil.\n");
        }
    }
}
