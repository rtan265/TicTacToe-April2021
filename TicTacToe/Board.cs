using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Board
    {
        public char[][] dimensions { get; set; }
        public int counter { get; set; }
        private PrintService print { get; set; }

        public Board()
        { 
            dimensions = new char[][] { new char[] { '.', '.', '.'}, new char[] { '.', '.', '.'}, new char[] { '.', '.', '.'} };
            counter = 0;
            print = new PrintService();
        }

        public Board(char[][] givenDimension)
        {
            dimensions = givenDimension;
            counter = 0;
            for (int i = 0; i < givenDimension.Length; i++)
            {
                for (int j = 0; j < givenDimension[i].Length; j++)
                {
                    if (givenDimension[i][j] != '.')
                    {
                        counter++;
                    }
                }
            }
            print = new PrintService();
        }

        public bool PlaceAPiece(int x, int y, Player playerOne)
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
                return true;
            }
            else
            {
                print.PieceIsBlocked();
                print.PrintBoard(dimensions);
                return false;
            }
        }

        public bool CheckBoardStatus(char piece)
        {
            print.PrintBoard(dimensions);
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
