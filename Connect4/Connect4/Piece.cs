using Connect4.Interfaces;
using System;

namespace Connect4
{
    /// <summary>
    /// The Piece class, represents a piece on the board
    /// </summary>
    public class Piece : IPiece
    {
        /// <summary>
        /// The owner of the piece
        /// </summary>
        public IPlayer Owner { get; private set; }

        /// <summary>
        /// Constructor that expects an owner, since all pieces must have an owner
        /// </summary>
        /// <param name="owner">The player that owns the piece</param>
        public Piece(IPlayer owner)
        {
            // validate the inputs
            // If owner is null, throw an ArgumentNullException

            Owner = owner;
        }

        /// <summary>
        /// Override of ToString, used to draw the piece when drawing the board
        /// Use the label of the owning player
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
