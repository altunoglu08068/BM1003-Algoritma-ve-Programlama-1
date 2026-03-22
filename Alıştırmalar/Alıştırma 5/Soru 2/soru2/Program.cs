/*
Metinsel bir ifadedeki büyük harfleri küçük harflere dönüştüren bir metot tanımlayınız.
ÖRNEK: BİLGİSAYAR -> bilgisayar
*/

using System;

namespace MyApp
{
    internal class Program
    {
        static string KucukHarfYap(string metin)
        {
            return metin.ToLower();
        }
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Lütfen bir metin giriniz: ");
            string giris = Console.ReadLine() ?? "";

            string sonuc = KucukHarfYap(giris);

            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine($"Metin: {giris} -> Küçük Harfli Hali: {sonuc}");
            Console.WriteLine("---------------------------------------------\n");
        }
    }
}