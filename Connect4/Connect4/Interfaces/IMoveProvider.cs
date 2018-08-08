﻿namespace Connect4.Interfaces
{
    /// <summary>
    /// The IMoveProvider interface, represents something that provides moves
    /// </summary>
    public interface IMoveProvider
    {
        /// <summary>
        /// Get a move
        /// </summary>
        /// <returns>The move</returns>
        IMove GetMove(int column);
    }
}
