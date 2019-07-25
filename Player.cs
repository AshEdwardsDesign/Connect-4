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

        public Player(string n, char ch, ConsoleColor color)
        {
            name = n;
            gamePiece = new GamePiece(color, ch);
        }

        public GamePiece GetGamePiece()
        {
            return gamePiece;
        }
    }
}
