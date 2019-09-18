using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18B_Loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();

            while (answer != "a" && answer != "b" && answer != "c")
            {
                answer = Console.ReadLine();
            }

            Console.WriteLine("Yay!");



            string name = Console.ReadLine();

            while (name.Length == 0)
            {
                Console.WriteLine("Nej nej, dumsnut!");
                name = Console.ReadLine();
            }

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Räkning: " + i);
                i++;
            }

            Console.WriteLine("Hej " + name + "!");

            

            Console.ReadLine();
        }
    }
}
