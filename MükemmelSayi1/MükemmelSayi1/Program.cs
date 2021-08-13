using System;

namespace MükemmelSayi1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }

            if (toplam == sayi)
            {
                Console.WriteLine(sayi + " " + "Mükemmel sayıdır.");
            }
            else
            {
                Console.WriteLine(sayi + " " + "Mükemmel sayı değildir.");
            }
            Console.ReadLine();

        
    }
    }
}
