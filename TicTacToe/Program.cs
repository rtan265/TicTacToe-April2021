using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Welcome to Tic Tac Toe!");
            Board _board = new Board();

            Console.WriteLine("Here's the current board:");
            _board.PrintBoard();

            string UserInput = Console.ReadLine();
            string[] coordinates = UserInput.Split(',');
            int x = Int32.Parse(coordinates[0]);
            int y = Int32.Parse(coordinates[1]);

            _board.PlaceAPiece(x, y);

        }
    }
}
