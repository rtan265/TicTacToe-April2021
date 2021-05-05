using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Board
    {
        public char[][] dimensions { get; set; }
        private int counter { get; set; }
        private Print print { get; set; }

        public Board()
        { 
            dimensions = new char[][] { new char[] { '.', '.', '.'}, new char[] { '.', '.', '.'}, new char[] { '.', '.', '.'} };
            counter = 0;
            print = new Print();
        }

        public void PlaceAPiece(int x, int y, Player playerOne, Player playerTwo)
        {
            if (CheckSpaceEmpty(x, y))
            {
                if (playerOne.isTurn)
                {
                    dimensions[x][y] = 'X';
                }
                else
                {
                    dimensions[x][y] = 'O';
                }
                print.MoveAccepted();
                counter++;
            }
            else
            {
                print.PieceIsBlocked();
            }
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

        public bool CheckBoardStatus(char piece)
        {
            PrintBoard();
            if (counter == 9)
            {
                print.GameIsDrawn();
                return true;
            }

            if (CheckRow(piece) || CheckColumn(piece) || CheckDiagonal(piece))
            {
                return true;
            }
            return false;
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
                    print.GetWinner(piece);
                    return true;
                }
            }
            return false;
        }

        private bool CheckColumn(char piece)
        {
            for (int i = 0; i < dimensions.Length; i++)
            {
                if (dimensions[0][i] == piece && dimensions[1][i] == piece && dimensions[2][i] == piece)
                {
                    print.GetWinner(piece);
                    return true;
                }
            }
            return false;
        }

        private bool CheckDiagonal(char piece)
        {
            if ((dimensions[0][0] == piece && dimensions[1][1] == piece && dimensions[2][2] == piece) || (dimensions[0][2] == piece && dimensions[1][1] == piece && dimensions[2][0] == piece))
            {
                print.GetWinner(piece);
                return true;
            }

            return false;
        }

    }
}
