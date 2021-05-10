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

        public void GivenANewPiece_WhereSpaceIsTaken_ReturnsFalse()
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
            Assert.True(result);
        }
    }
}
