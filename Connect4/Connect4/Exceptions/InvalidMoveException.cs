using System;

namespace Connect4.Exceptions
{
    /// <summary>
    /// Exception representing an invalid move
    /// </summary>
    public class InvalidMoveException : Exception
    {
        public InvalidMoveException()
        {
        }

        public InvalidMoveException(string message)
        : base(message)
        {
        }

        public InvalidMoveException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
