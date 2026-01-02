
//Tam sayılardan oluşan bir dizide aranan elemanın olup olmadığını bulan bir programı yazınız.

using System;

namespace Program
{
    internal class ProgramClass
    {
        static int[] DiziOlustur()
        {
            int[] dizi = new int[10];
            Random rastgele = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rastgele.Next(0, 101);
            }
            return dizi;
        }
        static int VeriAl(string mesaj = "Dizinin bir tane elemanını tahmin edin: ")
        {
            Console.Write(mesaj);
            int sayi;

            while (!int.TryParse(Console.ReadLine(), out sayi) || sayi < 0 || sayi > 100)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ HATA! 0-100 arası bir sayı girin.");
                Console.ResetColor();

                Console.Write("\nTekrar deneyin: ");
            }
            return sayi;
        }
        static void DizideAraVeSırasınıGöster(int[] x, int aranacakSayi)
        {
            bool bulunduMu = false;

            for (int i = 0; i < x.Length; i++)
            {
                if (aranacakSayi == x[i])
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n✅ Girdiğiniz sayı dizide bulundu.");
                    Console.ResetColor();
                    bulunduMu = true;
                    Console.WriteLine($"\nGirdiğiniz sayı dizinin {i + 1}. elemanı.");
                    break;
                }
            }
            if (!bulunduMu)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n❌ Girdiğiniz sayı dizide bulunamadı.");
                Console.ResetColor();
            }
        }
        static void DiziGoster(int[] x)
        {
            Console.WriteLine("\n----- Dizi -----\n");
            Console.Write("[");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i]);

                if (i < x.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]\n");
        }
        static void Main(string[] args)
        {
            Console.Clear();
            
            int[] dizi = DiziOlustur();
            int tahmin = VeriAl();
            DizideAraVeSırasınıGöster(dizi, tahmin);
            DiziGoster(dizi);
        }
    }
}
