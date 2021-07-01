using System;

namespace TaskControlSql.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu(ConsoleColor.Green);
            menu.ShowMenu();
        }
    }
}
