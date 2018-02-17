using Connect4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    /// <summary>
    /// Connect4WinChecker, represents a checker for the Connect 4 win condition
    /// </summary>
    public class Connect4WinChecker : IWinChecker
    {
        /// <summary>
        /// Check if the specified move caused a win on the specified board
        /// </summary>
        /// <param name="board">The board</param>
        /// <param name="move">The move</param>
        /// <returns>True if win, false otherwise</returns>
        public bool IsWin(IBoard board, IMove move)
        {
            // validate the inputs

            // check if the specified move is part of a 4-in-a-row (4 pieces with the same owner) on the specified board

            // Don't forget the move can be any part of the 4-in-a-row, and the 4-in-a-row
            // can be in any direction (horizontal, vertical, both diagonals)

            throw new NotImplementedException();
        }
    }
}
