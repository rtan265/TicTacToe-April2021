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
        public string result = "";

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
                result = "The game is a draw. \n";
                isGameEnded = true;
                return;
            }

            if (counter > 4)
            {
                if (CheckRow() || CheckColumn() || CheckDiagonal())
                {
                    return;
                }
            }

            result = "Move accepted, here's the current board: \n";
        }

        public bool CheckRow()
        {
            for (int i = 0; i < boardSpaces.Length; i++)
            {
                if (boardSpaces[i][0] == boardSpaces[i][1] && boardSpaces[i][1] == boardSpaces[i][2] && boardSpaces[i][0] == boardSpaces[i][2])
                { 
                    isGameEnded = true;
                    result = "Move accepted, well done you've won the game! \n";
                    return true;
                }
            }
            return false;
        }

        public bool CheckColumn()
        {
            for (int i = 0; i < boardSpaces.Length; i++)
            {                             
                if (boardSpaces[0][i] == boardSpaces[1][i] && boardSpaces[1][i] == boardSpaces[2][i] && boardSpaces[0][i] == boardSpaces[2][i])
                {
                    isGameEnded = true;
                    result = "Move accepted, well done you've won the game! \n";
                    return true;
                }
            }
            return false;
        }

        public bool CheckDiagonal()
        {
            if ((boardSpaces[0][0] == boardSpaces[1][1] && boardSpaces[1][1] == boardSpaces[2][2] && boardSpaces[0][0] == boardSpaces[2][2]) || (boardSpaces[0][2] == boardSpaces[1][1] && boardSpaces[1][1] == boardSpaces[2][0] && boardSpaces[0][2] == boardSpaces[2][0]))
            {
                isGameEnded = true;
                result = "Move accepted, well done you've won the game! \n";
                return true;
            }

            return false;
        }
    }
}
