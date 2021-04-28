using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Board
    {
        public char[][] boardSpaces;
        public bool isPlayerOne = true;

        public Board()
        {
            boardSpaces = new char[][] { new char[] { '.', '.', '.' }, new char[] { '.', '.', '.' }, new char[] { '.', '.', '.' } };
        }

        public void PlaceAPiece(int x, int y)
        {
            if (CheckSpaceEmpty(x, y))
            {
                if (isPlayerOne)
                {
                    boardSpaces[x][y] = 'X';
                    isPlayerOne = !isPlayerOne;
                }
                else
                {
                    boardSpaces[x][y] = 'O';
                    isPlayerOne = !isPlayerOne;
                }
            }
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
            if (boardSpaces[x][y] != '.')
            {
                return false;
            }
            return true;
        }

        public int CheckStatus()
        {
            throw new NotImplementedException();
        }
    }
}


// PlaceAPiece
// PrintBoard
// CheckStatus
// CheckSpaceEmpty
// 