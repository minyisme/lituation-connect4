using Connect4.Interfaces;
using System;
using System.Configuration;

namespace Connect4
{
    /// <summary>
    /// The board class, represents the game board
    /// </summary>
    public class Board : IBoard
    {
        // need a data structure of IPieces to represent pieces on the board
        // (a 2D array or an array of arrays would probably be appropriate)
        // empty spots will just contain null

        // keep track of how many valid moves have been made so we can tell if the board is full

        /// <summary>
        /// The board renderer, used to draw the board
        /// </summary>
        private IBoardRenderer renderer;

        /// <summary>
        /// The number of rows on the board
        /// </summary>
        public int NumRows { get; protected set; }

        /// <summary>
        /// The number of columns on the board
        /// </summary>
        public int NumColumns { get; protected set; }

        /// <summary>
        /// Default constructor, uses the ConsoleBoardRenderer
        /// Also gets the board size from the app.config
        /// </summary>
        public Board() : this(
            new ConsoleBoardRenderer(), 
            int.Parse(ConfigurationManager.AppSettings["BoardRows"]), 
            int.Parse(ConfigurationManager.AppSettings["BoardColumns"]))
        {
        }

        /// <summary>
        /// Constructor with a specified IBoardRenderer, used for unit testing
        /// </summary>
        /// <param name="renderer">The renderer</param>
        public Board(IBoardRenderer renderer, int rows, int columns)
        {
            // validate the inputs
            // If renderer is null, throw an ArgumentNullException
            // If rows or columns <=0, throw an ArgumentOutOfRangeException

            this.renderer = renderer;
            NumRows = rows;
            NumColumns = columns;
        }

        /// <summary>
        /// Get the piece at the specified location
        /// </summary>
        /// <param name="column">The column</param>
        /// <param name="row">The row</param>
        /// <returns>The piece, or null if there is none</returns>
        public IPiece GetPiece(int column, int row)
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
        public void AddPiece(IPiece piece, IMove move)
        {
            // validate the inputs
            // If the piece is null, throw ArgumentNullException
            // If the move is null, throw ArgumentNullException

            // if the column is invalid, throw InvalidMoveException with an appropriate message
            // if the if the column is full, throw InvalidMoveException with an appropriate message

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
        /// Draw the board using the board renderer
        /// </summary>
        public void Draw()
        {
            renderer.Render(this);
        }
    }
}
