using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        // Bir üçgenin Eşkenar, İkizkenar veya Çeşitkenar olup olmadığını kontrol eden programı yazın.

        Console.Write("\n\nA kenarının uzunluğunu giriniz: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nB kenarının uzunluğunu giriniz: ");
        int B = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nC kenarının uzunluğunu giriniz: ");
        int C = Convert.ToInt32(Console.ReadLine());

        Console.Write("\n----- SONUÇ -----\n");

        if ((A + B > C) && (A + C > B) && (B + C > A))
        {
            if (A == B && B == C)
            {
                Console.Write("\nOluşturduğunuz üçgen, ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("eşkenar üçgen");
                Console.ResetColor();
                Console.Write("dir.\n\n");
            }
            else if (A == B || A == C || B == C)
            {
                Console.Write("\nOluşturduğunuz üçgen, ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("ikizkenar üçgen");
                Console.ResetColor();
                Console.Write("dir.\n\n");
            }
            else if (A != B && A != C && B != C)
            {
                Console.Write("\nOluşturduğunuz üçgen, ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("çeşitkenar üçgen");
                Console.ResetColor();
                Console.Write("dir.\n\n");
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nYazdığınız değerlerle üçgen oluşturulamıyor, lütfen üçgen oluşturma kuralına göre yazın.\n");
            Console.ResetColor();
        }
    }
}
