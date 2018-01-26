using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Twitter.FuncTests
{
    [TestClass]
    public class TwitterInputProviderFuncTests
    {
        [TestMethod]
        public void TestTwitterInputProviderRead()
        {
            // arrange
            var provider = new TwitterInputProvider("jesta1215");   // change this to the account you want to test with

            // act
            var tweet = provider.Read();    // this will block until a tweet is received

            // assert
            Assert.IsFalse(string.IsNullOrEmpty(tweet));
        }
    }
}
