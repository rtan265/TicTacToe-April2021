﻿using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TicTacToeTests")]
namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();
            newGame.StartGame();
        }
    }
}
