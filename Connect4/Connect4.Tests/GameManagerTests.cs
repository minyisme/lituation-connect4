using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Connect4.Tests
{
    [TestClass]
    public class GameManagerTests
    {
        // ONLY DO THIS IF YOU HAVE TIME. Otherwise, just test manually by calling
        // gameManager.StartGame() from Main() and playing the game

        // At this point, we've already tested all the game components in isolation

        // Testing the game loop is more difficult than the unit tests you've written so far
        // It requires lots of mocking, especially since the game will keep asking for moves if they are invalid

        // One way to do this is to create a MockOutputProvider that writes to a file,
        // then parse the file to make sure the output is correct

        // I chose to do it with game state, since it's a bit easier to check, though
        // the testing is not as thorough.


        [TestMethod]
        public void TestPerformSingleTurnInvalidInputException()
        {
            // create a MockPlayer that will throw an InvalidInputException when GetMove() is called

            // create a game manager
            // Call gameManager.PerformSingleTurn(), passing in the player you created

            // Verify that the game state is still WaitingForUserInput
        }

        [TestMethod]
        public void TestPerformSingleTurnInvalidMoveException()
        {
            // create a MockPlayer that will return a Move when GetMove() is called
            // Make sure the column in the move is invalid (like negative)

            // create a game manager
            // Call gameManager.PerformSingleTurn(), passing in the player you created

            // Verify that the game state is still PerformingMove
        }

        [TestMethod]
        public void TestPerformSingleTurn()
        {
            // create a MockPlayer that will return a valid Move when GetMove() is called
            // Make sure the column in the move is valid

            // create a game manager
            // Call gameManager.PerformSingleTurn(), passing in the player you created

            // Verify that the game state is still CheckingForGameOver
        }

        [TestMethod]
        public void TestPerformSingleTurnWinner()
        {
            // create a mock win checker that will return true when checking for a win
            // call gameManager.PerformSingleTurn(), passing in the MockPlayer

            // Verify that the game state is Winner
        }

        [TestMethod]
        public void TestPerformSingleTurnDraw()
        {
            // create a mock board that will return true when checking for a full board
            // call gameManager.PerformSingleTurn(), passing in the MockPlayer

            // Verify that the game state is Draw
        }
    }
}
