using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan bir sayı alınız, bu sayının karesini ve küpünü hesaplayıp ekrana yazdırınız.
        
        Console.Write("\n\nBir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int kare = sayi * sayi;
        int kup = sayi * sayi * sayi;

        Console.WriteLine($"\nGirdiğiniz sayınının karesi: {kare}, küpü: {kup}\n");
    }
}
