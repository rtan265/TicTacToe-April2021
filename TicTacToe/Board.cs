using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Board
    {
        public char[][] dimensions { get; set; }
        public int counter { get; set; }
        private PrintService _printService { get; set; }

        public Board()
        { 
            dimensions = new char[][] { new char[] { '.', '.', '.'}, new char[] { '.', '.', '.'}, new char[] { '.', '.', '.'} };
            counter = 0;
            _printService = new PrintService();
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
            _printService = new PrintService();
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
                _printService.MoveAccepted();
                counter++;
                return true;
            }
            else
            {
                _printService.PieceIsBlocked();
                _printService.PrintBoard(dimensions);
                return false;
            }
        }

        public bool CheckBoardStatus(Player player)
        {
            _printService.PrintBoard(dimensions);
            if (counter == 9)
            {
                _printService.GameIsDrawn();
                return true;
            }

            if (CheckRow(player) || CheckColumn(player) || CheckDiagonal(player))
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

        private bool CheckRow(Player player)
        {
            for (int i = 0; i < dimensions.Length; i++)
            {
                if (dimensions[i][0] == player.Piece && dimensions[i][1] == player.Piece && dimensions[i][2] == player.Piece)
                {
                    _printService.PlayerWon(player.Name);
                    return true;
                }
            }
            return false;
        }

        private bool CheckColumn(Player player)
        {
            for (int i = 0; i < dimensions.Length; i++)
            {
                if (dimensions[0][i] == player.Piece && dimensions[1][i] == player.Piece && dimensions[2][i] == player.Piece)
                {
                    _printService.PlayerWon(player.Name);
                    return true;
                }
            }
            return false;
        }

        private bool CheckDiagonal(Player player)
        {
            if ((dimensions[0][0] == player.Piece && dimensions[1][1] == player.Piece && dimensions[2][2] == player.Piece || (dimensions[0][2] == player.Piece && dimensions[1][1] == player.Piece && dimensions[2][0] == player.Piece))
            {
                _printService.PlayerWon(player.Name);
                return true;
            }

            return false;
        }

    }
}
