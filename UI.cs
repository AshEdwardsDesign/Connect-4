using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_4
{
    public static class UI
    {
        private static ConsoleColor warningColor = ConsoleColor.Red;
        private static ConsoleColor noticeColor = ConsoleColor.Yellow;
        private static ConsoleColor inputColor = ConsoleColor.Cyan;
        private static ConsoleColor successColor = ConsoleColor.Green;

        public static void DisplayWarning(string text)
        {
            Console.ForegroundColor = warningColor;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void DisplayNotice(string text)
        {
            Console.ForegroundColor = noticeColor;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void RequestInput(string text)
        {
            Console.ForegroundColor = inputColor;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void DisplaySuccess(string text)
        {
            Console.ForegroundColor = successColor;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
