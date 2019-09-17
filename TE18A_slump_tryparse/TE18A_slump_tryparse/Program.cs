using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18A_slump_tryparse
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            int num = 0;

            /*if (input == "0") { num = 0; }
            else if (input == "1") { num = 1; }
            else if (input == "2") { num = 2; }*/

            bool success = int.TryParse(input, out num);

            if (success)
            {
                Console.WriteLine("Yes, that's a number! Good!");
                Console.WriteLine(num * 100);
            }
            else
            {
                Console.WriteLine("Say what now?");
            }

            Random generator = new Random();
            Random generator2 = new Random();

            int i = 0;
            while (i < 5)
            {
                int number = generator.Next(1000);
                int number2 = generator2.Next(1000);

                Console.Write(number);
                Console.Write("-");
                Console.WriteLine(number2);

                i++;
            }
            Console.ReadLine();

        }
    }
}
