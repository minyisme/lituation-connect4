using Connect4.Interfaces;
using System;
using System.Collections.Generic;

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
        /// The board renderer
        /// </summary>
        private IBoardRenderer renderer;

        /// <summary>
        /// The win checker
        /// </summary>
        private IWinChecker winChecker;

        /// <summary>
        /// The input provider
        /// </summary>
        private IInputProvider inputProvider;

        /// <summary>
        /// The output provider
        /// </summary>
        private IOutputProvider outputProvider;

        /// <summary>
        /// The players. This is a list so we can support any number of players in the future.
        /// This uses IPlayer so we can support any type of player in the future (human player, computer player, etc...)
        /// </summary>
        private List<IPlayer> players;

        /// <summary>
        /// The current player
        /// </summary>
        private IPlayer currentPlayer;

        /// <summary>
        /// The game state
        /// </summary>
        public GameState GameState { get; private set; }

        /// <summary>
        /// Default constructor, uses a new Board and ConsoleOutputProvider
        /// </summary>
        public GameManager() : this(
            new Board(), 
            new ConsoleBoardRenderer(),
            new Connect4WinChecker(),
            new ConsoleInputProvider(),
            new ConsoleOutputProvider())
        {

        }

        /// <summary>
        /// Constructor used for unit testing
        /// </summary>
        /// <param name="board">The board</param>
        /// <param name="renderer">The board renderer</param>
        /// <param name="winChecker">The win checker</param>
        /// <param name="inputprovider">The input provider</param>
        /// <param name="outputProvider">The output provider</param>
        public GameManager(IBoard board, IBoardRenderer renderer, IWinChecker winChecker, IInputProvider inputProvider, IOutputProvider outputProvider)
        {
            // validate the inputs

            this.board = board;
            this.renderer = renderer;
            this.winChecker = winChecker;
            this.inputProvider = inputProvider;
            this.outputProvider = outputProvider;

            // initialize the players list

            // set the game state to waiting to start
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
            if (player == null)
            {
                throw new ArgumentNullException();
            }
            // tell the player it's their turn using their name, and ask them for their move 
            // using the output provider to print

            // TODO: CHANGE WHEN UI IS IMPLEMENTED
            Console.WriteLine($"{player.Name}, it's your turn. Where would you like to move?");
            // set game state to WaitingForUserInput
            GameState = GameState.WaitingForUserInput;
            // get the move from the player
            var column = Convert.ToInt32(Console.ReadLine());
            var move = GetMove(column);
            // set game state to PerformingMove
            GameState = GameState.PerformingMove;
            // create a piece with the player as the owner
            // TO DO BY VILDE
            // make a move using the board, passing in that piece
            board.AddPiece(piece, move);

            // set game state to CheckingForGameOver
            GameState = GameState.CheckingForGameOver;
            // Did the current player win? (ask the win checker)
            
            // If yes, change the game state to GameState.Winner and return
            if (winChecker.IsWin(board, move))
            {
                GameState = GameState.Winner;
            }
            // Is the board full? (ask the board)
            // If yes, change the game state to GameState.Draw
            if (board.IsFull())
            {
                GameState = GameState.Draw;
            }
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
