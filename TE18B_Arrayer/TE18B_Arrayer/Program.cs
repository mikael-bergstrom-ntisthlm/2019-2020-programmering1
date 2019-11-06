using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18B_Arrayer
{
    class Program
    {
        static void Main(string[] args)
        {

            string enemy1Name = "Bob";
            string enemy2Name = "Eddie";
            string enemy3Name = "Pelle";

            /*Console.WriteLine(enemy1Name);
            Console.WriteLine(enemy2Name);
            Console.WriteLine(enemy3Name);*/

            string[] enemyNames = { "Bob", "Eddie", "Pelle", "Herbert", "Ingegärd" };

            Random generator = new Random();
            //enemyNames[i] = "Eva-Lena";
            //int i = generator.Next(enemyNames.Length);

            int i = 0;
            while (i < enemyNames.Length)
            {
                Console.WriteLine(enemyNames[i] + " är inte snäll");
                i++;
            }

            for (int j = 0; j < enemyNames.Length; j++)
            {
                Console.WriteLine(enemyNames[j] + " är inte snäll");
            }
            




            Console.ReadLine();
        }
    }
}
