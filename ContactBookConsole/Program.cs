using ContactBookConsole.User_Interface;

namespace ContactBookConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose boot type: 1. Console 2. Test");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    MainWindow.MainMethod();
                }
                else if (key.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    MainWindow.MainMethodTest();
                }
            }
        }
    }
}
