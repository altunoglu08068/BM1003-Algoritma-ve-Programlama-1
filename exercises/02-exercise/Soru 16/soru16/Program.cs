/*
Belirli bir karakterin ASCII değerini bulan bir C# Sharp programı yazın.
ASCII tablosu: https://tr.wikipedia.org/wiki/ASCII
Örnek Çıktı:
1'in Ascii değeri: 49
A'nın Ascii değeri: 65
a'nın Ascii değeri: 97
#'nin Ascii değeri: 35
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Bir karakter girin: ");
            char karakter = Console.ReadKey().KeyChar;

            Console.WriteLine("\n\n------------------------------------");
            Console.WriteLine($"\nGirdiğiniz karakter\t\t: {karakter}");
            Console.WriteLine($"\nGirdiğiniz sayının ASCII değeri\t: {(int)karakter}");
            Console.WriteLine("\n------------------------------------\n");
        }
    }
}
