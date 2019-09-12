using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18B_int_bool
{
    class Program
    {
        static void Main(string[] args)
        {
            string namn = "Micke";

            int howTall = 20 * 3;

            int hitPoints = 100;

            hitPoints = 50;

            hitPoints = hitPoints - 1;

            hitPoints -= 5;

            hitPoints--;
            hitPoints++;

            hitPoints = 0;

            if (hitPoints == 0)
            {
                Console.WriteLine("NOT GAME OVER!");
            }

            string userName = Console.ReadLine();

            userName = userName.ToLower();

            if (userName == "micke")
            {
                Console.WriteLine("YAY!");
            }

            Console.WriteLine(hitPoints);

            Console.ReadLine();
        }
    }
}
