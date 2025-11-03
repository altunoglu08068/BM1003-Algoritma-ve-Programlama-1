using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan alınan sayının faktöriyelini ekrana yazdıran bir program yazınız.

        Console.Write("\n\nBir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n------ SONUÇ ------");

        if (sayi == 0)
        {
            Console.WriteLine($"\n{sayi}! = 1\n");
        }
        else if (sayi < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nNegatif sayıların faktöriyeli yoktur.\n");
            Console.ResetColor();
        }
        else
        {
            int faktoriyel = 1;

            for (int i = sayi; i >= 1; i--)
            {
                faktoriyel *= i;
            }
            Console.WriteLine($"\n{sayi}! = {faktoriyel}\n");
        }
    }
}
