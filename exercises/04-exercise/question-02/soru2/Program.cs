/*
Verilen üç tamsayı arasından en büyük sayıyı kontrol eden bir metot yazın.
Örnek Giriş :
1,2,3
1,3,2
1,1,1
1,2,2
Beklenen Çıkış :
3
3
1
2
*/

using System;

namespace Program
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
                Console.WriteLine("\n⚠️ HATA!");
                Console.ResetColor();

                Console.Write("\nTekrar deneyin: ");
            }

            return sayi;
        }

        static int EnBuyuk(int sayi1, int sayi2, int sayi3)
        {
            int enBuyuk = sayi1;

            if (sayi2 > enBuyuk)
            {
                enBuyuk = sayi2;
            }

            if (sayi3 > enBuyuk)
            {
                enBuyuk = sayi3;
            }

            return enBuyuk;
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int sayi1 = SayiGirisi("Birinci sayıyı girin\t: ");
            int sayi2 = SayiGirisi("İkinci sayıyı girin\t: ");
            int sayi3 = SayiGirisi("Üçüncü sayıyı girin\t: ");

            int enBuyuk = EnBuyuk(sayi1, sayi2, sayi3);

            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine($"Girdiğiniz sayılardan en büyük olanı: {enBuyuk}");
            Console.WriteLine("--------------------------------------------\n");
        }
    }
}
