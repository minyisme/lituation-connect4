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
            // make sure GetPiece works in both cases
        }

        [TestMethod]
        public void TestAddPieceInvalidColumn()
        {
            // make sure AddPiece throws an InvalidMoveException if the column is invalid
            // use ExpectedException
        }

        [TestMethod]
        public void TestAddPieceColumnIsFull()
        {
            // make sure AddPiece throws an InvalidMoveException if the column is full
            // use ExpectedException
        }

        [TestMethod]
        public void TestAddPiece()
        {
            // make sure AddPiece works correctly according to the game rules
        }

        [TestMethod]
        public void TestIsColumnFull()
        {
            // make sure IsColumnFull works in both cases
        }

        [TestMethod]
        public void TestIsFullReturnsTrue()
        {
            // make sure IsFull works in both cases
        }
    }
}
