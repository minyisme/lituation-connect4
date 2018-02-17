namespace Connect4.Interfaces
{
    /// <summary>
    /// The IBoardRenderer interface, represents something that renders the board to somewhere
    /// </summary>
    public interface IBoardRenderer
    {
        /// <summary>
        /// Render the specified board
        /// </summary>
        /// <param name="board">The board</param>
        void Render(IBoard board);
    }
}
