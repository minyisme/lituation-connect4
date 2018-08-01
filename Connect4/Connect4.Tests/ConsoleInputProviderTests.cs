using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Connect4.Tests
{
    [TestClass]
    public class ConsoleInputProviderTests
    {
        /*
         * The ConsoleInputProvider reads from the console, which is not easily tested.
         * To fix this, redirect the Console input to a StringReader, and pass in the string you want to read
         * 
         * // arrange
         * var expected = "Hello World"; // this is your redirected input
         * var sr = new StringReader(expected);
         * 
         * // act
         * Console.SetIn(sr); // this redirects the input of all Console.Reads to the StringReader
         * var actual = Console.ReadLine(); // this is where you would call ConsoleInputProvider.Read()
         * 
         * // assert
         * Assert.AreEqual(expected, actual); // this verifies you can read from the console correctly
         */

        [TestMethod]
        public void TestRead()
        {
        }
    }
}
