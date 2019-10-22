using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_4
{
    public class Player
    {
        private string name;            // The players name
        private GamePiece gamePiece;    // A GamePiece object representing the players piece on the board
        private bool isAI = false;      // Is this "player" an AI?
        private int wins = 0;           // The number of wins this player has in the current session
        Random rand = new Random();     // Random num generator

        public Player(string n, char ch, ConsoleColor color, bool ai)
        {
            name = n;
            gamePiece = new GamePiece(color, ch);
            isAI = ai;
        }

        /// <summary>
        /// Get the players GamePiece object
        /// </summary>
        /// <returns></returns>
        public GamePiece GetGamePiece()
        {
            return gamePiece;
        }

        /// <summary>
        /// Get the players name
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Is this player an AI?
        /// </summary>
        /// <returns></returns>
        public bool isComputerPlayer()
        {
            return isAI;
        }

        /// <summary>
        /// Random move picker for the AI.
        /// </summary>
        /// <param name="gb"></param>
        /// <returns></returns>
        public int ChooseAIMove(GameBoard gb)
        {
            //Loop over each column and determine if it's a winning move, if so, take it... 
            for (int x = 0; x < gb.GetNumberOfColumns(); x++)
            {
                for (int y = 0; y < gb.GetNumberOfRows(); y++)
                GameController.isWinningMove(this, gb.getGameBoard(), x, y);
                    }

            // If no winning move exists, check to see if the opponent has any winning moves available and take it if so (to prevent victory)...

            // Pick a random column if no better moves exist...
            return rand.Next(gb.GetNumberOfColumns());
        }

    }
}
