using System;

class Program
{
    // Girilen bir cümlede, girilen bir karakterden kaç tane olduğunu bulan programı yazınız.
    static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Bir cümle girin: ");
        string cumle = (Console.ReadLine() ?? "").Trim().ToLower();

        char[] dizi = new char[cumle.Length];

        Console.Write("Bir karakter girin: ");
        char karakter = char.ToLower((Console.ReadLine() ?? "").Trim()[0]);

        int sayac = 0;

        Console.WriteLine("\n---------------------------------- DİZİ -----------------------------------\n");

        Console.Write("[");
        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = cumle[i];
            Console.Write(dizi[i]);

            if (i < dizi.Length - 1)
            {
                Console.Write(", ");
            }

            if (karakter == dizi[i])
            {
                sayac++;
            }
        }

        Console.WriteLine("]");

        Console.WriteLine("\n--------------------------------------------------\n");

        Console.WriteLine($"Girdiğiniz cümlede, girdiğiniz karakterden {sayac} tane var.\n");

        Console.WriteLine("-------------------------------------------------\n");
    }
}
