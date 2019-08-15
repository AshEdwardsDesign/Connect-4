using System;

namespace Connect_4
{
    public static class GameController
    {
        public static Player player1;
        public static Player player2;

        public static bool isWinningMove(Player player, GamePiece[,] board, int col, int row)
        {

            // 
            // Nearby board slots
            //

            // Pieces to the left
            GamePiece oneToLeft = board[row, col - 1].GetBoardGamePiece();
            GamePiece twoToLeft = board[row, col - 2].GetBoardGamePiece();
            GamePiece threeToLeft = board[row, col - 3].GetBoardGamePiece();
            // Pieces to the right
            GamePiece oneToRight = board[row, col + 1].GetBoardGamePiece();
            GamePiece twoToRight = board[row, col + 2].GetBoardGamePiece();
            GamePiece threeToRight = board[row, col + 3].GetBoardGamePiece();
            // Pieces above
            GamePiece oneAbove = board[row - 1, col].GetBoardGamePiece();
            GamePiece twoAbove = board[row - 2, col].GetBoardGamePiece();
            GamePiece threeAbove = board[row - 3, col].GetBoardGamePiece();
            // Pieces below
            GamePiece oneBelow = board[row + 1, col].GetBoardGamePiece();
            GamePiece twoBelow = board[row + 2, col].GetBoardGamePiece();
            GamePiece threeBelow = board[row + 3, col].GetBoardGamePiece();

            //
            // HORIZONTAL MOVE CHECKING
            //

            try
            {
                // Check the 3 pieces to the left
                if (board[row, col - 1] == player.GetGamePiece()
                    && board[row, col -2] == player.GetGamePiece()
                    && board[row, col - 3] == player.GetGamePiece())
                {
                    return true;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error checking nearby pieces");
            }

            try
            {
                // Check 2 to the left and 1 to the right
                if (board[row, col - 2] == player.GetGamePiece()
                    && board[row, col - 1] == player.GetGamePiece()
                    && board[row, col + 1] == player.GetGamePiece())
                {
                    return true;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error checking nearby pieces");
            }

            try
            {
                // Check 1 to the left and 2 to the right
                if (board[row, col - 1] == player.GetGamePiece()
                    && board[row, col + 1] == player.GetGamePiece()
                    && board[row, col + 2] == player.GetGamePiece())
                {
                    return true;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error checking nearby pieces");
            }

            try
            {
                // Check 3 to the right
                if (board[row, col + 1] == player.GetGamePiece()
                    && board[row, col + 2] == player.GetGamePiece()
                    && board[row, col + 3] == player.GetGamePiece())
                {
                    return true;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error checking nearby pieces");
            }

            //
            // VERTICAL MOVE CHECKING
            //

            try
            {
                // Check 3 below
                if (board[row - 1, col] == player.GetGamePiece()
                    && board[row - 2, col] == player.GetGamePiece()
                    && board[row - 3, col] == player.GetGamePiece())
                {
                    return true;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error checking nearby pieces");
            }

            return false;
        }
    }
}
