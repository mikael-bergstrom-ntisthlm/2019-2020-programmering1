using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18A_02_villkor
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Micke";

            name = "Lars";

            int hp = 100 / 3;


            hp = hp - 1;

            hp = hp + 1;

            hp += 5;

            hp++;

            Console.WriteLine(hp);

            if (hp < 1)
            {
                Console.WriteLine("GAME OVER!");
            }
            else
            {
                Console.WriteLine("NOT GAME OVER!");
            }

            name = Console.ReadLine();

            if (name == "Micke")
            {
                Console.WriteLine("U R TEH BEST");
            }
            else
            {
                Console.WriteLine("BOOOOOH!");
            }



            Console.ReadLine();
        }
    }
}
