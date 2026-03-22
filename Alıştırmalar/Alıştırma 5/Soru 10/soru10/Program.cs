/*
Verilen bir kelimenin palindrom olup olmadığını kontrol eden bir C# programı yazınız.
Palindrom, tersten okunuşu ile aynı olan cümle, sözcük ve sayılara denilmektedir.
Örnek:
"aaabbaaa' için çıktı doğru olmalıdır
"abcd" için çıktı yanlış olmalıdır
*/

using System;

namespace MyApp
{
    internal class Program
    {
        static bool PolindromMu(string kelime)
        {
            if (kelime == null)
            {
                return false;
            }

            for (int i = 0; i < kelime.Length / 2; i++)
            {
                if (kelime[i] != kelime[kelime.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Bir kelime girin: ");
            string kelime = (Console.ReadLine() ?? "").ToLower().Trim();

            bool polindromMu = PolindromMu(kelime);

            Console.WriteLine("\n--------------------------------------------------------------");

            Console.WriteLine($"Girdiğiniz kelime: {kelime}");

            if (polindromMu)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n✅ Girdiğiniz kelime Polindromdur.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n❌ Girdiğiniz kelime Polindrom değildir.");
                Console.ResetColor();
            }

            Console.WriteLine("--------------------------------------------------------------\n");
        }
    }
}