using System;

class Program
{
    static void Main(string[] args)
    {
        //Bir sayının mutlak değerini ve aynı zamanda işaretini (pozitif/negatif/sıfır) tek çıktıda gösteriniz (örn. “|−12| = 12, Negatif”).

        Console.Write("\n\nBir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int mutlak_deger = Math.Abs(sayi);

        string isaret;

        if (sayi > 0)
            isaret = "Pozitif";
        else if (sayi < 0)
            isaret = "Negatif";
        else
            isaret = "Sıfır";

        Console.WriteLine($"\n|{sayi}| = {mutlak_deger}, {isaret}\n");
    }
}
