/*
Klavyeden girilen maksimum 20 karakterli bir kelimedeki sesli harflerin sayısının toplam
karakter sayısına göre oranını hesaplayınız.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Bir kelime girin (En fazla 20 karekter girebilirsiniz): ");
        string kelimeAlma = (Console.ReadLine() ?? "").Trim().ToLower();

        while (kelimeAlma.Length > 20 || kelimeAlma.Length == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n⚠️ UYARI! (En fazla 20 karekter girebilirsiniz)");
            Console.ResetColor();
            Console.Write("\nTekrar deneyin: ");
            kelimeAlma = (Console.ReadLine() ?? "").Trim().ToLower();
        }

        char[] harfDizisi = kelimeAlma.ToCharArray();

        char[] sesliHarflerDizisi = {'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö'};

        int toplamKarekterSayisi = harfDizisi.Length;
        int sesliHarfSayacı = 0;

        for (int i = 0; i < harfDizisi.Length; i++)
        {
            for (int j = 0; j < sesliHarflerDizisi.Length; j++)
            {
                if (harfDizisi[i] == sesliHarflerDizisi[j])
                {
                    sesliHarfSayacı++;
                    break;
                }
            }
        }

        double oran = (double)sesliHarfSayacı / toplamKarekterSayisi;

        Console.WriteLine("\n------------------------------------------------------------------");

        Console.Write("[");
        for (int i = 0; i < harfDizisi.Length; i++)
        {
            Console.Write(harfDizisi[i]);

            if (i < harfDizisi.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]\n");

        Console.WriteLine($"Toplam karakter sayısı: {toplamKarekterSayisi}");
        Console.WriteLine($"Kelimedeki sesli harflerin sayısı: {sesliHarfSayacı}\n");

        Console.WriteLine($"kelimedeki sesli harflerin sayısı / toplam karakter sayısı = {oran:F2}");

        Console.WriteLine("------------------------------------------------------------------\n");
    }
}
