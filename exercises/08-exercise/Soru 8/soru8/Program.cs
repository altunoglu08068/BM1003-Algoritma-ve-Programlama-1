using System;

class Program
{
    /*
    Bir sayıyı parametre olarak alan ve bu sayının faktöriyelini hesaplayıp sonucu geri döndüren
    bir metot tanımayız.
    */

    static long Faktoriyel(int sayi)
    {        
        long faktöriyel = 1;

        for (int i = sayi; i > 0; i--)
        {
            faktöriyel *= i;
        }
        return faktöriyel;
    }
    static void Main(string[] args)
    {
        Console.Clear();
        
        Console.Write("\n\nBir tam sayı giriniz: ");
        int n;

        while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nHatalı giriş!");
            Console.ResetColor();
            Console.Write("\nLütfen pozitif bir tam sayı giriniz: ");
        }


        long sonuc = Faktoriyel(n);

        Console.WriteLine("\n-------------------------------");

        Console.WriteLine($"{n}! = {sonuc}");

        Console.WriteLine("-------------------------------\n");
    }
}
