using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18A_loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("he"); Console.WriteLine("j");

            int t = 3;

            Console.WriteLine("Skriv a, b eller c");

            string svar = "";

            while (svar != "a" && svar != "b" && svar != "c")
            {
                svar = Console.ReadLine();

                if (svar != "a" && svar != "b" && svar != "c")
                {
                    Console.WriteLine("Är du dum eller?");
                }
            }

            if (svar == "a")
            {
                Console.WriteLine("CORRECTAMUNDO");
            }


            //Console.WriteLine(t);

            /*if (t % 3 == 0)
            {
                Console.WriteLine("hej");
            }*/

            while ( t > 0)
            {
                Console.WriteLine(t);
                t--;
            }




            Console.ReadLine();
        }
    }
}
