using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan iki sayı alın. Eğer ikinci sayı sıfır değilse bölme işlemini yapıp sonucu yazdırın, aksi halde “Hata: Sıfıra bölme yapılamaz” mesajı veriniz.

        Console.Write("\n\nBirinci sayıyı girin: ");
        double sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nİkinci sayıyı girin: ");
        double sayi2 = Convert.ToInt32(Console.ReadLine());

        if (sayi2 != 0)
        {
            double bolme = sayi1 / sayi2;
            Console.WriteLine($"\n{sayi1} / {sayi2} = {bolme}\n");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nHata: Sıfıra bölme yapılamaz.\n");
            Console.ResetColor();
        }
    }
}
