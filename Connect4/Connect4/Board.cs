using Connect4.Interfaces;
using System;

namespace Connect4
{
    /// <summary>
    /// The board class, represents the game board
    /// </summary>
    public class Board
    {
        // need a data structure of pieces to represent pieces on the board
        // (a 2D array or an array of arrays would probably be appropriate)
        // empty spots will just contain null

        // keep track of how many valid moves have been made (as well as the total spots on the board)
        // so we can tell if the board is full

        /// <summary>
        /// The board renderer, used to draw the board
        /// </summary>
        private IBoardRenderer renderer;

        /// <summary>
        /// Default constructor, uses the ConsoleBoardRenderer
        /// </summary>
        public Board() : this(new ConsoleBoardRenderer())
        {

        }

        /// <summary>
        /// Constructor with a specified IBoardRenderer, used for unit testing
        /// </summary>
        /// <param name="renderer">The renderer</param>
        public Board(IBoardRenderer renderer)
        {
            // validate the inputs
            // If renderer is null, throw an ArgumentNullException

            this.renderer = renderer;
        }

        /// <summary>
        /// Get the piece at the specified location
        /// </summary>
        /// <param name="column">The column</param>
        /// <param name="row">The row</param>
        /// <returns>The piece, or null if there is none</returns>
        public Piece GetPiece(int column, int row)
        {
            // validate the inputs
            // throw ArgumentOutOfRangeException if either is invalid
            
            // if there is no piece, return null
            throw new NotImplementedException();
        }

        /// <summary>
        /// Add a piece to the board
        /// </summary>
        /// <param name="piece">The piece to be placed</param>
        /// <param name="column">The column number</param>
        public void AddPiece(Piece piece, Move move)
        {
            // validate the inputs
            // If the piece is null, throw ArgumentNullException
            // If the move is null, throw ArgumentNullException

            // if the IsColumnValid returns false, throw InvalidMoveException with an appropriate message
            // if the IsColumnFull returns true, throw InvalidMoveException with an appropriate message

            // find out what row the piece would end up on by getting the "lowest" free space on the board for this column
            // add the piece to the board in the correct spot

            // finally, update the row in the move passed in so the caller will know where the piece ended up
            throw new NotImplementedException();
        }

        /// <summary>
        /// Is the specified column valid?
        /// </summary>
        /// <param name="column">The column number</param>
        /// <returns>True if yes, false otherwise</returns>
        public bool IsColumnValid(int column)
        {
            // write code to check if the specified column is "on the board"
            throw new NotImplementedException();
        }

        /// <summary>
        /// Is the specified row valid?
        /// </summary>
        /// <param name="row">The row number</param>
        /// <returns>True if yes, false otherwise</returns>
        public bool IsRowValid(int row)
        {
            // write code to check if the specified column is "on the board"
            throw new NotImplementedException();
        }

        /// <summary>
        /// Is the specified column full?
        /// </summary>
        /// <param name="column">The column</param>
        /// <returns>True if the column is full, false otherwise</returns>
        public bool IsColumnFull(int column)
        {
            // throw ArgumentOutOfRange if IsColumnValid() is false
            throw new NotImplementedException();
        }

        /// <summary>
        /// Is the board full?
        /// </summary>
        /// <returns>True if yes, false otherwise</returns>
        public bool IsFull()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Check if a specified column and row is part of a 4-in-a-row
        /// </summary>
        /// <param name="column">The column number</param>
        /// <param name="row">The row number</param>
        /// <returns>True if yes, false otherwise</returns>
        public bool Is4InARow(int column, int row)
        {
            // validate the inputs
            // if IsColumnValid returns false, throw ArgumentOutOfRangeException
            // if IsRowValid returns false, throw ArgumentOutOfRangeException

            // check if the board contains 4 pieces in a row (with the SAME OWNER) that contains the given move

            // Don't forget the move can be any part of the 4-in-a-row, and the 4-in-a-row
            // can be in any direction (horizontal, vertical, both diagonals)
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draw the board using the board renderer
        /// </summary>
        public void Draw()
        {
            renderer.Render(this);
        }
    }
}
