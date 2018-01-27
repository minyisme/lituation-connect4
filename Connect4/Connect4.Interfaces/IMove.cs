using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4.Interfaces
{
    /// <summary>
    /// The IMove interface, represents a game move
    /// </summary>
    public interface IMove
    {
        /// The column where the piece should be dropped
        /// </summary>
        int Column { get; set; }

        /// <summary>
        /// The row where the piece ends up
        /// </summary>
        int Row { get; set; }

    }
}
