using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18A_Arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] roomDescriptions = {
                "KITCHEN - dirty and smelly, dishes everywhere. Is that a sock in the dishwasher?",
                "GARDEN - Tall grass, lawnmower on fire, gnomes everywhere. One of them steals your wallet."
            };


            int currentRoom = 0;

            while (true)
            {
                Console.WriteLine(roomDescriptions[currentRoom]);

                if (currentRoom == 0)
                {
                    Console.ReadLine();
                    currentRoom = 1;
                }

                else if (currentRoom == 1)
                {
                    Console.ReadLine();
                    currentRoom = 0;
                }

            }




            string name = "Micke";

            string[] names = new string[3];

            name = "Henrietta";

            names[1] = "Ida";

            names[1] = names[1].ToUpper();

            Console.WriteLine(names[1] + " är ett namn");


            string[] classes = { 
                "Warrior", 
                "Mage", 
                "Duck", 
                "Clown", 
                "Ollonborre" 
            };

            Random generator = new Random();

            int i = generator.Next(classes.Length);

            Console.WriteLine(classes[i]);

            Console.WriteLine(classes[89]);


            Console.ReadLine();
        }
    }
}
