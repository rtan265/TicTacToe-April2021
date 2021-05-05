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
        public Print print { get; set; }
        public Input input { get; set; }

        public Game()
        {
            playerOne = new Player('X');
            playerTwo = new Player('O');
            board = new Board();
            print = new Print();
            input = new Input();

            isGameEnded = false;
        }

        public void StartGame()
        {
            int x, y;
            print.WelcomeToTicTacToe();
            board.PrintBoard();

            do
            {
                if (playerOne.isTurn)
                {
                    print.PlayerOneTurn(); ;
                } 
                else
                {
                    print.PlayerTwoTurn();
                }

                string UserInput = Console.ReadLine();
                if (UserInput == "q")
                {
                    if (playerOne.isTurn)
                    {
                        print.PlayerTwoWon();
                    }
                    else
                    {
                        print.PlayerOneWon();
                    }
                    break;
                }

                try
                {
                    string[] coordinates = UserInput.Split(',');
                    x = Int32.Parse(coordinates[0]) - 1;
                    y = Int32.Parse(coordinates[1]) - 1;
                    Console.WriteLine();
                    board.PlaceAPiece(x, y, playerOne, playerTwo);
                    isGameEnded = board.CheckBoardStatus(playerOne.isTurn ? 'X' : 'O');
                    FlipPlayerTurn(playerOne, playerTwo);
                }
                catch
                {
                    print.InputError();
                    board.PrintBoard();
                }
            } while (!isGameEnded);
        }

        private void FlipPlayerTurn(Player playerOne, Player playerTwo)
        {
            playerOne.isTurn = !playerOne.isTurn;
            playerTwo.isTurn = !playerTwo.isTurn;
        }
    }
}
