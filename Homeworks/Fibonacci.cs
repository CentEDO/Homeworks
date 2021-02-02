using System;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 0;
            int sayi2 = 1;
            Console.WriteLine("0");
            Console.WriteLine("1");

            for (int i = 0; i < 10; i++)
            {
                int toplam = sayi1 + sayi2;

                Console.WriteLine(toplam);
                sayi1 = sayi2;
                sayi2 = toplam;
            }

        }

        
    }
    
    
}
