using MilestoneConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            
        }

        public void PrintBoard(Board board)
        {
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.WriteLine(board);
                }
                Console.WriteLine();
            }
        }
    }
}
