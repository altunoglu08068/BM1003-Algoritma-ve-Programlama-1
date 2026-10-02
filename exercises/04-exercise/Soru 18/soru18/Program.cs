/*
Parametre olarak bir dizi alan ve bu dizideki negatif sayılar ile pozitif sayıların sayısını ekrana
yazdıran bir metot yazınız.
*/

using System;

namespace MyApp
{
    internal class Program
    {
        static void NegatifPozitifSayilarinAdedi(int[] dizi, out int negatifSayiAdedi, out int pozitifSayiAdedi)
        {
            negatifSayiAdedi = 0;
            pozitifSayiAdedi = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < 0)
                {
                    negatifSayiAdedi++;
                }
                else if (dizi[i] > 0)
                {
                    pozitifSayiAdedi++;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi = new int[5];

            Random rasgele = new Random();

            Console.Write("Dizi: [");
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rasgele.Next(-10, 11);

                Console.Write(dizi[i]);

                if (i < dizi.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");

            NegatifPozitifSayilarinAdedi(dizi, out int negatifSayiAdedi, out int pozitifSayiAdedi);

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Negatif sayı adedi: {negatifSayiAdedi}");
            Console.WriteLine($"Pozitif sayı adedi: {pozitifSayiAdedi}");
            Console.WriteLine("-------------------------------------------\n");
        }
    }
}