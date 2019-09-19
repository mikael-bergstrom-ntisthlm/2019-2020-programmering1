using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18B_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();

            int num = 0;

            bool success = int.TryParse(answer, out num);

            if (success == false)
            {
                Console.WriteLine("Fan vad dum du är! En SIFFRA skulle du skriva!");
            }
            else
            {
                Console.WriteLine("Bra jobbat!");
            }


            Console.WriteLine(num + 5);





            /*Random generator = new Random();
            int u = generator.Next(10);




            Random generator2 = new Random();

            int i = 0;
            while (i < 2000)
            {
                int e = generator.Next();
                int f = generator2.Next();

                Console.WriteLine(e + " :: " + f);

                i++;
            }*/

            /*int dmg = generator.Next(5, 11);

            Console.WriteLine(dmg);*/

            Console.ReadLine();

        }
    }
}
