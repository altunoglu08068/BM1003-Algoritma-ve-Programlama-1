using System;

class Program
{
    /*
    Parametre olarak bir dizi alan ve bu dizideki negatif sayılar ile pozitif sayıların sayısını ekrana
    yazdıran bir metot yazınız.
    */
    
    static void NegatifPozitBulma(int[,] x)
    {
        int pozitifSayac = 0;
        int negatifSayac = 0;

        for (int i = 0; i < x.GetLength(0); i++)
        {
            for (int j = 0; j < x.GetLength(1); j++)
            {
                if (x[i, j] > 0)
                {
                    pozitifSayac++;
                }
                else if(x[i,j] < 0)
                {
                    negatifSayac++;
                }
            }
        }
        Console.WriteLine($"Pozitif sayı adedi: {pozitifSayac}");
        Console.WriteLine($"Negatif sayı adedi: {negatifSayac}");
    }
    static void Main(string[] args)
    {
        Console.Clear();

        int[,] dizi = new int[3, 3];

        Random r = new Random();
        
        for (int i = 0; i < dizi.GetLength(0); i++)
        {
            Console.Write("[");

            for (int j = 0; j < dizi.GetLength(1); j++)
            {
                dizi[i, j] = r.Next(-10, 11);
                Console.Write($"{dizi[i, j], 4}");
                if (j < dizi. GetLength(1) - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }

        Console.WriteLine("\n-------------------------");
        NegatifPozitBulma(dizi);
        Console.WriteLine("-------------------------\n");
    }
}
