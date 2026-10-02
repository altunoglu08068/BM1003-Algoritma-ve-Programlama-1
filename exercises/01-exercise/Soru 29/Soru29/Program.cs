using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Kullanıcıdan iki kesir alınız: birinci kesir için a ve b, ikinci kesir için c ve d değerlerini (pay
        ve payda) giriniz. Paydalar 0 olamaz. Girilen iki kesri karşılaştırarak, birinci kesir büyükse
        "a/b > c/d", küçükse "a/b < c/d", eşitse "a/b = c/d" şeklinde sonucu ekrana yazdırınız.
        */

        Console.Write("\n\nİlk kesrin payını yani (a) değerini giriniz: ");
        double a = Convert.ToDouble(Console.ReadLine());

        double b;
        double d;

        while (true)
        {
            Console.Write("\nİlk kesrin paydasını yani (b) değerini giriniz: ");
            b = Convert.ToDouble(Console.ReadLine());

            if (b == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPayda sıfır olamaz! b değerini tekrar girin.\n");
                Console.ResetColor();
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("\n----------\n");
        
        Console.Write("\nİkinci kesrin payını yani (c) değerini giriniz: ");
        double c = Convert.ToDouble(Console.ReadLine());

        while (true)
        {
            Console.Write("\nİkinci kesrin paydasını yani (d) değerini giriniz: ");
            d = Convert.ToDouble(Console.ReadLine());
            if (d == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPayda sıfır olamaz! d değerini tekrar giriniz.\n");
                Console.ResetColor();
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("\n----------\n");

        double bolum1 = a / b;
        Console.WriteLine($"\na/b = {bolum1}\n");
        
        double bolum2 = c / d;
        Console.WriteLine($"\nc/d = {bolum2}\n");

        Console.WriteLine("\n----------\n");

        if (bolum1 > bolum2)
        {
            Console.WriteLine("\na/b > c/d\n");
        }
        else if (bolum1 < bolum2)
        {
            Console.WriteLine("\na/b < c/d\n");
        }
        else
        {
            Console.WriteLine("\na/b = c/d\n");
        }
    }
}
