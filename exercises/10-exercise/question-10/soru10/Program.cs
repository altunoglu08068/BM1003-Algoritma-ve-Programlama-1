/*
Verilen bir kelimenin palindrom olup olmadığını kontrol eden bir C# programı yazınız.
Palindrom, tersten okunuşu ile aynı olan cümle, sözcük ve sayılara denilmektedir.
Örnek:
"aaabbaaa' için çıktı doğru olmalıdır
"abcd" için çıktı yanlış olmalıdır
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static bool PalindromMu(char[] x)
        {
            int uzunluk = x.Length;

            for (int i = 0; i < uzunluk / 2; i++)
            {
                if (x[i] != x[uzunluk - 1 - i])
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
            string kelime = (Console.ReadLine() ?? "").Trim().ToLower();

            char[] harf = kelime.ToCharArray();

            bool yeni = PalindromMu(harf);

            if (yeni)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nTrue\n");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nFalse\n");
                Console.ResetColor();
            }
        }
    }
}
