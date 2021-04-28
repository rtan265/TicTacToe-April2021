using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Tic Tac Toe! \n");
            Board _board = new Board();

            Console.WriteLine("Here's the current board: \n");
            _board.PrintBoard();

            do
            {
                if (_board.isPlayerOne)
                {
                    Console.Write("Player 1 enter a coord x,y to place your X or enter 'q' to give up: ");
                }
                else
                {
                    Console.Write("Player 2 enter a coord x,y to place your X or enter 'q' to give up: ");
                }

                string UserInput = Console.ReadLine();
                Console.WriteLine();
                if (UserInput == "q")
                {
                    if (_board.isPlayerOne)
                    {
                        Console.WriteLine("Player 2 has won the game!");
                    } 
                    else
                    {
                        Console.WriteLine("Player 1 has won the game!");
                    }
                    break;
                }

                string[] coordinates = UserInput.Split(',');
                int x = Int32.Parse(coordinates[0]) - 1;
                int y = Int32.Parse(coordinates[1]) - 1;

                _board.PlaceAPiece(x, y);
                _board.PrintBoard();
                _board.CheckBoardStatus();

            } while (!_board.isGameEnded);

        }
    }
}
