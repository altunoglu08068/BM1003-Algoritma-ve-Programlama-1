/*
Metinsel bir ifadedeki büyük harfleri küçük harflere dönüştüren bir metot tanımlayınız.
ÖRNEK:
BİLGİSAYAR → bilgisayar
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static string KucukHarf(string metin)
        {
            string x = metin.ToLower();
            return x;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Metinsel bir ifade giriniz: ");
            string metin = Console.ReadLine() ?? "";
            string kucukMetin = KucukHarf(metin);
            Console.WriteLine("\n------------------------------");
            Console.WriteLine($"{metin} → {kucukMetin}");
            Console.WriteLine("------------------------------\n");
        }
    }
}
