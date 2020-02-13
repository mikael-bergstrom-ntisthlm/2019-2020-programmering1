using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18A_Loopar_arrayer_repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            while (i > 0)
            {
                Console.WriteLine("All ur base are blong to us");

                i--;
            }

            int u = 99;

            for (int j = 99; j > 0; j--)
            {
                Console.WriteLine("Take off every ZIG!!!");
            }

            for (float r = 100; r > 0;  r -= 0.1f)
            {
                Console.WriteLine(r);
            }

            int t = 9;
            for (;t > 0;)
            {
                t--;
            }

            int[] nummer = new int[5];

            nummer[0] = 42;

            i = 42 + nummer[0];

            Random generator = new Random();

            for (int b = 0; b < nummer.Length; b++)
            {
                nummer[b] = generator.Next(100);

                Console.WriteLine(nummer[b]);

                if (nummer[b] > 50)
                {
                    Console.WriteLine("Stort!");
                }

            }


            Console.ReadLine();
        }
    }
}
