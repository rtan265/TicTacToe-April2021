using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Board
    {
        public char[][] boardSpaces;
        public bool isPlayerOne = true;
        public bool isGameEnded = false;
        public int counter = 0;

        public Board()
        {
            boardSpaces = new char[][] { new char[] { '.', '.', '.' }, new char[] { '.', '.', '.' }, new char[] { '.', '.', '.' } };
        }

        public void PlaceAPiece(int x, int y)
        {
            if (CheckSpaceEmpty(x, y))
            {
                Console.WriteLine("Move accepted, here's the current board: \n");
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
                counter++;
            } 
            else
            {
                Console.WriteLine("Oh no, a piece is already at this place! Try again...");
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
            Console.WriteLine();
        }

        public bool CheckSpaceEmpty(int x, int y)
        {
            if (boardSpaces[x][y] != '.')
            {
                return false;
            }
            return true;
        }

        public void CheckBoardStatus()
        {
            if (counter == 9)
            {
                Console.WriteLine("The game is a draw.");
                isGameEnded = true;
            }


        }
    }
}
