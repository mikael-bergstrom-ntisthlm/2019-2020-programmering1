using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18A_List_Array
{
    class Program
    {

        static List<string> MyMethod(List<string> currentInventory)
        {
            currentInventory.Add("Sword");

            return currentInventory;
        }

        static void Main(string[] args)
        {

            List<string> inventory = new List<string>();
            inventory.Add("Potion");

            inventory = MyMethod(inventory);


            Random generator = new Random();

            int[] numbers = new int[200];

            for (int i = 0; i < 200; i++)
            {
                numbers[i] = generator.Next(100);
            }

            List<int> moreNumbers = new List<int>();

            moreNumbers.Add(44);

            moreNumbers.Insert(0, 55);

            Console.WriteLine(moreNumbers[0]);

            moreNumbers.RemoveAt(0);

            Console.ReadLine();

        }
    }
}
