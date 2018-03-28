using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Connect4.Tests
{
    [TestClass]
    public class Connect4WinCheckerTests
    {
        [TestMethod]
        public void TestIsWinHorizontal()
        {
            // make sure IsWin works when there is a horizontal 4 in a row
            // for a board and move you specify

            // you should test all 4 cases here, since the move can be any part of the
            // 4-in-a-row

            // for example, create a board, put pieces in until it contains a horizontal 4 in a row
            // then test IsWin for each column/row in the 4-in-a-row and make sure
            // it returns true for all 4 spots
        }

        [TestMethod]
        public void TestIsWinVertical()
        {
            // make sure IsWin works when there is a vertical 4 in a row
            // for a board and move you specify

            // Only one case needed here, since the piece must be the top piece

            // for example, create a board, put pieces in until it contains a vertical 4 in a row
            // then test IsWin for the column/row of the top piece
        }

        [TestMethod]
        public void TestIsWinDiagonal1()
        {
            // make sure IsWin works when there is a diagonal 4 in a row
            // for a board and move you specify

            // you should test all 4 cases here, since the move can be any part of the
            // 4-in-a-row

            // for example, create a board, put pieces in until it contains a diagonal 4 in a row
            // then test IsWin for each column/row in the 4-in-a-row and make sure
            // it returns true for all 4 spots
        }

        [TestMethod]
        public void TestIsWinDiagonal2()
        {
            // repeat the above test for the other diagonal direction
        }

        [TestMethod]
        public void TestIsWinNoWin()
        {
            // make sure IsWin returns false correctly when there is no win
            // for a board and move you specify
        }
    }
}
