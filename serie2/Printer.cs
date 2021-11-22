using System;
using System.Collections.Generic;
using System.Text;

namespace Morpion
{
    class Printer
    {
        private Board board;
        public Printer(Board _board)
        {
            board = _board;
        }

        /// <summary>
        /// this method clear the console and display the board on it
        /// </summary>
        public void PrintBoard()
        {
            Console.Clear();
            string print = "\n";
            for(int i = 0; i < board.Size; i++)
            {
                print += "  ";
                for(int j = 0; j < board.Size; j++)
                {
                    print += " " + board[i, j];
                    if (j < board.Size - 1)
                        print += " | ";
                }
                if (i < board.Size - 1)
                    print += "\n ----+----+----\n";
            }
            Console.WriteLine(print);

        }

        /// <summary>
        /// this method ask the name of both players and init them in the Board instance
        /// </summary>
        public void PrintInit()
        {
            Console.WriteLine("1st player's name : ");
            string name1 = Console.ReadLine();

            Console.WriteLine("2nd player's name : ");
            string name2 = Console.ReadLine();

            board.initPlayer(new Player(name1), new Player(name2));
        }

        /// <summary>
        /// this method ask the wanted coordiante for the next play and check if they are correct
        /// </summary>
        /// <returns>int[2] : the coordiante</returns>
        public int[] PrintCoor()
        {
            Console.WriteLine("\nIt's " + board.NameTurn + "'s turn");

            int x = -1;
            int y = -1;


            while (x < 0 || x >= board.Size)
            {
                Console.WriteLine("X coordinates : ");
                x = int.Parse(Console.ReadLine());
            }

            while (y < 0 || y >= board.Size)
            {
                Console.WriteLine("Y coordinates : ");
                y = int.Parse(Console.ReadLine());
            }


            return new int[]{ x, y};
        }

        /// <summary>
        /// this method print the message if the match end with a win
        /// </summary>
        public void PrintWin()
        {
            Console.WriteLine("\n" + board.NameTurn + " win the game");
        }

        /// <summary>
        /// this method print the message if the match end with a draw
        /// </summary>
        public void PrintDraw()
        {
            Console.WriteLine("\nThe match is a draw");
        }
    }
}
