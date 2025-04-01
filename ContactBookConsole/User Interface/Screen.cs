using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookConsole.User_Interface
{
    public static class Screen
    {
        public static void Display (this string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(1);
            }
        }
        public static void DisplayLine(this string message)
        {
            Display(message);
            Console.WriteLine();
        }
        public static void DisplayMainMessage(this string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Display("=== ");
            Display(message);
            Display(" ===");
            Console.ResetColor();
        }
        public static void DisplayMainMessageLine(this string message)
        {
            DisplayMainMessage(message);
            Console.WriteLine();
        }
        public static void DisplayByLine(this string message)
        {
            string[] lines = message.Split('\n');
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                Thread.Sleep(5);
            }
        }
    }
}
