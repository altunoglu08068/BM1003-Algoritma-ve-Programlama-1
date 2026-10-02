using System;

class Program
{
    // Kendisine parametre olarak gönderilen bir tamsayı diziyi ekrana yazdıran bir metot yazınız.

    static void DiziYazdirma(int[] x)
    {
        Console.Write("[");
        for (int i = 0; i < x.Length; i++)
        {
            Console.Write(x[i]);

            if (i < x.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
    static void Main(string[] args)
    {
        Console.Clear();

        int[] dizi = new int[5];
        Random r = new Random();
        
        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = r.Next(0, 11);
        }

        Console.Write("Oluşturulan Dizi: ");
        DiziYazdirma(dizi);
        Console.WriteLine();
    }
}
