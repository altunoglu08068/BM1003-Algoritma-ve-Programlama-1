using System;

class Program
{
    static void Main(string[] args)
    {
        //  Kullanıcıdan iki sayı ve bir işlem (+, -, *, /) seçmesini isteyen, buna göre sonucu hesaplayan programı yazınız.

        Console.Write("\n\nBir sayı giriniz: ");
        double sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nBir sayı daha giriniz: ");
        double sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nBir sembol girin (+, -, x, /): ");
        char sembol = Console.ReadKey().KeyChar;
        
        double bolum = sayi1 / sayi2;

        Console.WriteLine("\n\n----- SONUÇ -----\n");

        switch (sembol)
        {
            case '+':
                Console.WriteLine($"{sayi1} + {sayi2} = {sayi1 + sayi2}");
                break;
            case '-':
                Console.WriteLine($"{sayi1} - {sayi2} = {sayi1 - sayi2}");
                break;
            case 'x':
                Console.WriteLine($"{sayi1} x {sayi2} = {sayi1 * sayi2}");
                break;
            case '/':
                Console.WriteLine($"{sayi1} / {sayi2} = {bolum}");
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bir şeyler ters gitti, lütfen tekrar deneyiniz.");
                Console.ResetColor();
                break;
        }
        Console.WriteLine();

    }
}
