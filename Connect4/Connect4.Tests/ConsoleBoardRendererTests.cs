using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Connect4.Tests
{
    [TestClass]
    public class ConsoleBoardRendererTests
    {
        /*
         * The ConsoleBoardRenderer writes to the console, which is not easily tested.
         * To fix this, redirect the Console output to a StringWriter.
         * Then you can verify the contents using ToString(). This is shown below.
         * This won't check colors, but it will check contents, which is good enough :)
         * 
         * // arrange
         * var str = "Hello World"; // this should be your expected board string when rendered
         * var sw = new StringWriter();
         * 
         * // act
         * Console.SetOut(sw); // this redirects the output of all Console.Writes to the StringWriter
         * Console.WriteLine(str); // this is where you would call BoardRenderer.Render(board);
         * 
         * // assert
         * Assert.AreEqual(str, sw.ToString()); // this verifies the board rendered correctly
         */

        [TestMethod]
        public void TestRender()
        {
            // create a board
            // create a mock player
            // create some mock pieces with the player as the owner
            // add the pieces to the board
            
            // redirect the Console output (see notes at the top of the class)

            // render the board

            // Verify that the board output is what you expect
        }
    }
}
