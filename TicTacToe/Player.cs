using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Player
    {
        public char Piece { get; set; }
        public bool isTurn { get; set; }

        public Player(char piece)
        {
            Piece = piece;

            if (piece == 'X')
            {
                isTurn = true;
            }
            else
            {
                isTurn = false;
            }
        }
    }
}
