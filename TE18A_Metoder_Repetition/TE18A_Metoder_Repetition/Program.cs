using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18A_Metoder_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 5;

            int min = 3;
            int max = 10;

            int u = 0;
            if (int.TryParse(Console.ReadLine(), out u))
            {
                u = LimitRange(u, min, max);
            }
            EnMetod();
        }

        static int LimitRange(int value, int min, int max)
        {
            if (value < min)
            {
                return min;
            }
            if (value > max)
            {
                return max;
            }

            return value;
        }

        

        static void EnMetod()
        {
            Console.WriteLine("Do Something");

            Console.WriteLine(t);

            while (1 == 1)
            {
                Console.WriteLine("FOREVER");
            }

        }



    }
}
