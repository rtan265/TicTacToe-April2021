using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Board
    {
        public char[][] dimensions { get; set; }
        private int counter { get; set; }

        public Board()
        { 
            dimensions = new char[][] { new char[] { '.', '.', '.'}, new char[] { '.', '.', '.'}, new char[] { '.', '.', '.'} };
            counter = 0;
        }

        public void PlaceAPiece(int x, int y, bool isPlayerOne)
        {
            if (CheckSpaceEmpty(x, y))
            {
                if (isPlayerOne)
                {
                    dimensions[x][y] = 'X';
                }
                else
                {
                    dimensions[x][y] = 'O';
                }
                CheckBoardStatus(isPlayerOne ? 'X' : 'O');
                isPlayerOne = !isPlayerOne;
                counter++;
            }
            else
            {
                Console.WriteLine("Oh no, a piece is already at this place! Try again... \n");
            }
            PrintBoard();
        }

        public void PrintBoard()
        {
            for (int i = 0; i < dimensions.Length; i++)
            {
                for (int j = 0; j < dimensions[i].Length; j++)
                {
                    Console.Write(dimensions[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private void CheckBoardStatus(char piece)
        {
            if (counter == 9)
            { 
                return;
            }

            if (CheckRow(piece) || CheckColumn(piece) || CheckDiagonal(piece))
            {
                return;
            }
        }

        private bool CheckSpaceEmpty(int x, int y)
        {
            if (dimensions[x][y] != '.')
            {
                return false;
            }
            return true;
        }

        private bool CheckRow(char piece)
        {
            for (int i = 0; i < dimensions.Length; i++)
            {
                if (dimensions[i][0] == piece && dimensions[i][1] == piece && dimensions[i][2] == piece)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckColumn(char piece)
        {
            for (int i = 0; i < dimensions.Length; i++)
            {
                if (dimensions[0][i] == piece && dimensions[1][i] == piece && dimensions[2][i] == piece)
                {   
                    return true;
                }
            }
            return false;
        }

        public bool CheckDiagonal(char piece)
        {
            if ((dimensions[0][0] == piece && dimensions[1][1] == piece && dimensions[2][2] == piece) || (dimensions[0][2] == piece && dimensions[1][1] == piece && dimensions[2][0] == piece))
            {
                return true;
            }

            return false;
        }

    }
}
