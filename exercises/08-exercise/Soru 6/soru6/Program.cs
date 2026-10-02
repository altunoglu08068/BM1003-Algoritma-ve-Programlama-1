using System;

class Program
{
    /*
    Parametre olarak 2 tam sayıyı alan ve farklarının mutlak değerini geri döndüren bir metot
    tanımlayınız.
    */
    
    static int MutlakFark(int a, int b)
    {
        int sonuc = Math.Abs(a - b);
        return sonuc;
    }
    static void Main(string[] args)
    {
        Console.Write("\n\nBir sayı giriniz: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nBir sayı daha giriniz: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        int fark = MutlakFark(sayi1, sayi2);

        Console.WriteLine($"\nİki sayının mutlak farkı: {fark}\n");
    }
}
