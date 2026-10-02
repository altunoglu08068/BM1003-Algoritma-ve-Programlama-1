/*
Bir kelimenin çoğul olup olmadığını kontrol eden bir metot yazınız.
Örnek Çıktı:
'Egzersiz' çoğul mu? Yanlış
'Alıştırmalar' çoğul mu? True
'Kitaplar' çoğul mu? True
'Kitap' çoğul mu? Yanlış
*/

using System;

namespace MyApp
{
    internal class Program
    {
        static bool CogulMu(string kelime)
        {
            if (kelime == null || kelime.Length < 3)
            {
                return false;
            }

            int uzunluk = kelime.Length;

            char sonHarf = kelime[uzunluk - 1];
            char ortaHarf = kelime[uzunluk - 2];
            char basHarf = kelime[uzunluk - 3];

            bool lerMi = (basHarf == 'l' || basHarf == 'L') &&
                         (ortaHarf == 'e' || ortaHarf == 'E') &&
                         (sonHarf == 'r' || sonHarf == 'R');

            // 3. KONTROL: -lar veya -LAR kontrolü
            bool larMi = (basHarf == 'l' || basHarf == 'L') &&
                         (ortaHarf == 'a' || ortaHarf == 'A') &&
                         (sonHarf == 'r' || sonHarf == 'R');

            return lerMi || larMi;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Bir kelime girin: ");
            string giris = (Console.ReadLine() ?? "").ToLower().Trim();

            bool sonuc = CogulMu(giris);

            Console.WriteLine("\n---------------------------------------");
            if (sonuc)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"✅ '{giris}' kelimesi ÇOĞUL ekine sahip.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"❌ '{giris}' kelimesi çoğul eki TAŞIMIYOR.");
            }
            Console.ResetColor();
            Console.WriteLine("---------------------------------------\n");

            if (giris.Length >= 3 && sonuc)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Bilgi:\tAlgoritma sadece son ek (-lar/-ler) kontrolü yapar.");
                Console.WriteLine("\t'Dolar', 'Kiler', 'Popüler' gibi kelimeler istisnadır.\n");
                Console.ResetColor();
            }
        }
    }
}