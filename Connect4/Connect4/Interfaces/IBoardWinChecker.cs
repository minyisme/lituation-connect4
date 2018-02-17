using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4.Interfaces
{
    /// <summary>
    /// IWinChecker, represents something that checks for a win condition
    /// </summary>
    public interface IWinChecker
    {
        /// <summary>
        /// Check if the specified move caused a win on the specified board
        /// </summary>
        /// <param name="board">The board</param>
        /// <param name="move">The move</param>
        /// <returns>True if win, false otherwise</returns>
        bool IsWin(IBoard board, IMove move);
    }
}
