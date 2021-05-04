using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Game
    {
        public Board board { get; set; }
        public Player playerOne { get; set; }
        public Player playerTwo { get; set; }
        public bool isGameEnded { get; set; }


    }
}
