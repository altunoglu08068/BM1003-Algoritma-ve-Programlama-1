using System;

class Program
{
    // Parametre olarak üç sayı (x,y,z) alan ve (x+y).z çıktısını geri döndüren bir metodu yazınız.

    static int Hesapla(int x, int y, int z)
    {
        int sonuc = (x + y) * z;
        return sonuc;
    }
    static void Main(string[] args)
    {
        Console.Write("\n\nBirinci sayıyı giriniz. (x): ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı giriniz. (y): ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Üçüncü sayıyı giriniz. (z): ");
        int sayi3 = Convert.ToInt32(Console.ReadLine());

        int son = Hesapla(sayi1, sayi2, sayi3);
        Console.WriteLine($"\nSonuç: ({sayi1} + {sayi2}) * {sayi3} = {son}\n");
    }
}
