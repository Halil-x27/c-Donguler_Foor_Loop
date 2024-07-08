using System;

namespace Donguler
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("lütfen bir sayi giriniz");

            int sayac = int.Parse(Console.ReadLine());

            for (int i = 0; i <=sayac; i++)
            {
                if(i%2==1){
                    Console.WriteLine(i);
                }
            }

            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i <=1000; i++)
            {
                if (i%2==1)
                {
                    tekToplam +=i;
                }

                if (i%2==0)
                {
                    ciftToplam +=i;
                }
            }
            Console.WriteLine(tekToplam);
            Console.WriteLine(ciftToplam);

            //break continue

            for (int i = 0; i < 10; i++)
            {
                if(i==4){
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if(i==4){
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}