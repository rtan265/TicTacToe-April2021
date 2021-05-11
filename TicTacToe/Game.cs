using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Game
    {
        public PrintService _printService;
        public Board board { get; set; }
        public Player playerOne { get; set; }
        public Player playerTwo { get; set; }
        public bool isGameEnded { get; set; }


        public Game()
        {
            playerOne = new Player('X');
            playerTwo = new Player('O');
            board = new Board();
            _printService = new PrintService();

            isGameEnded = false;
        }

        public void StartGame()
        {
            int x, y;
            _printService.WelcomeToTicTacToe();
            _printService.PrintBoard(board.dimensions);

            do
            {
                if (playerOne.isTurn)
                {
                    _printService.PrintPlayerTurn(playerOne.Name);
                } 
                else
                {
                    _printService.PrintPlayerTurn(playerTwo.Name);
                }

                string UserInput = Console.ReadLine();
                if (UserInput == "q")
                {
                    if (playerOne.isTurn)
                    {
                        _printService.PlayerTwoWon();
                    }
                    else
                    {
                        _printService.PlayerOneWon();
                    }
                    break;
                }

                try
                {
                    string[] coordinates = UserInput.Split(',');
                    x = Int32.Parse(coordinates[0]) - 1;
                    y = Int32.Parse(coordinates[1]) - 1;

                    _printService.PrintLine();
                    if (board.PlaceAPiece(x, y, playerOne))
                    {

                        isGameEnded = board.CheckBoardStatus(playerOne.isTurn ? 'X' : 'O');
                        FlipPlayerTurn(playerOne);

                    }
                }
                catch
                {
                    _printService.InputError();
                    _printService.PrintBoard(board.dimensions);
                }
            } while (!isGameEnded);
        }

        private void FlipPlayerTurn(Player playerOne)
        {
            playerOne.isTurn = !playerOne.isTurn;
        }
    }
}
