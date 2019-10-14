using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18A_Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 9;

            if (4 < 5)
            {
                y = 9;
                if (true)
                {
                    y = 10;
                }
            }

            if (2 == 2)
            {
                y = 99;
            }

            Console.WriteLine(y);



        }
    }
}
