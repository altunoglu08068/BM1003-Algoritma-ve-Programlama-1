using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n----- FAKTÖRİYEL HESAPLAMA PROGRAMINA HOŞGELDİNİZ -----\n");

        while (true)
        {
            Console.Write("Faktöriyeli hesaplanacak sayıyı giriniz: ");
            string girdi = Console.ReadLine() ?? "";

            if (!int.TryParse(girdi, out int sayi))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nHata: Geçersiz veri formatı!");
                Console.ResetColor();
                continue;
            }

            int faktoriyel = 1;

            if (sayi < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nHata: Faktoriyeli alınacak sayı, 0'dan küçük olamaz!\n");
                Console.ResetColor();
            }
            else if (sayi == 0)
            {
                Console.WriteLine($"\n{sayi}! = 1\n");
            }
            else
            {
                for (int i = sayi; i >= 1; i--)
                {
                    faktoriyel *= i;
                }
                Console.WriteLine($"\n{sayi}! = {faktoriyel}\n");
            }

            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }

            Console.WriteLine("\nÇıkmak için 'c' ye devam etmek için herhangi bir tuşa basınız.\n");

            char cikis = Console.ReadKey().KeyChar;

            if (cikis == 'c')
            {
                Console.WriteLine("\nProgram sonlandırıldı. İyi günler dilerim!\n");
                break;
            }
        }
    }
}
