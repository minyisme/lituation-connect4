using Connect4.Interfaces;
using System;

namespace Connect4
{
    /// <summary>
    /// The HumanPlayer class, represents a human player
    /// </summary>
    public class HumanPlayer : IPlayer
    {
        /// <summary>
        /// The player's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The player's label, shown when drawing the player's pieces on the board
        /// </summary>
        public char Label { get; set; }

        /// <summary>
        /// The move provider, used for getting moves
        /// </summary>
        private IMoveProvider mp;

        /// <summary>
        /// Constructor that uses the default move provider which reads from the console.
        /// If label is not specified, the first letter of the player's name is used.
        /// </summary>
        /// <param name="name">The player's name</param>
        public HumanPlayer(string name) : this(name, name[0], new MoveProvider())
        {

        }

        /// <summary>
        /// Constructor that uses the default move provider which reads from the console
        /// </summary>
        /// <param name="name">The player's name</param>
        /// <param name="label">The player's label</param>
        public HumanPlayer(string name, char label) : this(name, label, new MoveProvider())
        {

        }

        /// <summary>
        /// Constructor that uses a specific IMoveProvider, used for unit testing
        /// </summary>
        /// <param name="name">The player's name</param>
        /// <param name="label">The player's label</param>
        /// <param name="mp">The move provider</param>
        public HumanPlayer(string name, char label, IMoveProvider mp)
        {
            // validate the inputs
            // If name is null or empty, throw an ArgumentNullException
            // If mp is null, throw an ArgumentNullException

            Name = name;
            Label = label;
            this.mp = mp;
        }

        /// <summary>
        /// Get a move
        /// </summary>
        /// <returns>The move</returns>
        public IMove GetMove()
        {
            // get the move from the move provider
            throw new NotImplementedException();
        }
    }
}
