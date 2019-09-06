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

            Console.ReadLine();
        }

        /// <summary>
        /// Shows the main menu. Returns bool to indicate if menu should be shown again.
        /// </summary>
        /// <param name="gb"></param>

        private static bool MainMenu()
        {
            UI.DisplayTitle("Welcome to Connect 4!");

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
                    GameController.StartSinglePlayer();
                    break;
                case 2:
                    GameController.StartMultiplayer();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    UI.DisplayWarning($"ERROR: Your input doesnt match a menu option! For reference, you entered {menuChoice}. Press enter to try again...");
                    break;
            };

            return true;
        }

    }
}
