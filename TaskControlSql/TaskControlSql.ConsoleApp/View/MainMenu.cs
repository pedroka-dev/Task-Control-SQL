using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskControlSql.ConsoleApp.Control;

namespace TaskControlSql.ConsoleApp.View
{
    class MainMenu : Menu
    {
        TodoTaskController taskController;

        public MainMenu(ConsoleColor fontColor)
        {
            this.fontColor = fontColor;
            taskController = new TodoTaskController();
        }

        public override void ShowMenu()
        {
            while (true)
            {
                Console.Clear();
                DisplayerHeader("TASK CONTROL");

                Menu menu;

                string option = SelectOption();

                switch (option.ToLowerInvariant())
                {
                    case "q":
                        return;

                    case "1":
                        menu = new TodoTaskMenu(taskController, fontColor);
                        break;

                    default:
                        DisplayErrorText("Invalid option. Use only the available options from above.");
                        Console.ReadLine();
                        continue;
                }

                menu.ShowMenu();
            }
        }

        protected override string SelectOption()
        {
            Console.WriteLine(" - Enter 1 to manage Tasks.");
            Console.WriteLine(" - Enter Q to quit.");

            string option = Console.ReadLine();

            return option;
        }
    }
}
