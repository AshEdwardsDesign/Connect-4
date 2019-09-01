using System;

namespace Connect_4
{
    public class GameBoard
    {
        private int w;
        private int h;
        private GamePiece[,] board;
        private bool moveMade;
        private bool gameWon = false;

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
                    // Display the row number
                    if (j == 0)
                    {
                        Console.Write(i + " ");
                    }

                    board[i, j].DisplayPiece();
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }

            Console.Write("  ");

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
            gameWon = false;

            while (!moveMade && !gameWon)
            {
                if (!player.isComputerPlayer())
                {
                    int col = 0;
                    bool invalidCol = true;

                    while (invalidCol)
                    {
                        try
                        {
                            UI.RequestInput("Choose a column:\t");
                            col = Convert.ToInt32(Console.ReadLine());
                            invalidCol = false;
                        }
                        catch
                        {
                            UI.DisplayWarning("ERROR: Could not convert your input into an integer (whole number)");
                        }
                    }
                    gameWon = makeMove(col, player);
                }
                else
                {
                    gameWon = makeMove(player.ChooseMove(this), player);
                }
            }

            if (gameWon)
            {
                UI.DisplaySuccess($"{player.GetName()} won!!!");
                Console.ReadLine();
            }
        }

        private bool makeMove(int col, Player player)
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
                    UI.DisplayNotice($"Piece placed in column {col} at position {i}");
                    if (GameController.isWinningMove(player, board, col, i))
                    {
                        UI.DisplaySuccess("It's a winning move! :)");
                        Console.ReadLine();
                        return true;
                    }
                    else
                    {
                        UI.DisplayNotice("Not a winning move... :(");
                        Console.ReadLine();
                        return false;
                    }
                }
            }
            UI.DisplayWarning($"ERROR: Column {col} is full. Please choose again");
            return false;
        }
    }
}
