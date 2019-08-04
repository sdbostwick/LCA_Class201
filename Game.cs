using System;

namespace Checkers
{
    public class Game
    {
        // Private class variables are easily recognizable by the underscore and camelCase name.
        // Private variables within a code block are camelCase without an underscore, and go out of scope once the code block is exited.
        // Public variables are recognizable by their PascalCase naming and no underscore.
        private Board _board;
        private Color _playerColor = Color.Black;
        private bool _isPlaying = true;

        /// <summary>
        /// Constructor
        /// </summary>
        public Game()
        {
            _board = new Board();
        }

        public void Start()
        {
            while (_isPlaying)
            {
                // Setting up for next play
                Console.Clear();
                string position1 = string.Empty;
                string position2 = string.Empty;

                _board.Draw();
                Console.WriteLine($"\nPlayer {_playerColor} moves.");
                Console.WriteLine("Enter the row and column, separated by a space, of the checker to move.  Example, 0 0");
                position1 = Console.ReadLine();
                Console.WriteLine("\nEnter the row and column, separated by a space, of the checker destination.  Example, 1 1");
                position2 = Console.ReadLine();

                Position src = ProcessInput(position1);
                Position dest = ProcessInput(position2);
                Checker checker = _board.GetChecker(src);

                if (IsLegalMove(checker, src, dest))
                {
                    _board.MoveChecker(checker, dest);

                    // Use a ternary to determine next player
                    // If _player == Black, set _player to White, else set _player to Black
                }
                else
                {
                    Console.WriteLine("\nInvalid move.  Press any key to try again.");
                    Console.ReadKey();
                }

                if (CheckForWin())
                {
                    _isPlaying = false;
                    Console.WriteLine($"Player {_playerColor} wins!");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                }
            }
        }

        /// <summary>
        /// Checking that the move meets criteria.  Rules:  Players cannot move the other player's checker.
        /// Checkers can only move to an empty space.
        /// Checkers can only move one space unless capturing.
        /// </summary>
        /// <param name="checker"></param>
        /// <param name="src"></param>
        /// <param name="dest"></param>
        /// <returns></returns>
        private bool IsLegalMove(Checker checker, Position src, Position dest)
        {
            // Do not allow a player to choose an empty position
            if (checker == null)
            {
                return false;
            }

            // Player cannot move the other player's checker (pawn)
            if (checker.PlayerColor != _playerColor)
            {
                return false;
            }

            // Pawns can only move to an empty position
            Checker destination = _board.GetChecker(dest);
            if (destination != null)
            {
                return false;
            }

            // Checking for invalid row or column
            if (dest.Row <= -1 || dest.Row >= 8 || dest.Column <= -1 || dest.Column >= 8)
            {
                return false;
            }

            // Regular pawns can only move one space (forward, backward, diagonally) unless capturing another pawn
            // I have 4 different values to check separated by ||
            if (_____________)
            {
                // Do nothing.  Let execution fall through to the default return value true.
                // This is a valid move for single space moves.
            }
            else
            {
                var capture = GetCapturedChecker(src, dest);
                if (capture != null)
                {
                    _board.RemoveChecker(capture);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private Checker GetCapturedChecker(Position src, Position dest)
        {
            Checker capture = null;
            Position position = new Position();

            // Player moved diagonally right forward
            if (dest.Row < src.Row && dest.Column > src.Column)
            {
                position = new Position(dest.Row + 1, dest.Column - 1);
            }
            // Player moved diagonally left forward
            else if (dest.Row < src.Row && dest.Column < src.Column)
            {
                position = new Position(dest.Row + 1, dest.Column + 1);
            }
            // Player moved diagonally right backward
            else if (_________)
            {
                ...
            }
            // Player moved diagonally left backward
            else if (_________)
            {
                ...
            }
            // Player moved down
            else if (dest.Row > src.Row && dest.Column == src.Column)
            {
                position = new Position(dest.Row - 1, dest.Column);
            }
            // Player moved up
            else if (_________)
            {
                ...
            }
            // Player moved left
            else if (dest.Row == src.Row && dest.Column < src.Column)
            {
                position = new Position(dest.Row, src.Column - 1);
            }
            // Player moved right
            else
            {
                ...
            }

            capture = _board.GetChecker(position);

            if (capture == null)
            {
                return null;
            }

            // Pawns can only capture pawns of another color
            if (capture.PlayerColor == _playerColor)
            {
                return null;
            }

            return capture;
        }

        /// <summary>
        /// Converts user entry to a valid Position on the board
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        private Position ProcessInput(string position)
        {
            // setting initial values to an invalid position since row 0 and column 0 are valid inputs
            Position pos = new Position();
            bool success = false;
            try
            {
                var rowColumn = position.Split(' ');
                success = int.TryParse(rowColumn[0], out int row);
                // TODO parse out the column
                ...

                if (success)
                {
                    pos = new Position(row, column);
                }
            }
            catch (Exception)
            {
                return pos;
            }

            return pos;
        }

        private bool CheckForWin()
        {
            int white = _board.CountCheckers(Color.White);
            if (white == 0)
            {
                _playerColor = Color.Black;
                return true;
            }

            int black = _board.CountCheckers(Color.Black);
            if (black == 0)
            {
                _playerColor = Color.White;
                return true;
            }

            return false;
        }
    }
}
