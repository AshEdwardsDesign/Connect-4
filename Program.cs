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
                Console.Write("Choose a column:\t");
                int col = Convert.ToInt32(Console.ReadLine());

                gb.TakeTurn(col);

                Console.ReadLine();
            }
        }
    }
}
