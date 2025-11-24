using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Kullanıcıdan AA, BB, CC, FF gibi bir not alınsın. Buna göre ekrana açıklama yazdırınız.
        
        "AA → Çok İyi"
        "BB → İyi"
        "CC → Orta"
        "FF → Başarısız"
        */

        Console.Write("\n\nNotunuzu girin (AA / BB / CC / FF): ");
        string not = (Console.ReadLine() ?? "").ToUpper().Trim();

        Console.WriteLine("\n---------- SONUÇ ----------\n");

        if (not == "AA")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Notunuz çok iyi!\n");
            Console.ResetColor();
        }
        else if (not == "BB")
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Notunuz iyi.\n");
            Console.ResetColor();
        }
        else if (not == "CC")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Notunuz ne iyi ne de kötü, tam ortada.\n");
            Console.ResetColor();
        }
        else if (not == "FF")
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Başarısız oldunuz.\n");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Geçersiz not girdiniz! Lütfen AA, BB, CC veya FF girin.\n");
            Console.ResetColor();
        }
    }
}
