using System;

namespace Connect_4
{
    public static class GameController
    {
        private static GameBoard gameBoard;
        public static Player player1;
        public static Player player2;
        private static bool gameWon = false;

        // 
        // Nearby board slots
        //

        // Pieces to the left
        static GamePiece oneToLeft;
        static GamePiece twoToLeft;
        static GamePiece threeToLeft;
        // Pieces to the right
        static GamePiece oneToRight;
        static GamePiece twoToRight;
        static GamePiece threeToRight;
        // Pieces below
        static GamePiece oneBelow;
        static GamePiece twoBelow;
        static GamePiece threeBelow;
        // Top-left diagonal
        static GamePiece oneTopLeft;
        static GamePiece twoTopLeft;
        static GamePiece threeTopLeft;
        // Top-right diagonal
        static GamePiece oneTopRight;
        static GamePiece twoTopRight;
        static GamePiece threeTopRight;
        // Bottom-left diagonal
        static GamePiece oneBottomLeft;
        static GamePiece twoBottomLeft;
        static GamePiece threeBottomLeft;
        // Bottom-right diagonal
        static GamePiece oneBottomRight;
        static GamePiece twoBottomRight;
        static GamePiece threeBottomRight;

        /// <summary>
        /// Requests game board width and height from the player and then generates the gameboard.
        /// </summary>
        public static void GenerateGameBoard()
        {
            UI.RequestInput("Board width:");
            int width = Convert.ToInt32(Console.ReadLine());

            UI.RequestInput("Board height:");
            int height = Convert.ToInt32(Console.ReadLine());

            gameBoard = new GameBoard(height, width);
        }

        /// <summary>
        /// Starts a singleplayer game
        /// </summary>
        public static void StartSinglePlayer()
        {
            UI.DisplayTitle("Starting a single player game VS the AI...");
            GenerateGameBoard();
            CreatePlayer1(false);
            CreatePlayer2(true);
            StartGame();
        }

        /// <summary>
        /// Starts a multiplayer game.
        /// </summary>
        public static void StartMultiplayer()
        {
            UI.DisplayTitle("Starting a multiplayer game between 2 local human players...");
            GenerateGameBoard();
            CreatePlayer1(false);
            CreatePlayer2(false);
            StartGame();
        }

        /// <summary>
        /// Create the first player (always a human)
        /// </summary>
        private static void CreatePlayer1(bool isAI)
        {
            UI.RequestInput("Player 1 name:");
            string name = Console.ReadLine();
            UI.RequestInput("Player 1 piece (choose a single character):");
            string chr = Console.ReadLine();
            player1 = new Player(name, chr[0], ConsoleColor.Yellow, false);
        }

        /// <summary>
        /// Create the second player (can be human or AI)
        /// </summary>
        /// <param name="isAI"></param>
        private static void CreatePlayer2(bool isAI)
        {
            if (isAI)
            {
                player2 = new Player("AI", '*', ConsoleColor.Red, true);
            }
            else
            {
                UI.RequestInput("Player 2 name:");
                string name = Console.ReadLine();
                UI.RequestInput("Player 2 piece (choose a single character):");
                string chr = Console.ReadLine();
                player2 = new Player(name, chr[0], ConsoleColor.Red, false);
            }
        }

        /// <summary>
        /// Starts the main gameplay loop
        /// </summary>
        public static void StartGame()
        {
            gameWon = false;

            while (!gameWon)
            {
                // Player 1's turn
                UI.DisplayTitle("Here is your gameboard:");

                gameBoard.DisplayGameBoard();

                Console.WriteLine();

                UI.DisplayNotice($"{player1.GetName()}'s turn!");
                gameBoard.TakeTurn(player1, ref gameWon);

                // Player 2's turn
                if (!gameWon)
                {
                    UI.DisplayTitle("Here is your gameboard:");

                    gameBoard.DisplayGameBoard();

                    Console.WriteLine();

                    UI.DisplayNotice($"{player2.GetName()}'s turn!");
                    gameBoard.TakeTurn(player2, ref gameWon);
                }
            }
        }

        public static bool isWinningMove(Player player, GamePiece[,] board, int col, int row)
        {
            GetNearbyPieces(board, col, row);
            // 3 pieces to the left...
            if (oneToLeft != null && twoToLeft != null && threeToLeft != null)
            {
                if (oneToLeft == player.GetGamePiece() && twoToLeft == player.GetGamePiece() && threeToLeft == player.GetGamePiece())
                {
                    return true;
                }
            }
            // 2 pieces to the left and 1 to the right...
            if (oneToLeft != null && twoToLeft != null && oneToRight != null)
            {
                if (oneToLeft == player.GetGamePiece() && twoToLeft == player.GetGamePiece() && oneToRight == player.GetGamePiece())
                {
                    return true;
                }
            }
            // 1 piece to the left and 2 to the right...
            if (oneToLeft != null && oneToRight != null && twoToRight != null)
            {
                if (oneToLeft == player.GetGamePiece() && oneToRight == player.GetGamePiece() && twoToRight == player.GetGamePiece())
                {
                    return true;
                }
            }
            // 3 pieces to the right...
            if (oneToRight != null && twoToRight != null && threeToRight != null)
            {
                if (oneToRight == player.GetGamePiece() && twoToRight == player.GetGamePiece() && threeToRight == player.GetGamePiece())
                {
                    return true;
                }
            }
            // 3 pieces below...
            if (oneBelow != null && twoBelow != null && threeBelow != null)
            {
                if (oneBelow == player.GetGamePiece() && twoBelow == player.GetGamePiece() && threeBelow == player.GetGamePiece())
                {
                    return true;
                }
            }
            // 3 pieces to the top left...
            if (oneTopLeft != null && twoTopLeft != null && threeTopLeft != null)
            {
                if (oneTopLeft == player.GetGamePiece() && twoTopLeft == player.GetGamePiece() && threeTopLeft == player.GetGamePiece())
                {
                    return true;
                }
            }
            // 2 pieces to the top left and 1 to the bottom right...
            if (oneTopLeft != null && twoTopLeft != null && oneBottomRight != null)
            {
                if (oneTopLeft == player.GetGamePiece() && twoTopLeft == player.GetGamePiece() && oneBottomRight == player.GetGamePiece())
                {
                    return true;
                }
            }
            // 1 piece to the top left and 2 to the bottom right...
            if (oneTopLeft != null && oneBottomRight != null && twoBottomRight != null)
            {
                if (oneTopLeft == player.GetGamePiece() && oneBottomRight == player.GetGamePiece() && twoBottomRight == player.GetGamePiece())
                {
                    return true;
                }
            }
            // 3 pieces to the bottom right...
            if (oneBottomRight != null && twoBottomRight != null && threeBottomRight != null)
            {
                if (oneBottomRight == player.GetGamePiece() && twoBottomRight == player.GetGamePiece() && threeBottomRight == player.GetGamePiece())
                {
                    return true;
                }
            }
            // 3 pieces to the top right...
            if (oneTopRight != null && twoTopRight != null && threeTopRight != null)
            {
                if (oneTopRight == player.GetGamePiece() && twoTopRight == player.GetGamePiece() && threeTopRight == player.GetGamePiece())
                {
                    return true;
                }
            }
            // 2 pieces to the top right and 1 to the bottom left...
            if (oneTopRight != null && twoTopRight != null && oneBottomLeft != null)
            {
                if (oneTopRight == player.GetGamePiece() && twoTopRight == player.GetGamePiece() && oneBottomLeft == player.GetGamePiece())
                {
                    return true;
                }
            }
            // 1 pieces to the top right and 2 to the bottom left...
            if (oneTopRight != null && oneBottomLeft != null && twoBottomLeft != null)
            {
                if (oneTopRight == player.GetGamePiece() && oneBottomLeft == player.GetGamePiece() && twoBottomLeft == player.GetGamePiece())
                {
                    return true;
                }
            }
            // 3 pieces to the bottom left...
            if (oneBottomLeft != null && twoBottomLeft != null && threeBottomLeft != null)
            {
                if (oneBottomLeft == player.GetGamePiece() && twoBottomLeft == player.GetGamePiece() && threeBottomLeft == player.GetGamePiece())
                {
                    return true;
                }
            }
            return false;
        }

        public static void GetNearbyPieces(GamePiece[,] board, int col, int row)
        {
            // Pieces to the left
            try
            {
                oneToLeft = board[row, col - 1].GetBoardGamePiece();
            }
            catch
            {
                oneToLeft = null;
            }
            try
            {
                twoToLeft = board[row, col - 2].GetBoardGamePiece();
            }
            catch
            {
                twoToLeft = null;
            }
            try
            {
                threeToLeft = board[row, col - 3].GetBoardGamePiece();
            }
            catch
            {
                threeToLeft = null;
            }
            // Pieces to the right
            try
            {
                oneToRight = board[row, col + 1].GetBoardGamePiece();
            }
            catch
            {
                oneToRight = null;
            }
            try
            {
                twoToRight = board[row, col + 2].GetBoardGamePiece();
            }
            catch
            {
                twoToRight = null;
            }
            try
            {
                threeToRight = board[row, col + 3].GetBoardGamePiece();
            }
            catch
            {
                threeToRight = null;
            }
            // Pieces below
            try
            {
                oneBelow = board[row + 1, col].GetBoardGamePiece();
            }
            catch
            {
                oneBelow = null;
            }
            try
            {
                twoBelow = board[row + 2, col].GetBoardGamePiece();
            }
            catch
            {
                twoBelow = null;
            }
            try
            {
                threeBelow = board[row + 3, col].GetBoardGamePiece();
            }
            catch
            {
                threeBelow = null;
            }
            // Pieces to the top left
            try
            {
                oneTopLeft = board[row - 1, col - 1].GetBoardGamePiece();
            }
            catch
            {
                oneTopLeft = null;
            }
            try
            {
                twoTopLeft = board[row - 2, col - 2].GetBoardGamePiece();
            }
            catch
            {
                twoTopLeft = null;
            }
            try
            {
                threeTopLeft = board[row - 3, col - 3].GetBoardGamePiece();
            }
            catch
            {
                threeTopLeft = null;
            }
            // Pieces to the bottom right
            try
            {
                oneBottomRight = board[row + 1, col + 1].GetBoardGamePiece();
            }
            catch
            {
                oneBottomRight = null;
            }
            try
            {
                twoBottomRight = board[row + 2, col + 2].GetBoardGamePiece();
            }
            catch
            {
                twoBottomRight = null;
            }
            try
            {
                threeBottomRight = board[row + 3, col + 3].GetBoardGamePiece();
            }
            catch
            {
                threeBottomRight = null;
            }
            // Pieces to the top right
            try
            {
                oneTopRight = board[row - 1, col + 1].GetBoardGamePiece();
            }
            catch
            {
                oneTopRight = null;
            }
            try
            {
                twoTopRight = board[row - 2, col + 2].GetBoardGamePiece();
            }
            catch
            {
                twoTopRight = null;
            }
            try
            {
                threeTopRight = board[row - 3, col + 3].GetBoardGamePiece();
            }
            catch
            {
                threeTopRight = null;
            }
            // Pieces to the bottom left
            try
            {
                oneBottomLeft = board[row - 1, col + 1].GetBoardGamePiece();
            }
            catch
            {
                oneBottomLeft = null;
            }
            try
            {
                twoBottomLeft = board[row - 2, col + 2].GetBoardGamePiece();
            }
            catch
            {
                twoBottomLeft = null;
            }
            try
            {
                threeBottomLeft = board[row - 3, col + 3].GetBoardGamePiece();
            }
            catch
            {
                threeBottomLeft = null;
            }
        }
    }
}
