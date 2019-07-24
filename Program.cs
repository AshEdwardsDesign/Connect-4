using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Connect 4!");
            Console.WriteLine();

            Console.WriteLine("Board width:\t");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Board height:\t");
            int height = Convert.ToInt32(Console.ReadLine());

            GameBoard gb = new GameBoard(height, width);

            Console.WriteLine("Here is your gameboard:\n");

            gb.DisplayGameBoard();

            Console.ReadLine();
        }
    }
}
