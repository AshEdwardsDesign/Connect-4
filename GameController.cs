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
                oneTopLeft = board[row - 1, col -1].GetBoardGamePiece();
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
