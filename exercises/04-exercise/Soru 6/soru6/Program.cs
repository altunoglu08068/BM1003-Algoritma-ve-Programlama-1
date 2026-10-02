/*
Parametre olarak 2 tam sayıyı alan ve farklarının mutlak değerini geri döndüren bir metot
tanımlayınız.
*/

using System;

namespace Program
{
    internal class Program
    {
        static int SayiGirisi(string mesaj)
        {
            Console.Write(mesaj);

            int sayi;

            while (!int.TryParse(Console.ReadLine(), out sayi))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ HATA");
                Console.ResetColor();

                Console.Write("Tekrar deneyin: ");
            }

            return sayi;
        }

        static int Mutlak(int sayi1, int sayi2)
        {
            int islem = Math.Abs(sayi1 - sayi2);
            return islem;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int sayi1 = SayiGirisi("1. sayıyı girin: ");
            int sayi2 = SayiGirisi("2. sayıyı girin: ");

            int sonuc = Mutlak(sayi1, sayi2);

            Console.WriteLine("\n---------------------------------------------------------------------------");
            Console.WriteLine($"Formül: |1. sayı - 2. sayı| --> İşlem: |{sayi1} - {sayi2}| --> Sonuç: {sonuc}");
            Console.WriteLine("---------------------------------------------------------------------------\n");
        }
    }
}
