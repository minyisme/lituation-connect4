using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4.Interfaces
{
    /// <summary>
    /// The Board interface, represents a board abstraction
    /// </summary>
    public interface IBoard
    {
        /// <summary>
        /// The number of rows on the board
        /// </summary>
        int NumRows { get; }

        /// <summary>
        /// The number of columns on the board
        /// </summary>
        int NumColumns { get; }

        /// <summary>
        /// Get the piece at the specified location
        /// </summary>
        /// <param name="column">The column</param>
        /// <param name="row">The row</param>
        /// <returns>The piece, or null if there is none</returns>
        IPiece GetPiece(int column, int row);

        /// Add a piece to the board
        /// </summary>
        /// <param name="piece">The piece to be placed</param>
        /// <param name="column">The column number</param>
        void AddPiece(IPiece piece, IMove move);

        /// <summary>
        /// Is the specified column full?
        /// </summary>
        /// <param name="column">The column</param>
        /// <returns>True if the column is full, false otherwise</returns>
        bool IsColumnFull(int column);

        /// <summary>
        /// Is the board full?
        /// </summary>
        /// <returns>True if yes, false otherwise</returns>
        bool IsFull();

        /// <summary>
        /// Draw the board
        /// </summary>
        void Draw(IBoardRenderer renderer);
    }
}
