/*
Verilen iki tam sayıdan 100 değerine en yakın sayıyı kontrol eden bir metot yazınız. İki sayı
eşitse 0 dönsün.
Örnek Giriş :
78, 95
95, 95
99, 70
Beklenen Çıkış :
95
0
99
*/

using System;

namespace Program
{
    internal class Program
    {
        static int SayiGirisi(string mesaj)
        {
            int sayi;

            Console.Write(mesaj);

            while (!int.TryParse(Console.ReadLine(), out sayi))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ HATA!");
                Console.ResetColor();

                Console.Write("\nTekrar deneyin: ");
            }

            return sayi;
        }

        static int EnYakiniBul(int sayi1, int sayi2, int referansNoktasi)
        {
            int fark1 = Math.Abs(referansNoktasi - sayi1);
            int fark2 = Math.Abs(referansNoktasi - sayi2);

            if (fark1 < fark2)
            {
                return sayi1;
            }
            else if (fark2 < fark1)
            {
                return sayi2;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int referansNoktasi = 100;
            int sayi1 = SayiGirisi("1. sayıyı girin: ");
            int sayi2 = SayiGirisi("2. sayıyı girin: ");

            int enYakinSayi = EnYakiniBul(sayi1, sayi2, referansNoktasi);

            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine($"Girdiğiniz sayılardan {referansNoktasi}'e en yakın olanı: {enYakinSayi}");
            Console.WriteLine("-----------------------------------------------\n");
        }
    }
}
