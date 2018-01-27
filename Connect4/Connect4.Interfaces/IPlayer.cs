namespace Connect4.Interfaces
{
    /// <summary>
    /// The IPlayerInterface, represents a game player
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// The player's name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The player's label, shown when drawing the player's pieces on the board
        /// </summary>
        char Label { get; set; }

        /// <summary>
        /// Get a move from the player
        /// </summary>
        /// <returns>The move</returns>
        IMove GetMove();
    }
}
