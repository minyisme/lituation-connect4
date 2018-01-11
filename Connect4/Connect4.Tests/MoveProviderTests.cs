using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Connect4.Tests
{
    [TestClass]
    public class MoveProviderTests
    {
        [TestMethod]
        public void TestGetMoveInvalidInput()
        {
            // create a MockInputProvider that implements IInputProvider
            // Have Read() return something that CAN'T be parsed into an int
            
            // Create a MoveProvider, passing in the MockInputProvider
            // Call GetMove() and verify that an InvalidInputException is thrown
            // using ExpectedException
        }

        [TestMethod]
        public void TestGetMove()
        {
            // create a MockInputProvider that implements IInputProvider
            // Have Read() return something that CAN be parsed into an int

            // Create a MoveProvider, passing in the MockInputProvider
            // Call GetMove() and verify that a valid Move is returned,
            // and that the column in the move matches what it should
        }
    }
}
