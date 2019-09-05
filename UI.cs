using System;

namespace Connect_4
{
    public static class UI
    {
        private static ConsoleColor warningColor = ConsoleColor.Red;
        private static ConsoleColor noticeColor = ConsoleColor.Yellow;
        private static ConsoleColor inputColor = ConsoleColor.Cyan;
        private static ConsoleColor successColor = ConsoleColor.Green;
        private static ConsoleColor titleColor = ConsoleColor.Magenta;

        public static void DisplayWarning(string text)
        {
            Console.ForegroundColor = warningColor;
            Console.WriteLine(text);
            Console.ResetColor();
            Console.ReadLine();
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
            Console.Write(text + "\t");
            Console.ResetColor();
        }

        public static void DisplaySuccess(string text)
        {
            Console.ForegroundColor = successColor;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void DisplayTitle(string text)
        {
            Console.Clear();
            Console.ForegroundColor = titleColor;
            Console.WriteLine(new String('/', text.Length));
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(new String('/', text.Length));
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
