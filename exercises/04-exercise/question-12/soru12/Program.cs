/* Parametre olarak ikili bir sayıyı alan ve bu sayıyı onluk tabana dönüştüren bir metot yazınız.
Örnek:
101 -> 5
*/

using System;

namespace Program
{
    internal class Program
    {
        static int IkiliSayiyiOnlukTabanaDonustur(string ikiliSayi)
        {
            int onlukSayi = 0;
            int basamakDegeri = 1;

            for (int i = ikiliSayi.Length - 1; i >= 0; i--)
            {
                if (ikiliSayi[i] == '1')
                {
                    onlukSayi += basamakDegeri;
                }

                basamakDegeri *= 2;
            }

            return onlukSayi;
        }
        static void Main(string[] args)
        {
            Console.Clear();

            string giris = "";
            bool gecerliMi = false;

            while (gecerliMi == false)
            {
                if (giris == "")
                {
                    Console.Write("Lütfen bir ikili sayı giriniz (0 ve 1): ");
                    giris = Console.ReadLine() ?? "";

                    if (giris == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n⚠️ Boş bırakamazsınız.");
                        Console.ResetColor();
                        continue;
                    }

                    gecerliMi = true;

                    for (int i = 0; i < giris.Length; i++)
                    {
                        char karakter = giris[i];

                        if (karakter != '0' && karakter != '1')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nGeçersiz karakter: {karakter}");
                            Console.ResetColor();
                            gecerliMi = false;
                            giris = "";
                            break;
                        }
                    }
                }
            }

            int onlukSayi = IkiliSayiyiOnlukTabanaDonustur(giris);
            Console.WriteLine("\n--------------------------------");
            Console.WriteLine($"Onluk tabandaki karşılığı: {onlukSayi}");
            Console.WriteLine("--------------------------------\n");
        }
    }
}