using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE18B_Tvådimensionella_arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            int[,] chessBoard = new int[8, 8];

            chessBoard[0, 1] = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    Console.Write(chessBoard[x, y] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
