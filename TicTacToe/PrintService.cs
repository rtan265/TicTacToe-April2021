using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class PrintService
    {

        public void WelcomeToTicTacToe()
        {
            Console.WriteLine("Welcome to Tic Tac Toe! \nHere's the current board: \n");
        }

        public void PrintPlayerTurn(string playerName)
        {
            Console.Write($"Player {playerName} enter a coord x, y to place your X or enter 'q' to give up: ");
        }

        //Refactor playerWon
        public void PlayerOneWon()
        {
            Console.WriteLine("Player 1 has won the game!");
        }

        public void PlayerTwoWon()
        {
            Console.WriteLine("Player 2 has won the game!");
        }

        public void InputError()
        {
            Console.WriteLine("Input error, please write in the following format: x,y or 'q'  \n");
        }

        public void PieceIsBlocked()
        {
            Console.WriteLine("Oh no, a piece is already at this place! Try again... \n");
        }

        public void GameIsDrawn()
        {
            Console.WriteLine("Game is a draw. \n");
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
            Console.WriteLine("Move accepted, here's the current board:");
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

    }
}
