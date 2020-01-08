using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18A_Metoder_på_riktigt
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();

            int hp = MakeMeANumber();

            Console.WriteLine(hp);

            string namn = GimmeAnswer("Vad heter du?", 7);
            string klass = GimmeAnswer("Vilken klass vill du spela?", 3);

            /*if ( 3 < 6)
            {

            }

            while (1 < 3)
            {

            }*/
            SayHello();
            SayHello();
            SayHello();



            Console.ReadLine();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        static string GimmeAnswer(string question, int minLength)
        {
            string s = "";

            while (s.Length < minLength)
            {
                Console.WriteLine(question);
                s = Console.ReadLine();
                s = s.Trim();
            }

            return s;
        }

        static string GimmeName()
        {
            string s = "";

            while (s.Length == 0)
            {
                Console.WriteLine("Vad heter du?");
                s = Console.ReadLine();
                s = s.Trim();
            }

            return s;
        }

        static string GimmeClass()
        {
            string s = "";

            while (s.Length == 0)
            {
                Console.WriteLine("Vilken klass vill du spela?");
                s = Console.ReadLine();
                s = s.Trim();
            }

            return s;
        }

        static int MakeMeANumber()
        {
            Random generator = new Random();

            int n = generator.Next(10);
            if (n < 2)
            {
                return n;
            }
            else if (n > 1)
            {
                return n;
            }

            return 0;
            
        }
    }
}
