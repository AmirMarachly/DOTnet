using System;
using System.Collections.Generic;
using System.Text;

namespace Morpion
{
    class Board : WinCondition
    {
        private string[,] tab;
        private readonly int size;
        private const int NUMBER_OF_PLAYER = 2;
        private string[] tokens;
        private readonly Player[] players;
        private string nameTurn;
        private string tokenTurn;
        private int index;
        private int numberOfTurn;

        public int Size
        {
            get { return size; }
        }

        public string NameTurn
        {
            get { return nameTurn; }
        }

        public string TokenTurn
        {
            get { return tokenTurn; }
        }

        public string this[int i, int j]
        {
            get { return tab[i, j]; }
            set { tab[i, j] = value; }
        }

        public Board(int _size)
        {
            size = _size;
            tab = new string[size,size];

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    tab[i, j] = " ";
                }
            }

            players = new Player[NUMBER_OF_PLAYER];
            tokens = new string[NUMBER_OF_PLAYER];


            tokens[0] = "X";
            tokens[1] = "O";

            index = 0;
            numberOfTurn = 0;

    }

        /// <summary>
        /// this methode init players
        /// </summary>
        /// <param name="player1">Player : first player</param>
        /// <param name="player2">Player : second player</param>
        public void initPlayer(Player player1, Player player2)
        {
            players[0] = player1;
            players[1] = player2;
            nameTurn = player1.Name;
            tokenTurn = tokens[index];
        }

        /// <summary>
        /// this methode play on the coordinate that is passed
        /// </summary>
        /// <param name="coor">the coordinate were the player want to play</param>
        /// <returns>Return true if there is a win, false otherwise</returns>
        public bool Play(int[] coor)
        {
           
            this[coor[1], coor[0]] = tokenTurn;

            bool win = WinCondition.CheckWin(this);

            numberOfTurn++;
            index = numberOfTurn % 2;
            if(!win)
            {
                nameTurn = players[index].Name;
                tokenTurn = tokens[index];
            }
            
            return win;
        }

        /// <summary>
        /// This methode check if the cell in y, x is free or not
        /// </summary>
        /// <param name="x">The horizontal coordinate</param>
        /// <param name="y">The vertical coordinate</param>
        /// <returns>Return true if the cell is free, false otherwise</returns>
        public bool IsFree(int x, int y)
        {
            return this[y, x] == " ";
        }

        /// <summary>
        /// This method check if the board is full or not
        /// </summary>
        /// <returns>Return true if the board is full, false otherwise</returns>
        public bool IsFull()
        {
            return numberOfTurn >= (size * size);
        }
    }
}
