using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18B_String_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string h = Console.ReadLine();

            h = h.Trim().ToLower();



            int pos = h.IndexOf(" ");
            Console.WriteLine(pos);
            
            string j = h.Substring(pos+1);



            Console.WriteLine("Hej " + j + " hur mår du idag?");

            Console.ReadLine();

            

        }
    }
}
