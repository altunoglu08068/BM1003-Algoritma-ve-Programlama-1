using System;

class Program
{
    static void Main(string[] args)
    {
        // İlk 10 doğal sayının toplamını bulan bir C# programı yazın.

        Console.Write("\n\nİlk 10 doğal sayının toplamı: ");

        int toplam = 0;

        for (int i = 0; i <= 10; i++)
        {
            toplam += i;
        }
        
        Console.WriteLine($"{toplam}\n");
    }
}
