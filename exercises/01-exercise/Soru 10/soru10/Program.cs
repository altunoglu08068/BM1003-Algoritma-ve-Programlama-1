using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan alınan bir sayının 5’e bölünüp bölünmediğini bulan programı yazınız.

        Console.Write("\n\nBir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n----- SONUÇ -----\n");

        if (sayi % 5 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Girdiğiniz sayı 5'e bölünüyor.\n");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Girdiğiniz sayı 5'e bölünmüyor.\n");
            Console.ResetColor();
        }
    }
}
