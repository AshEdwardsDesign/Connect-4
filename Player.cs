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
        private ConsoleColor playerColor;
        private int wins;

        public Player()
        {
            Console.Write("Player 1 Name:\t");
            name = Console.ReadLine();
            playerColor = ConsoleColor.Red;
        }
    }
}
