using System;

namespace Connect_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Connect 4!");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("Board width:\t");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Board height:\t");
            int height = Convert.ToInt32(Console.ReadLine());

            GameBoard gb = new GameBoard(height, width);

            GameController.player1 = new Player("Ash", '*', ConsoleColor.Yellow, false);
            GameController.player2 = new Player("Jenny", '*', ConsoleColor.Red, true);

            StartGame(gb);

            Console.ReadLine();
        }

        static void StartGame(GameBoard gb)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Here is your gameboard:\n");
                gb.DisplayGameBoard();

                Console.WriteLine();

                gb.TakeTurn(GameController.player1);

                Console.Clear();
                Console.WriteLine("Here is your gameboard:\n");
                gb.DisplayGameBoard();

                Console.WriteLine();

                gb.TakeTurn(GameController.player2);
            }
        }
    }
}
