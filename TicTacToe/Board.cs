using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Board
    {
        public char[][] boardSpaces;

        public Board()
        {
            boardSpaces = new char[][] { new char[] { '.', '.', '.' }, new char[] { '.', '.', '.' }, new char[] { '.', '.', '.' } };
        }

        public void PlaceAPiece(char piece, int x, int y)
        {
            throw NotImplementedException;
        }

        public void PrintBoard()
        {
            for (int i = 0; i < boardSpaces.Length; i++)
            {
                for (int j = 0; j < boardSpaces[i].Length; j++)
                {
                    Console.Write(boardSpaces[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public bool CheckSpaceEmpty(int x, int y)
        {
            throw NotImplementedException;
        }

        public int CheckStatus()
        {
            throw NotImplementedException;
        }
    }
}


// PlaceAPiece
// PrintBoard
// CheckStatus
// CheckSpaceEmpty
// 