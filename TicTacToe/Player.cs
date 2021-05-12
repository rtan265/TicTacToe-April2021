using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Player
    {
        public char Piece { get; set; }
        public bool isTurn { get; set; }
        public string Name { get; set; }

        public Player(char piece)
        {
            Piece = piece;

            if (piece == 'X')
            {
                isTurn = true;
                Name = "1";
            }
            else
            {
                isTurn = false;
                Name = "2";
            }
        }
    }
}
