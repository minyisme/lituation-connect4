using System;
using System.Threading;

using Connect4.Interfaces;

using Tweetinvi;
using Tweetinvi.Models;

namespace Twitter
{
    /// <summary>
    /// The TwitterInputProvider class, represents an input provider that reads from twitter
    /// </summary>
    public class TwitterInputProvider : IInputProvider
    {
        // used for twitter app connection
        private const string ConsumerKey = "5sG0CLhiZOho5gPgJ8vJILRz9";
        private const string ConsumerSecret = "3sC0kG0AdPKnArwpDuauzrxER5lkZXqBNsjhV3i7uFJIfW8NGD";
        private const string AccessToken = "956312103660371968-76rd14eCeG6IxZwgCGyd1UumtH30DGw";
        private const string AccessTokenSecret = "5npjEVQWKi3O1IBql94xrGcID5Eqmst605TQgKI9LRkyZ";

        // the twitter user to follow
        private IUser user;

        public TwitterInputProvider(string twitterUser)
        {
            // set credentials
            Auth.SetUserCredentials(ConsumerKey, ConsumerSecret, AccessToken, AccessTokenSecret);

            // get the user to follow
            user = User.GetUserFromScreenName(twitterUser);
            if (user == null)
                throw new ArgumentException("Twitter user " + twitterUser + " does not exist");
        }

        /// <summary>
        /// Read the input
        /// </summary>
        /// <returns>The input</returns>
        public string Read()
        {
            var tweet = string.Empty;

            // create a stream
            var fs = Stream.CreateFilteredStream();

            // follow the specified user
            fs.AddFollow(user);

            // subscribe to tweet events
            fs.MatchingTweetReceived += (sender, args) =>
            {
                tweet = args.Tweet.ToString();
                fs.StopStream();
            };

            // start the stream
            // this blocks until the stream is stopped
            fs.StartStreamMatchingAllConditions();

            return tweet;
        }
    }
}
