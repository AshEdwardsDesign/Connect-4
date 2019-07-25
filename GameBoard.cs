﻿using System;

namespace Connect_4
{
    public class GameBoard
    {
        private int w;
        private int h;
        private GamePiece[,] board;
        private bool moveMade;

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
                    board[i, j].DisplayPiece();
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }

            for (int x = 0; x < w; x++)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }

        public int GetNumberOfColumns()
        {
            return w;
        }

        public void TakeTurn(Player player)
        {
            moveMade = false;

            while (!moveMade)
            {
                if (!player.isComputerPlayer())
                {
                    Console.WriteLine("Choose a column:\t");
                    int col = Convert.ToInt32(Console.ReadLine());
                    makeMove(col, player);
                } else
                {
                    makeMove(player.ChooseMove(this), player);
                }
            }
        }

        private void makeMove(int col, Player player)
        {
            for (int i = h - 1; i >= 0; i--)
            {
                if (board[i, col] == GameController.player1.GetGamePiece() || board[i, col] == GameController.player2.GetGamePiece())
                {
                    continue;
                }
                else
                {
                    board[i, col] = player.GetGamePiece();
                    moveMade = true;
                    break;
                }
            }
        }
    }
}
