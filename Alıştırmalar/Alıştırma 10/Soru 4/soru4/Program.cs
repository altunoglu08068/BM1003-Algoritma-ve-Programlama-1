/*
Bir tamsayı dizisindeki ilk 4 öğeden birinin verilen bir
öğeye eşit olup olmadığını kontrol eden bir metot yazın.
Örnek Giriş :
{1,2,9,4,3}, 3
{1,2,3,4,5,6}, 2
{1,2,2,3}, 9
Beklenen Çıkış :
False
True
False
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static bool EsitMi(int[] x, int sayi)
        {
            int sinir = Math.Min(4, x.Length);

            for (int i = 0; i < sinir; i++)
            {
                if (sayi == x[i])
                {
                    return true;
                }
            }
            return false;
        }

        static int SayiGirisi()
        {
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

            int[][] diziler =
            {
                new int[] { 1, 2, 9, 4, 3 },
                new int[] { 1, 2, 3, 4, 5, 6 },
                new int[] { 1, 2, 2, 3 }
            };

            for (int i = 0; i < diziler.Length; i++)
            {
                Console.Write($"{i + 1}. dizi için bir sayı girin: ");

                int sayi = SayiGirisi();

                bool sonuc = EsitMi(diziler[i], sayi);

                if (sonuc)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n✅ True\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n❌ False\n");
                    Console.ResetColor();
                }
            }
        }
    }
}