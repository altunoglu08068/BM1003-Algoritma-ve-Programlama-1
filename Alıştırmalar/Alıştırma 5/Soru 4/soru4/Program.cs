/*
Bir tamsayı dizisindeki ilk 4 öğeden birinin verilen bir öğeye eşit olup olmadığını kontrol eden
bir metot yazın.
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

namespace MyApp
{
    internal class Program
    {
        static bool IlkDortElemandaVarMi(int[] dizi, int sayi)
        {
            int sinir = (dizi.Length < 4) ? dizi.Length : 4;

            bool sonuc = false;

            for (int i = 0; i < sinir; i++)
            {
                if (sayi == dizi[i])
                {
                    sonuc = true;
                    break;
                }
            }
            return sonuc;
        }
        static void DiziYazdir(int[] dizi)
        {
            Console.Write("[");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i]);
                if (i != dizi.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }

        static int SayiGirisi(string mesaj)
        {
            Console.Write(mesaj);

            int sayi;
            while (!int.TryParse(Console.ReadLine(), out sayi))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ HATA: Geçersiz giriş.");
                Console.ResetColor();

                Console.Write("Tekrar deneyin: ");
            }
            return sayi;
        }
        static void YazSonuc(int arananSayi, bool sonuc)
        {
            if (!sonuc)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"❌ {arananSayi} -> Değer bulunamadı!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"✅ {arananSayi} -> Değer bulundu!");
                Console.ResetColor();
            }
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi1 = { 1, 2, 9, 4, 3 };
            int[] dizi2 = { 1, 2, 3, 4, 5, 6 };
            int[] dizi3 = { 1, 2, 2, 3 };

            int sayi1 = SayiGirisi("Dizi 1 için bir sayı girin: ");
            int sayi2 = SayiGirisi("Dizi 2 için bir sayı girin: ");
            int sayi3 = SayiGirisi("Dizi 3 için bir sayı girin: ");

            Console.WriteLine();

            DiziYazdir(dizi1);
            DiziYazdir(dizi2);
            DiziYazdir(dizi3);

            bool sonuc1 = IlkDortElemandaVarMi(dizi1, sayi1);
            bool sonuc2 = IlkDortElemandaVarMi(dizi2, sayi2);
            bool sonuc3 = IlkDortElemandaVarMi(dizi3, sayi3);

            Console.WriteLine();

            YazSonuc(sayi1, sonuc1);
            YazSonuc(sayi2, sonuc2);
            YazSonuc(sayi3, sonuc3);

            Console.WriteLine();
        }
    }
}