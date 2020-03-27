using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18B_Tuplar
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 100;

            int[] enemyHps = { 66, 77 };

            (int hp, string name) enemy1 = (100, "Herbert");

            Console.WriteLine(enemy1);

            (int hp, string name)[] enemies =
            {
                (100, "Herbert"),
                (299, "Albert")
            };

            //Console.WriteLine(enemies[0].name);

            (string, int, string) result = GimmieThings();

            Console.WriteLine(result.Item1);


            Console.ReadLine();
        }

        static (string, int, string) GimmieThings()
        {
            return ("hej", 66, "bananer");
        }
    }
}
