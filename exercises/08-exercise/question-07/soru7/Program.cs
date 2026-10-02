using System;

class Program
{
    /*
    Bir kişinin doğum tarihini yıl olarak parametre alan ve kişinin yaşını hesaplayıp ekrana
    yazdıran bir metot tanımlayınız.
    */

    static int DogumYili(int yil)
    {
        int yas = DateTime.Now.Year - yil;
        return yas;
    }
    static void Main(string[] args)
    {
        Console.Write("\n\nDoğum yılınızı giriniz: ");
        int dogum;

        while (!int.TryParse(Console.ReadLine(), out dogum) || dogum > DateTime.Now.Year || dogum < 0)
        {
            Console.Write("\nLütfen geçerli bir yıl giriniz (Örn: 1990, 2000, 2006 vs.): ");
        }

        int simdiki_yas = DogumYili(dogum);
        Console.WriteLine("\n-----------------------------------");
        Console.WriteLine($"Yaşınız: {simdiki_yas}");
        Console.WriteLine("-----------------------------------\n");
    }
}
