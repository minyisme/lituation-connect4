using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Connect4.Tests
{
    [TestClass]
    public class HumanPlayerTests
    {
        [TestMethod]
        public void TestGetMove()
        {
            // getMove uses an IMoveProvider
            // create a MockMoveProvider and pass it in when creating a new HumanPlayer
            // have this MockMoveProvider.GetMove return a hardcoded move

            // verify that HumanPlayer.GetMove works correctly
        }
    }
}
