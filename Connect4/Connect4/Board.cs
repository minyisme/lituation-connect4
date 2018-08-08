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
        // the rows and columns, hardcoded for now
        private const int rows = 6;
        private const int columns = 7;

        // the board, represented by a 2d array of pieces
        private IPiece[,] pieces;

        // the number of pieces on the board
        private int numPieces;

        /// <summary>
        /// The number of rows on the board
        /// </summary>
        public int NumRows { get; protected set; }

        /// <summary>
        /// The number of columns on the board
        /// </summary>
        public int NumColumns { get; protected set; }

        /// <summary>
        /// Default constructor, uses hardcoded rows and columns
        /// </summary>
        public Board() : this(rows, columns)
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="numRows">The number of rows</param>
        /// <param name="numRows">The number columns</param>
        public Board(int numRows, int numColumns)
        {
            // validate the inputs

            NumRows = numRows;
            NumColumns = numColumns;
            pieces = new IPiece[NumRows, NumColumns];
        }

        /// <summary>
        /// Constuctor used for unit testing
        /// </summary>
        /// <param name="pieces">The pieces</param>
        public Board(IPiece[,] pieces)
        {
            // validate the inputs

            this.pieces = pieces;

            // calculate the number of rows and columns and update num rows and num columns

            // calculate the number of non-null pieces and update numpieces
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
            if (piece == null)
            {
                throw new ArgumentNullException();
            }
            if (move == null)
            {
                throw new ArgumentNullException();
            }
            // if the column is invalid, throw InvalidMoveException with an appropriate message
            // if the if the column is full, throw InvalidMoveException with an appropriate message
            // NOT NEEDED WHEN UI IS IMPLEMENTED
            //if (move.Column < 0 || move.Column > 6)
            //{
            //    throw new InvalidMoveException();
            //}

            // find out what row the piece would end up on by getting the "lowest" free space on the board for this column
            // add the piece to the board in the correct spot
            // finally, update the row in the move passed in so the caller will know where the piece ended up
            for (int i = 5; i >= -1; i--)
            {
                if (i == -1)
                {
                    throw new InvalidMoveException();
                }
                if (pieces[move.Column, i] == null)
                {
                    pieces[columns, i] = piece;
                    move.Row = i;
                    break;
                }
            }

            //throw new NotImplementedException();
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
            if (pieces[column, 0] != null)
            {
                return true;
            }
            return false;
            // throw ArgumentOutOfRange if IsColumnValid() is false
            throw new NotImplementedException();
        }

        /// <summary>
        /// Is the board full?
        /// </summary>
        /// <returns>True if yes, false otherwise</returns>
        public bool IsFull()
        {
            for (int i = 0; i < columns; i++)
            {
                if (!IsColumnFull(i))
                {
                    return false;
                }
            }
            return true;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draw the board using a specified renderer
        /// </summary>
        /// <param name="renderer">The board renderer</param>
        public void Draw(IBoardRenderer renderer)
        {
            renderer.Render(this);
        }
    }
}
