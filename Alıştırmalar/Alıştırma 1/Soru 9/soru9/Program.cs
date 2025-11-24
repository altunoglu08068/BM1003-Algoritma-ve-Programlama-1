using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Bir kullanıcının yaşını, cinsiyetini ("E" veya "K" olarak) ve sürücü belgesinin olup
        olmadığını ('E' veya 'H' olarak) alın. Kullanıcının aşağıdaki kriterlere göre hangi araç
        türünde sürücü olabileceğini belirleyin:
        
        • 18 yaşından küçükse, "Bisiklet sürücüsü olabilirsiniz." mesajını yazdırın.
        
        • 18-22 yaşları arasında, sürücü belgesi yoksa, "Sürücü belgesi almanız gerekiyor."
        mesajını yazdırın.        
        
        • 18-22 yaşları arasında, sürücü belgesi varsa ve cinsiyet "E" ise, "Motosiklet
        sürücüsü olabilirsiniz." mesajını yazdırın.
        
        • 23 yaş ve üzeri, sürücü belgesi varsa, "Otomobil sürücüsü olabilirsiniz." mesajını
        yazdırın.
        
        • Diğer tüm durumlar için, "Sürücü kategorisi belirlenemedi." mesajını yazdırın.
        */

        Console.Write("\n\nLütfen yaşınızı giriniz: ");
        int yas = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nLüfen cinsiyetinizi giriniz (K / E): ");
        char cinsiyet = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        Console.Write("\nSürücü belgeniz var mı? (E / H): ");
        char belge = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        Console.WriteLine("\n----- SONUÇ -----");

        if (yas < 18)
        {
            Console.WriteLine("\nBisiklet sürücüsü olabilirsiniz.\n");
        }
        else if (yas >= 18 && yas <= 22)
        {
            if (belge == 'H')
            {
                Console.WriteLine("\nSürücü belgesi almanız gerekiyor.\n");
            }
            else if (belge == 'E' && cinsiyet == 'E')
            {
                Console.WriteLine("\nMotosiklet sürücüsü olabilirsiniz.\n");
            }
            else
            {
                Console.WriteLine("\nSürücü kategorisi belirlenemdi.\n");
            }
        }
        else if (yas >= 23 && belge == 'E')
        {
            Console.WriteLine("\nOtomobil sürücüsü olabilirsiniz.\n");
        }
        else
        {
            Console.WriteLine("\nSürücü kategorisi belirlenemdi.\n");
        }
    }
}
