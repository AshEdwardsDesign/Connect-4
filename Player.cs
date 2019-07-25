using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_4
{
    public class Player
    {
        private string name;
        private GamePiece gamePiece;
        private bool isAI = false;
        Random rand = new Random();

        public Player(string n, char ch, ConsoleColor color, bool ai)
        {
            name = n;
            gamePiece = new GamePiece(color, ch);
            isAI = ai;
        }

        public GamePiece GetGamePiece()
        {
            return gamePiece;
        }

        public string GetName()
        {
            return name;
        }

        public bool isComputerPlayer()
        {
            return isAI;
        }

        public int ChooseMove(GameBoard gb)
        {
            return rand.Next(gb.GetNumberOfColumns());
        }
    }
}
