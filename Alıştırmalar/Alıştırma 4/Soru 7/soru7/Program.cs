/*
Bir kişinin doğum tarihini yıl olarak parametre alan ve kişinin yaşını hesaplayıp ekrana
yazdıran bir metot tanımlayınız.
*/

using System;

namespace Program
{
    internal class Program
    {
        static void YasYazdir(int dogumYili)
        {
            int yas = DateTime.Now.Year - dogumYili;

            Console.WriteLine("\n--------------------------------------------------------------------------------------");
            Console.WriteLine($"Doğum Yılınız: {dogumYili} | Bulunduğumuz Yıl: {DateTime.Now.Year} | Yaşınız: {yas}");
            Console.WriteLine("--------------------------------------------------------------------------------------\n");
        }
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Doğum tarihinizi giriniz (Yıl): ");

            int dogumYili;

            while (!int.TryParse(Console.ReadLine(), out dogumYili) || dogumYili <= 0 || dogumYili > DateTime.Now.Year)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ HATA!");
                Console.ResetColor();

                Console.Write("Tekrar deneyin: ");
            }

            YasYazdir(dogumYili);
        }
    }
}
