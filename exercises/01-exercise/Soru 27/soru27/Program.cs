using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Bir üçgenin geçerli olup olmadığını kontrol ediniz (üçgen eşitsizliği). Geçerli değilse “Geçersiz üçgen” yazdırınız (alan/tür hesaplaması yok).

        Console.Write($"\n\nÜçgenin birinci kenarını giriniz: ");
        int kenar1 = Convert.ToInt32(Console.ReadLine());

        Console.Write($"\nÜçgenin ikinci kenarını giriniz: ");
        int kenar2 = Convert.ToInt32(Console.ReadLine());

        Console.Write($"\nÜçgenin üçüncü kenarını giriniz: ");
        int kenar3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n----- SONUÇ -----");

        if (kenar1 + kenar2 > kenar3 && kenar1 + kenar3 > kenar2 && kenar2 + kenar3 > kenar1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n✅ Geçerli üçgen\n");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n❌ Geçersiz üçgen\n");
            Console.ResetColor();
        }
    }
}
