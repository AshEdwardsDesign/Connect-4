using System;

namespace Connect_4
{
    public static class GameController
    {
        public static Player player1;
        public static Player player2;

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
        // Pieces above
        static GamePiece oneAbove;
        static GamePiece twoAbove;
        static GamePiece threeAbove;
        // Pieces below
        static GamePiece oneBelow;
        static GamePiece twoBelow;
        static GamePiece threeBelow;

        // TO DO: Horizontal slots

        public static bool isWinningMove(Player player, GamePiece[,] board, int col, int row)
        {
            GetNearbyPieces(board, col, row);
            // If pieces to left are valid...
            if (oneToLeft != null && twoToLeft != null && threeToLeft != null)
            {
                if ()
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
            // Pieces above
            try
            {
                oneAbove = board[row - 1, col].GetBoardGamePiece();
            }
            catch
            {
                oneAbove = null;
            }
            try
            {
                twoAbove = board[row - 2, col].GetBoardGamePiece();
            }
            catch
            {
                twoAbove = null;
            }
            try
            {
                threeAbove = board[row - 3, col].GetBoardGamePiece();
            }
            catch
            {
                threeAbove = null;
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
        }
    }
}
