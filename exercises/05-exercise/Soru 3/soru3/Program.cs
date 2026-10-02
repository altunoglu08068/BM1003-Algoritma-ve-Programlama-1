/*
Belirli bir sayının bir sayı dizisinde olup olmadığını kontrol eden bir C# programı yazın.
Örnek Giriş :
{1,2,9,3}, 3
{1,2,2,3}, 2
{1,2,2,3}, 9
Beklenen Çıkış :
True
True
False
*/

using System;

namespace MyApp
{
    internal class Program
    {
        static int SayiGirisi(string mesaj)
        {
            Console.Write(mesaj);

            int sayi;

            while (!int.TryParse(Console.ReadLine(), out sayi))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ Hatalı giriş yaptınız.");
                Console.ResetColor();

                Console.Write("Tekrar deneyin: ");
            }

            return sayi;
        }

        static bool VarMi(int[] dizi, int sayi)
        {
            bool varMi = false;

            for (int i = 0; i < dizi.Length; i++)
            {
                if (sayi == dizi[i])
                {
                    varMi = true;
                    break;
                }
            }
            return varMi;
        }

        static void YazSonuc(int arananSayi, bool sonuc)
        {
            if (!sonuc)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"❌ {arananSayi} -> Yanlış Tahmin!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"✅ {arananSayi} -> Doğru Tahmin!");
                Console.ResetColor();
            }
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi1 = { 1, 2, 9, 3 };
            int[] dizi2 = { 1, 2, 2, 3 };
            int[] dizi3 = { 1, 2, 2, 3 };

            int sayi1 = SayiGirisi("Dizi 1 için bir sayı girin: ");
            int sayi2 = SayiGirisi("Dizi 2 için bir sayı girin: ");
            int sayi3 = SayiGirisi("Dizi 3 için bir sayı girin: ");

            bool sonuc1 = VarMi(dizi1, sayi1);
            bool sonuc2 = VarMi(dizi2, sayi2);
            bool sonuc3 = VarMi(dizi3, sayi3);

            Console.WriteLine();

            YazSonuc(sayi1, sonuc1);
            YazSonuc(sayi2, sonuc2);
            YazSonuc(sayi3, sonuc3);

            Console.WriteLine();
        }
    }
}