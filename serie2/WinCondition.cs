using System;
using System.Collections.Generic;
using System.Text;

namespace Morpion
{

    interface WinCondition
    {
        /// <summary>
        /// this method check in the board if there is a win
        /// </summary>
        /// <param name="b">The board where you want to check</param>
        /// <returns>Return true if there is a win, false otherwise</returns>
        public static bool CheckWin(Board b)
        {
            bool win = false;


            for (int i = 0; i < b.Size; i++)
            {
                if (b[i, 0].Equals(b[i, 1]) && b[i, 0].Equals(b[i, 2]) && !b[i,0].Equals(" "))
                {
                    win = true;
                }
                if (b[0, i].Equals(b[1, i]) && b[0, i].Equals(b[2, i]) && !b[0, i].Equals(" "))
                {
                    win = true;
                }
            }

            if (b[0, 0].Equals(b[1, 1]) && b[0, 0].Equals(b[2, 2]) && !b[1, 1].Equals(" "))
            {
                win = true;
            }

            if (b[2, 0].Equals(b[1, 1]) && b[0, 0].Equals(b[0, 2]) && !b[1, 1].Equals(" "))
            {
                win = true;
            }

            return win;
        }
    }
}
