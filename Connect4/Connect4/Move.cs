using Connect4.Interfaces;

namespace Connect4
{
    /// <summary>
    /// The Move class, represents a game move
    /// </summary>
    public class Move
    {
        /// <summary>
        /// The column where the piece should be dropped
        /// </summary>
        public int Column { get; set; }

        /// <summary>
        /// The row where the piece ends up
        /// </summary>
        public int Row { get; set; }

        /// <summary>
        /// Move constructor, with a column specified
        /// </summary>
        /// <param name="column"></param>
        public Move(int column)
        {
            Column = column;
            Row = -1;
        }
    }
}
