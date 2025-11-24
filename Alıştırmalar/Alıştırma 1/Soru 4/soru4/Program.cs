using System;

class Program
{
    static void Main(string[] args)
    {
        // Giriş olarak bir karakteri alan ve bunun sesli harf, rakam veya başka bir sembol olup olmadığını kontrol eden programı yazın.
        
        Console.Write("\nLütfen bir karakter (bir harf, bir rakam ya da sembol) giriniz: ");
        char karakter = Console.ReadKey().KeyChar;

        Console.WriteLine("\n\n----- SONUÇ -----\n");

        if (karakter >= '0' && karakter <= '9')
        {
            Console.Write("Girdiğiniz karakter bir ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("RAKAMDIR");
            Console.ResetColor();
            Console.Write(".\n\n");
        }
        else if ((karakter >= 'a' && karakter <= 'z') || (karakter >= 'A' && karakter <= 'Z'))
        {
            char harf = Char.ToLower(karakter);

            if (harf == 'a' || harf == 'e' || harf == 'ı' || harf == 'i' || harf == 'u' || harf == 'ü' || harf == 'o' || harf == 'ö')
            {
                Console.Write("Girdiğiniz karakter bir ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("SESLİ HARFTİR");
                Console.ResetColor();
                Console.Write(".\n\n");
            }
            else
            {
                Console.Write("Girdiğiniz karakter bir ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("SESSİZ HARFTİR");
                Console.ResetColor();
                Console.Write(".\n\n");
            }
        }
        else
        {
            Console.Write("Girdiğiniz karakter bir ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("SEMBOLDÜR");
            Console.ResetColor();
            Console.Write(".\n\n");
        }
    }
}
