using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        // Belirli bir sayının faktöriyelini hesaplayan bir C# programı yazın.

        Console.Write("\n\nBir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        while (sayi < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n❌ Negatif sayıların faktöriyeli hesaplanamaz.\n");
            Console.ResetColor();
            Console.Write("Lütfen sıfır veya sıfırdan büyük bir sayı girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());
        }

        int faktoriyel = 1;

        for (int i = sayi; i > 0; i--)
        {
            faktoriyel *= i;
        }
        
        Console.WriteLine($"{sayi}! = {faktoriyel}");
        //...
    }
}
