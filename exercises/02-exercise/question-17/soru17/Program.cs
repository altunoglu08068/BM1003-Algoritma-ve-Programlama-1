/*
İki basamaklı bir sayının basamaklarının yerini değiştiren ve elde edilen sayının orjinal sayıdan
büyük olup olmadığını kontrol eden bir C# programı yazın.
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("İki basamaklı bir sayı girin: ");

            int sayi;

            while (!int.TryParse(Console.ReadLine(), out sayi) || sayi < 10 || sayi > 99)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ HATA!");
                Console.ResetColor();

                Console.Write("\nTekrar deneyin:");
            }

            Console.WriteLine("\n-----------------------------------------------------------------------");

            int birler = sayi % 10;
            int onlar = sayi / 10 % 10;

            Console.WriteLine($"Sayı\t\t: {sayi} \t--> Onlar basamağı: {onlar}, Birler Basamağı: {birler}");

            int gecici = birler;
            birler = onlar;
            onlar = gecici;
            int yeniSayi = (onlar * 10) + birler;

            Console.WriteLine($"Yeni Sayı\t: {yeniSayi} \t--> Onlar basamağı: {onlar}, Birler Basamağı: {birler}");

            if (yeniSayi > sayi)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\n\tYeni sayı ({yeniSayi}), girdiğiniz ({sayi}) sayısından büyüktür.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n\n\tYeni sayı ({yeniSayi}), girdiğiniz ({sayi}) sayısından büyük değildir.");
                Console.ResetColor();
            }

            Console.WriteLine("-----------------------------------------------------------------------\n");
        }
    }
}
