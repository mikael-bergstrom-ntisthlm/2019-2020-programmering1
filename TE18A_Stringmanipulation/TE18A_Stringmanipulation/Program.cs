using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18A_Stringmanipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Micke Bergström";

            //string newName = name.ToLower();

            //name = name.Replace("Micke", "Mikael");

            

            int position = name.IndexOf(" ");

            Console.WriteLine(name.Substring(position).Trim());
            

            Console.ReadLine();
        }
    }
}
