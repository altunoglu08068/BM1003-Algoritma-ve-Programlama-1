// Kullanıcının girdiği 2 sayının karelerinin toplamını hesaplayıp geri döndüren bir metot yazınız.

using System;

namespace Program
{
    internal class ProgramClass
    {
        static int SayiGirisi(string mesaj)
        {
            Console.Write(mesaj);

            int sayi;

            while (!int.TryParse(Console.ReadLine(), out sayi))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("⚠️ HATA!");
                Console.ResetColor();

                Console.Write("Tekrar deneyin: ");
            }

            return sayi;
        }

        static int KaresiniAlVeTopla(int x, int y)
        {
            return (x * x) + (y * y);
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int sayi1 = SayiGirisi("Birinci sayıyı girin\t: ");
            int sayi2 = SayiGirisi("İkinci sayıyı girin\t: ");

            int sonuc = KaresiniAlVeTopla(sayi1, sayi2);

            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine($"Sonuç: {sayi1}² + {sayi2}² = {sonuc}");
            Console.WriteLine("--------------------------------------\n");
        }
    }
}
