/*
İki sayıyı değiştirmek için bir C# programı yazınız.
Test Verileri:
İlk Sayıyı Girin : 5
İkinci Sayıyı Girin : 6
Beklenen Çıktı:
Değiştirmeden Sonra :
İlk Sayı : 6
İkinci Sayı : 5
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static int SayiIste(string mesaj)
        {
            Console.Write(mesaj);

            int sayi;

            while (!int.TryParse(Console.ReadLine(), out sayi))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ HATA!");
                Console.ResetColor();

                Console.Write("\nTekrar deneyin: ");
            }

            return sayi;
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int sayi1 = SayiIste("Birinci sayı giriniz\t: ");
            int sayi2 = SayiIste("İkinci sayı giriniz\t: ");

            Console.WriteLine("\n--------------------- Orijinal Hali ----------------------\n");

            Console.WriteLine($"Sayı 1: {sayi1}");
            Console.WriteLine($"Sayı 2: {sayi2}");

            int gecici = sayi1;
            sayi1 = sayi2;
            sayi2 = gecici;
            Console.WriteLine("\n------------------- Değiştirilmiş Hali -------------------\n");

            Console.WriteLine($"Sayı 1: {sayi1}");
            Console.WriteLine($"Sayı 2: {sayi2}");

            Console.WriteLine("\n----------------------------------------------------------\n");
        }
    }
}
