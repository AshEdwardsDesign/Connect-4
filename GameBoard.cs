using System;

namespace Connect_4
{
    public class GameBoard
    {
        private int w;
        private int h;
        private GamePiece[,] board;

        public GameBoard(int height, int width)
        {
            w = width;
            h = height;
            board = new GamePiece[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    board[i, j] = new GamePiece(ConsoleColor.Gray, '*');
                }
            }
        }

        public void DisplayGameBoard()
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    board[j, i].DisplayPiece();
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }

            for (int x = 0; x < w; x++)
            {
                Console.Write(x + " ");
            }
        }

        public void TakeTurn(int col, Player player)
        {
            for (int i = 0; i < h; i++)
            {
                if (board[i,col] == GameController.player1.GetGamePiece() || board [i,col] == GameController.player2.GetGamePiece())
                {
                    continue;
                } else
                {
                    board[i, col] = player.GetGamePiece();
                }
            }
        }

        private void PlacePiece(int col, int row, GamePiece pc)
        {
            board[row, col] = pc;
        }
    }
}
