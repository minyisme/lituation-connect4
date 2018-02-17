using Connect4.Interfaces;
using System;

namespace Connect4
{
    /// <summary>
    /// The GameManager class, handles all game logic
    /// </summary>
    public class GameManager
    {
        /// <summary>
        /// The game board
        /// </summary>
        private IBoard board;

        /// <summary>
        /// The win checker
        /// </summary>
        private IWinChecker winChecker;

        /// <summary>
        /// The output provider
        /// </summary>
        private IOutputProvider outputProvider;

        // create something to keep track of the current player
        // remember to use interfaces whenever possible

        /// <summary>
        /// The game state
        /// </summary>
        public GameState GameState { get; private set; }

        /// <summary>
        /// Default constructor, uses a new Board and ConsoleOutputProvider
        /// </summary>
        public GameManager() : this(new Board(), new Connect4WinChecker(), new ConsoleOutputProvider())
        {

        }

        /// <summary>
        /// Constructor used for unit testing
        /// </summary>
        /// <param name="board">The board</param>
        public GameManager(IBoard board) : this(board, new Connect4WinChecker(), new ConsoleOutputProvider())
        {

        }

        /// <summary>
        /// Constructor used for unit testing
        /// </summary>
        /// <param name="board">The board</param>
        /// <param name="winChecker">The win checker</param>
        public GameManager(IBoard board, IWinChecker winchecker) : this(board, winchecker, new ConsoleOutputProvider())
        {

        }

        /// <summary>
        /// Constructor used for unit testing
        /// </summary>
        /// <param name="board">The board</param>
        /// <param name="winChecker">The win checker</param>
        /// <param name="outputProvider">The output provider</param>
        public GameManager(IBoard board, IWinChecker winChecker, IOutputProvider outputProvider)
        {
            // validate the inputs
            // if board is null, throw an ArgumentNullException
            // if winChecker is null, throw an ArgumentNullException
            // if outputProvider is null, throw an ArgumentNullException

            this.board = board;
            this.winChecker = winChecker;
            this.outputProvider = outputProvider;
            GameState = GameState.WaitingToStart;
        }

        /// <summary>
        /// Start the game
        /// </summary>
        public void StartGame()
        {
            // create the players

            // If currentPlayer is null, pick the first player and assign it to the current player

            // draw the board

            // create the game loop
            // set game state to Started
            // try to call PerformSingleTurn(currentPlayer)
            // if an InvalidInputException is thrown, catch it, print an error, and keep looping
            // if an InvalidMoveException is thrown, catch it, print an error, and keep looping

            // if the game state is GameState.Winner, the game is over and the current player won
            // print a win message and exit the loop

            // if the game state is GameState.Draw, the game is over and nobody won
            // print a draw message and exit the loop

            // otherwise, swap the current player and continue looping
        }

        /// <summary>
        /// Helper function to perform a single turn
        /// Very useful for unit testing
        /// </summary>
        public void PerformSingleTurn(IPlayer player)
        {
            // validate the arguments
            // if player is null, throw an ArgumentNullException

            // tell the player it's their turn using their name, and ask them for their move 
            // using the output provider to print

            // set game state to WaitingForUserInput
            // get the move from the player

            // set game state to PerformingMove
            // create a piece with the player as the owner
            // make a move using the board, passing in that piece

            // set game state to CheckingForGameOver
            // Did the current player win? (ask the win checker)
            // If yes, change the game state to GameState.Winner and return

            // Is the board full? (ask the board)
            // If yes, change the game state to GameState.Draw
        }

        /// <summary>
        /// Helper function to switch players
        /// </summary>
        private void SwitchPlayer()
        {

        }

        /// <summary>
        /// Helper function to pick the player that goes first
        /// </summary>
        /// <returns></returns>
        private IPlayer PickFirstPlayer()
        {
            throw new NotImplementedException();
        }
    }
}
