using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18A_01_Grunderna
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello, TE18A");

            string svar = "g";

            // athwr6u
            svar = Console.ReadLine();

            string verb1 = Console.ReadLine();
            string verb2 = Console.ReadLine();
            string namn = Console.ReadLine();

            Console.WriteLine(namn + " älskar att " + verb1 + " och " + verb2 + "!");


            Console.WriteLine("Hej " + svar + "!" + svar + " har kul idag!");

            Console.ReadLine();
        }
    }
}
