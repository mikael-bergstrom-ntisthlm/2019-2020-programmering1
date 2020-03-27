using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18B_Arrayer_listor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            Random generator = new Random();

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = generator.Next(12);
            }

            int[] otherNumbers = { 4, 7, 12, 66 };

            List<int> moreNumbers = new List<int>();

            moreNumbers.Add(7);
            moreNumbers.RemoveAt(0);

            Console.WriteLine(moreNumbers[0]);

            Console.ReadLine();
        }
    }
}
