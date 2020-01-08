using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18B_Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 9;

            if (i < 10)
            {

            }

            //SayHello();

            /*int j = 10;
            while (j > 0)
            {

            }*/

            for (int k = 0; k < 100; k++)
            {
                
            }

            Console.WriteLine("");

            string a = GetAnswer("Vad heter du?", "pontus");


            Console.WriteLine("Answer is " + a);

            Console.ReadLine();
        }

        static void SayHello()
        {
            Console.WriteLine("HELLO!");
        }

        static string GetAnswer(string question, string special)
        {
            string answer = "";

            while (answer == "")
            {
                Console.WriteLine("--== " + question + "==--");
                answer = Console.ReadLine();
            }

            if (answer == special)
            {
                return answer.ToUpper();
            }
            else
            {
                return answer;
            }

        }

    }
}
