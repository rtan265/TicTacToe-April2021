using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Board
    {
        public char[][] dimension { get; set; }

        public Board()
        { 
            dimension = new char[][] { new char[] { '.', '.', '.'}, new char[] { '.', '.', '.'}, new char[] { '.', '.', '.'} };
        }


    }
}
