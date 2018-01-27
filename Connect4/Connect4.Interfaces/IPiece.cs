using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4.Interfaces
{
    /// <summary>
    /// The Piece interface, represents a piece on the board
    /// </summary>
    public interface IPiece
    {
        /// <summary>
        /// The owner of the piece
        /// </summary>
        IPlayer Owner { get; }
    }
}
