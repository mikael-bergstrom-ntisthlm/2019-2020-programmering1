using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18B_ForForFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                i++;
            }

            Console.WriteLine(i);


            for (int j = 10; j >= 0; j--)
            {

            }

            for (int j = 0; j < 99; j++)
            {

            }

            string s = "";

            for(;s.Length == 0;)
            {
                s = Console.ReadLine();
            }

            int[] numbers = new int[14];

            Random generator = new Random();

            for (int q = 0; q < numbers.Length; q++)
            {
                numbers[q] = generator.Next(100);
            }

            string k = new String('-', 20);

            String l = "fgyjyf";

            Console.WriteLine(l);
        }
    }
}
