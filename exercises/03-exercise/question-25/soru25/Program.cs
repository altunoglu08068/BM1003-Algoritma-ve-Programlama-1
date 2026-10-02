// İlk 500 asal sayının toplamını hesaplayan programı yazınız.

using System;

namespace Program
{
    internal class ProgramClass
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int toplam = 0;
            int sayac = 0;
            int sayi = 2;

            while (sayac < 500)
            {
                bool asalMi = true;

                for (int i = 2; i <= sayi / 2; i++)
                {
                    if (sayi % i == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }

                if (asalMi)
                {
                    toplam += sayi;
                    sayac++;
                }

                sayi++;
            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"İlk 500 asal sayının toplamı: {toplam}");
            Console.WriteLine("--------------------------------------------------\n");
        }
    }
}
