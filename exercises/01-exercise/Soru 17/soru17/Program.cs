using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Kullanıcıdan kullanıcı adı ve şifre alınsın.
        Eğer kullanıcı adı = "admin" ve şifre = "1234" ise “Giriş başarılı”
        Aksi halde “Hatalı giriş” yazan programı yapınız.
        */

        Console.Write("\n\nLütfen kullanıcı adı giriniz: ");
        string kullanici_adi = Console.ReadLine() ?? "";

        Console.Write("\nLütfen şifrenizi giriniz: ");
        string sifre = Console.ReadLine() ?? "";

        Console.WriteLine("\n------------------------");

        if (kullanici_adi == "admin" && sifre == "1234")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nGiriş başarılı.\n");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nHatalı giriş.\n");
            Console.ResetColor();
        }
    }
}
