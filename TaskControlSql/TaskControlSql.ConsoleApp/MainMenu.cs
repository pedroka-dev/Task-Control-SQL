using System;
using TaskControlSql.ConsoleApp.Control;

namespace TaskControlSql.ConsoleApp.View
{
    public class MainMenu : Menu
    {
        TodoTaskController taskController;
        ContactController contactController;

        public MainMenu(ConsoleColor fontColor)
        {
            this.fontColor = fontColor;
            taskController = new TodoTaskController();
            contactController = new ContactController();
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
                    case "2":
                        menu = new ContactMenu(contactController, fontColor);
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
            Console.WriteLine(" - Enter 2 to manage Contacts.");
            Console.WriteLine(" - Enter Q to quit.");

            string option = Console.ReadLine();

            return option;
        }
    }
}
