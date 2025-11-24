using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Kullanıcıdan alınan iki sayı arasındaki farkın mutlak değerini hesaplayan ve ekrana
        yazdıran bir program yazınız. Eğer fark 10'dan büyükse "Fark 10'dan büyüktür." şeklinde,
        değilse "Fark 10'dan küçük veya eşittir." şeklinde ek bir mesaj da veriniz.
        */

        Console.Write("\nBirinci sayıyı giriniz: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nİkinci sayıyı giriniz: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        int fark = Math.Abs(sayi1 - sayi2);

        Console.WriteLine("\n------ SONUÇ -----");

        Console.WriteLine($"\nFarkın mutlak değeri: {fark}\n");

        if (fark > 10)
        {
            Console.WriteLine("Fark, 10'dan büyüktür.\n");
        }
        else
        {
            Console.WriteLine("Fark, 10'a eşit ya da küçüktür.\n");
        }
    }
}
