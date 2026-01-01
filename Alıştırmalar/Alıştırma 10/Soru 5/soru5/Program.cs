/*
Bir kelimenin çoğul olup olmadığını kontrol eden bir metot yazınız.
Örnek Çıktı:
'Egzersiz' çoğul mu? False
'Alıştırmalar' çoğul mu? True
'Kitaplar' çoğul mu? True
'Kitap' çoğul mu? False
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static bool CogulMu(string kelime)
        {
            kelime = kelime.Trim().ToLower();

            return kelime.Length >= 3 && (kelime.EndsWith("ler") || kelime.EndsWith("lar"));
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.Write("Bir kelime girin: ");
                string kelime = Console.ReadLine() ?? "";

                bool sonuc = CogulMu(kelime);

                if (sonuc)
                {
                    Console.Write($"\n'{kelime}' çoğul mu? -> ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("✅ True");
                }
                else
                {
                    Console.Write($"\n'{kelime}' çoğul mu? -> ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("❌ False");
                }

                Console.ResetColor();

                Console.Write("\nÇıkmak için 0 tuşuna basın: ");

                char tus = Console.ReadKey().KeyChar;

                if (tus == '0')
                {
                    Console.WriteLine("\n\nÇıkış yaptınız.\n");
                    break;
                }
            }
        }
    }
}