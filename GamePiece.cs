﻿using System;

namespace Connect_4
{
    public class GamePiece
    {
        private ConsoleColor pieceColor = ConsoleColor.Gray;
        private char icon = '*';

        public GamePiece(ConsoleColor col)
        {
            pieceColor = col;
        }

        public void DisplayPiece()
        {
            Console.ForegroundColor = pieceColor;
            Console.Write(icon);
            Console.ResetColor();
        }
    }
}
