using System;

namespace Morpion
{
    class Program
    {

        static void Main(string[] args)
        {
            int boardSize = 3;
            bool win = false;
            int[] coor;

            Board board = new Board(boardSize);
            Printer printer = new Printer(board);

            printer.PrintInit();

            while (!win && !board.IsFull())
            {

                printer.PrintBoard();
                do
                {
                    coor = printer.PrintCoor();
                } while (!board.IsFree(coor[0], coor[1]));

                win = board.Play(coor);

            }

            printer.PrintBoard();
            if (win)
            {
                printer.PrintWin();
            }
            else
            {
                printer.PrintDraw();
            }

        }
    }
}
