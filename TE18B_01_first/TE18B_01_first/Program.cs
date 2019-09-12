using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TE18B_01_first
{
    class Program
    {
        static void Main(string[] args)
        {
            //string efternamn = "Bergström";

            string namn = Console.ReadLine();
            
            Console.WriteLine("Hello, " + namn);

            if (namn == "Micke")
            {
                Console.WriteLine("Du är bäst!");
            }
            else
            {
                Console.WriteLine("Du är nästan bäst, du också!");
            }



            Thread.Sleep(500);

            Console.WriteLine("hej");
            

            namn = "Henry";

            Console.ReadLine();
        }
    }
}
