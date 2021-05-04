using System;

namespace TicTacToe
{
    class Board2
    {
        public char[][] boardSpaces;
        public bool isPlayerOne = true;
        public bool isGameEnded = false;
        public int counter = 0;
        public string result = "";

        public Board2()
        {
            boardSpaces = new char[][] { new char[] { '.', '.', '.' }, new char[] { '.', '.', '.' }, new char[] { '.', '.', '.' } };
        }

        public Board2(char[][] givenBoard)
        {
            boardSpaces = givenBoard;
        }

        public void PlaceAPiece(int x, int y)
        {
            if (CheckSpaceEmpty(x, y))
            { 
                if (isPlayerOne)
                {
                    boardSpaces[x][y] = 'X';
                }
                else
                {
                    boardSpaces[x][y] = 'O';
                }
                CheckBoardStatus(isPlayerOne ? 'X' : 'O');
                isPlayerOne = !isPlayerOne;
                counter++;
            } 
            else
            {
                result = "Oh no, a piece is already at this place! Try again... \n";
            }
            PrintBoard();
        }

        public void PrintBoard()
        {
            for (int i = 0; i < boardSpaces.Length; i++)
            {
                for (int j = 0; j < boardSpaces[i].Length; j++)
                {
                    Console.Write(boardSpaces[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public bool CheckSpaceEmpty(int x, int y)
        {
            if (boardSpaces[x][y] != '.')
            {
                return false;
            }
            return true;
        }

        public void CheckBoardStatus(char piece)
        {
            if (counter == 9)
            {
                result = "The game is a draw. \n";
                isGameEnded = true;
                return;
            }

            if (CheckRow(piece) || CheckColumn(piece) || CheckDiagonal(piece))
            {
                return;
            }

            result = "Move accepted, here's the current board: \n";
        }

        public bool CheckRow(char piece)
        {
            for (int i = 0; i < boardSpaces.Length; i++)
            {
                if (boardSpaces[i][0] == piece && boardSpaces[i][1] == piece && boardSpaces[i][2] == piece)
                { 
                    isGameEnded = true;
                    result = "Move accepted, well done you've won the game! \n";
                    return true;
                }
            }
            return false;
        }

        public bool CheckColumn(char piece)
        {
            for (int i = 0; i < boardSpaces.Length; i++)
            {
                if (boardSpaces[0][i] == piece && boardSpaces[1][i] == piece && boardSpaces[2][i] == piece)
                { 
                    isGameEnded = true;
                    result = "Move accepted, well done you've won the game! \n";
                    return true;
                }
            }
            return false;
        }

        public bool CheckDiagonal(char piece)
        {
            if ((boardSpaces[0][0] == piece && boardSpaces[1][1] == piece && boardSpaces[2][2] == piece) || (boardSpaces[0][2] == piece && boardSpaces[1][1] == piece && boardSpaces[2][0] == piece && boardSpaces[1][1] == piece))
            {
                isGameEnded = true;
                result = "Move accepted, well done you've won the game! \n";
                return true;
            }

            return false;
        }
    }
}
