using System;

namespace Connect_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMainMenu = true;

            while (displayMainMenu)
            {
                displayMainMenu = MainMenu();
            }

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

        /// <summary>
        /// Shows the main menu. Returns bool to indicate if menu should be shown again.
        /// </summary>
        /// <param name="gb"></param>

        private static bool MainMenu()
        {
            UI.DisplayTitle("Welcome to Connect 4!");
            Console.WriteLine();

            Console.WriteLine("1: One Player");
            Console.WriteLine("2: Two Player");
            Console.WriteLine("3: Quit");
            Console.WriteLine();

            UI.RequestInput("Menu choice:");

            int menuChoice = 0;

            try
            {
                menuChoice = int.Parse(Console.ReadLine());
            }
            catch
            {
                UI.DisplayWarning("ERROR: Could not convert your input to an integer (whole number). Press enter to try again...");
                return true;
            }

            switch (menuChoice)
            {
                case 1:
                    StartSinglePlayer();
                    break;
                case 2:
                    StartMultiplayer();
                    break;
                case 3:
                    return false;
                default:
                    UI.DisplayWarning($"ERROR: Your input doesnt match a menu option! For reference, you entered {menuChoice}. Press enter to try again...");
                    break;
            };

            return true;
        }


        private static void StartSinglePlayer()
        {
            UI.DisplayTitle("Start a single player game VS the AI");
            Console.ReadLine();
        }

        private static void StartMultiplayer()
        {
            UI.DisplayTitle("Start a multiplayer game between 2 local human players");
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

                Console.Write($"{GameController.player1.GetName()}'s turn! Press enter.");
                Console.ReadLine();
                gb.TakeTurn(GameController.player1);

                Console.Clear();
                Console.WriteLine("Here is your gameboard:\n");
                gb.DisplayGameBoard();

                Console.WriteLine();

                Console.Write($"{GameController.player2.GetName()}'s turn! Press enter.");
                Console.ReadLine();
                gb.TakeTurn(GameController.player2);
            }
        }
    }
}
