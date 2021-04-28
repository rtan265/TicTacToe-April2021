using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGameEnded = false;
            int currentPlayer = 1;
            char currentPiece = 'X';

            Console.WriteLine("Welcome to Tic Tac Toe!");
            Board _board = new Board();

            Console.WriteLine("Here's the current board:");
            _board.PrintBoard();

        }
    }
}
