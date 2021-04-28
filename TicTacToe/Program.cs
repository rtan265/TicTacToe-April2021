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

            string line = Console.ReadLine();
            Console.WriteLine(line);

        }
    }
}
