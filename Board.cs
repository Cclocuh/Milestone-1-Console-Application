using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneConsoleApp
{
    public class Board
    {
        public int BOARD_SIZE { get; private set; }
        public object CELL_WIDTH { get; private set; }
        public object CELL_HEIGHT { get; private set; }

        //public object cell { get; private set; }

        struct CellStruct
        {
            public bool hasBomb;
            public bool hasFlag;
            public bool isUncovered;
            public int neighboringBombs;
            
        }
        public Board( ) 
        {
            const int BOARD_SIZE = 10;
            const int CELL_WIDTH = 32;
            const int CELL_HEIGHT = 64;
            CellStruct[ , ] cell = new CellStruct[BOARD_SIZE + 2, BOARD_SIZE + 2];
        }

        public Board(int BOARD_SIZE)
        {
            InitializeBoard();
            PlantBombs();
            CountNeighbors();
            gameOver();
        }

        public void InitializeBoard()
        {
           
            for (int r = 0; r < BOARD_SIZE; r++)
                for (int c = 0; c < BOARD_SIZE; c++)
                {
                    cell[r, c].hasBomb = false;
                    cell[r, c].hasFlag = false;
                    cell[r, c].isUncovered = false;
                    cell[r, c].position.Width = CELL_WIDTH;
                    cell[r, c].position.Height = CELL_HEIGHT;
                    cell[r, c].position.X = CELL_WIDTH;
                    cell[r, c].position.Y = CELL_HEIGHT;
                    cell[r, c].nieghboringBombs = 0;
                }
        }

        void PlantBombs()
        {
            Random rand = new Random();
            bool[] n = new bool[100];

            for (int i = 0; i < 90; i++) 
                n[i] = false;

            for (int i = 0;i < 100;i++)
                n[i] = true;

            for (int i = 0; i < 100; i++)
            {
                int pos = rand.Next(100);
                bool save = n[i];
                n[i] = n[pos];
                n[pos] = save;
            }

            for (int i = 0; i < 100; i++)
            {
                if (n[i])
                    Console.WriteLine("*");
                else
                    Console.WriteLine(".");
                if ((i + 1) % 10 == 0)
                    Console.WriteLine();
            }

            Console.ReadLine();

        }

        void CountNeighbors()
        {
            
        }

        void gameOver()
        {

        }
    }
}
