using System;

class Program
{
    /*
    Klavyeden sıfır girinceye kadar sayı girilmesini sağlayan negatif ve pozitifleri ayrı ayrı toplayıp
    ekrana yazdıran programı yazınız.
    */
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Pozitif veya negatif bir sayı girin. (0 girerseniz program sonlandıralacaktır.)\n");
        
        int sayi;
        int pozitifToplam = 0;
        int negatifToplam = 0;
        
        while (true)
        {
            Console.Write("Bir sayı girin: ");
            while (!int.TryParse(Console.ReadLine(), out sayi))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n⚠️ Hatalı giriş! Lütfen bir tamsayı girin.\n");
                Console.ResetColor();

                Console.Write("\nTekrar deneyin: ");
            }

            if (sayi == 0)
            {
                break;
            }
            if (sayi > 0)
            {
                pozitifToplam += sayi;
            }
            else
            {
                negatifToplam += sayi;
            }
        }

        Console.WriteLine("\n-------------------------------");
        Console.WriteLine($"Pozitif Sayıların Toplamı: {pozitifToplam}");
        Console.WriteLine($"Negatif Sayıların Toplamı: {negatifToplam}");
        Console.WriteLine("-------------------------------\n");
    }
}
