using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        0 ile 100 arasındaki sayılardan 7 ile bölümünden kalan 3 olan sayıların kaç tane olduğunu
        hesaplayıp ekrana yazdıran programı yazınız.
        */

        int adet = 0;

        for (int i = 0; i <= 100; i++)
        {
            if (i % 7 == 3)
            {
                adet++;
                Console.WriteLine(i);
            }
        }
        Console.WriteLine($"7 ile bölümünden kalan 3 olan sayıların adeti: {adet}");
    }
}
