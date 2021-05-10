using System;
using Xunit;
using TicTacToe;

namespace TicTacToeTests
{
    public class UnitTest1
    {
        [Fact]
        public void GivenExistingBoard_ReturnsFive()
        {
            // Arrange
            Board board = new TicTacToe.Board(new char[][] {
                new char[] { 'X', '.', 'O' },
                new char[] { 'X', 'O', '.' },
                new char[] { 'X', '.', '.' } 
            });
            
            // Assert
            Assert.Equal(5, board.counter);
        }

        [Fact]
        public void GivenANewPieceToPlace_WhereSpaceIsTaken_ReturnsFalse()
        {
            // Arrange
            Board board = new TicTacToe.Board(new char[][]
            {
               new char[] { 'X', '.', 'O' },
               new char[] { 'X', 'O', '.' },
               new char[] { 'X', '.', '.' }
            });
            Player playerOne = new TicTacToe.Player('X');

            // Act
            var result = board.PlaceAPiece(1, 1, playerOne);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void GivenANewPieceToPlace_WhereSpaceIsEmpty_ReturnsTrue()
        {
            // Arrange
            Board board = new TicTacToe.Board(new char[][]
            {
               new char[] { 'X', '.', 'O' },
               new char[] { 'X', 'O', '.' },
               new char[] { '.', '.', '.' }
            });
            Player playerOne = new TicTacToe.Player('X');

            // Act
            var result = board.PlaceAPiece(2, 0, playerOne);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void GivenExistingBoard_WhereGameIsStillGoing_ReturnsFalse()
        {
            // Arrange
            Board board = new TicTacToe.Board(new char[][]
            {
               new char[] { 'X', '.', 'O' },
               new char[] { 'X', 'O', '.' },
               new char[] { '.', '.', 'X' }
            });

            // Act
            var result = board.CheckBoardStatus('X');

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void GivenExistingBoard_WhereGameIsWon_ReturnsTrue()
        {
            // Arrange
            Board board = new TicTacToe.Board(new char[][]
            {
               new char[] { 'X', '.', 'O' },
               new char[] { 'X', 'O', '.' },
               new char[] { 'X', '.', '.' }
            });

            // Act
            var result = board.CheckBoardStatus('X');

            // Assert
            Assert.True(result);
        }

    }
}
