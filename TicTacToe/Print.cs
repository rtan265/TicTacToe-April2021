using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Print
    { 
        public string toBePrinted { get; set; }

        public Print()
        {
            toBePrinted = "";
        }

        public void WelcomeToTicTacToe()
        {
            toBePrinted = "Welcome to Tic Tac Toe! \nHere's the current board: \n";
            PrintResult();
        }

        public void PlayerOneTurn()
        {
            toBePrinted = "Player 1 enter a coord x, y to place your X or enter 'q' to give up: ";
            PrintInputLine();
        }

        public void PlayerTwoTurn()
        {
            toBePrinted = "Player 2 enter a coord x, y to place your X or enter 'q' to give up: ";
            PrintInputLine();
        }

        public void PrintNewLine()
        {
            toBePrinted = "";
            PrintResult();
        }

        public void PlayerOneWon()
        {
            toBePrinted = "Player 1 has won the game!";
            PrintResult();
        }

        public void PlayerTwoWon()
        {
            toBePrinted = "Player 2 has won the game!";
            PrintResult();
        }

        public void InputError()
        {
            toBePrinted = "Input error, please write in the following format: x,y or 'q'  \n";
            PrintResult();
        }

        public void PieceIsBlocked()
        {
            toBePrinted = "Oh no, a piece is already at this place! Try again... \n";
            PrintResult();
        }

        public void GameIsDrawn()
        {
            toBePrinted = "Game is a draw. \n";
            PrintResult();
        }

        public void GetWinner(char piece)
        {
            if (piece == 'X')
            {
                PlayerOneWon();
            }
            else
            {
                PlayerTwoWon();
            }
        }

        public void MoveAccepted()
        {
            toBePrinted = "Move accepted, here's the current board:";
            PrintResult();
        }

        public void PrintBoard(char[][] dimensions)
        {
            for (int i = 0; i < dimensions.Length; i++)
            {
                for (int j = 0; j < dimensions[i].Length; j++)
                {
                    Console.Write(dimensions[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void PrintBoard(Board board)
        {
            for (int i = 0; i < board.dimensions.Length; i++)
            {
                for (int j = 0; j < board.dimensions[i].Length; j++)
                {
                    Console.Write(board.dimensions[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private void PrintResult()
        {
            Console.WriteLine(toBePrinted);
        }

        private void PrintInputLine()
        {
            Console.Write(toBePrinted);
        }

    }
}
