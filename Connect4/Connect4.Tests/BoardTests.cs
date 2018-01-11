using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Connect4.Tests
{
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        public void TestGetPiece()
        {
            // make sure GetPiece works when there is a piece
        }

        [TestMethod]
        public void TestGetPieceReturnsNull()
        {
            // make sure GetPiece works when there is no piece
        }

        [TestMethod]
        public void TestAddPieceInvalidColumn()
        {
            // make sure DropPiece throws an InvalidMoveException if the column is invalid
            // use ExpectedException
        }

        [TestMethod]
        public void TestAddPieceColumnIsFull()
        {
            // make sure DropPiece throws an InvalidMoveException if the column is full
            // use ExpectedException
        }

        [TestMethod]
        public void TestAddPiece()
        {
            // make sure AddPiece works correctly according to the game rules
        }

        [TestMethod]
        public void TestIsColumnFullReturnsTrue()
        {
            // make sure IsColumnFull works when the column is full
        }

        [TestMethod]
        public void TestIsColumnFullReturnsFalse()
        {
            // make sure IsColumnFull works when the column is not full
        }

        [TestMethod]
        public void TestIsFullReturnsTrue()
        {
            // make sure IsFull works when the board is full
        }

        [TestMethod]
        public void TestIsFullReturnsFalse()
        {
            // make sure IsFull works when the board is not full
        }

        [TestMethod]
        public void TestIs4InARowReturnsTrueHorizontal()
        {
            // make sure Is4InARow works when there is a horizontal 4 in a row
            // for a move you specify

            // you should test all 4 cases here, since the move can be any part of the
            // 4-in-a-row

            // for example, create a board, put pieces in until it contains a horizontal 4 in a row
            // then test Is4InARow for each column/row in the 4-in-a-row and make sure
            // it returns true for all 4 spots
        }

        [TestMethod]
        public void TestIs4InARowReturnsTrueVertical()
        {
            // make sure Is4InARow works when there is a vertical 4 in a row
            // for a move you specify

            // Only one case needed here, since the piece must be the top piece

            // for example, create a board, put pieces in until it contains a vertical 4 in a row
            // then test Is4InARow for the column/row of the top piece
        }

        [TestMethod]
        public void TestIs4InARowReturnsTrueDiagonal()
        {
            // make sure Is4InARow works when there is a diagonal 4 in a row
            // for a move you specify

            // you should test all 8 cases here, since the move can be any part of the
            // 4-in-a-row, and there are two diagonal directions

            // for example, create a board, put pieces in until it contains a diagonal 4 in a row
            // then test Is4InARow for each column/row in the 4-in-a-row and make sure
            // it returns true for all 4 spots

            // Then repeat this for the other diagonal
        }

        [TestMethod]
        public void TestIs4InARowReturnsFalse()
        {
            // make sure Is4InARow works when there is no 4 in a row
            // for a move you specify
        }
    }
}
