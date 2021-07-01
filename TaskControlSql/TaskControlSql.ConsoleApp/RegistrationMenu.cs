using System;
using System.Collections.Generic;
using TaskControlSql.Control;
using TaskControlSql.Domain;

namespace TaskControlSql.ConsoleApp
{
    public abstract class RegistrationMenu<T> : Menu where T : Entity
    {
        protected string MenuTypeTitle;
        protected Controller<T> mainController;

        protected abstract List<T> OrderList(List<T> EntityList);

        public abstract void ModifyElement();

        public abstract void RegisterElement();

        public void RemoveElement()
        {
            VisualizeAllElements();

            DisplayerHeader("REMOVE " + MenuTypeTitle.ToUpper());

            Console.WriteLine($" - Enter id of the {MenuTypeTitle} to remove");
            string idTxt = Console.ReadLine();

            if (!int.TryParse(idTxt, out int id))
            {
                DisplayErrorText("Attribute id must a valid integer");
                return;
            }

            if (mainController.ExistEntity(id))
            {
                if (mainController.DeleteEntity(id))
                {
                    DisplaySuccessText("Delete Entity operation sucessful");
                    return;
                }
            }

            DisplayErrorText("Delete Entity operation failed. Element not found.");
            Console.ReadLine();
        }

        public override void ShowMenu()
        {
            while (true)
            {
                Console.Clear();
                DisplayerHeader("MANAGE " + MenuTypeTitle.ToUpper());

                string option = SelectOption();

                switch (option.ToLowerInvariant())
                {
                    case "q":
                        return;

                    case "1":
                        RegisterElement();
                        break;

                    case "2":
                        VisualizeAllElements();
                        break;

                    case "3":
                        ModifyElement();
                        break;

                    case "4":
                        RemoveElement();
                        break;

                    case "5":
                        RemoveAllElements();
                        break;

                    default:
                        DisplayErrorText("Invalid option. Use only the available options from above.");
                        break;
                }
                Console.ReadLine();
            }
        }

        private void RemoveAllElements()
        {
            VisualizeAllElements();
            DisplayerHeader("REMOVE ALL " + MenuTypeTitle.ToUpper());
            Console.WriteLine($" - Are you sure you want to delete all {MenuTypeTitle}? This cannot be undone. <Y = delete>");

            if (Console.ReadLine().ToUpper() == "Y")
            {
                string response = mainController.DeleteAllEntities();
                if (response != "OP_SUCCESS")
                    DisplayErrorText(response);
                else
                {
                    DisplaySuccessText("Delete All Operation Sucessful");
                    Console.ReadLine();
                    return;
                }
            }
        }

        public void VisualizeAllElements()
        {
            List<T> entities = OrderList(mainController.ReceiveAllEntities());

            DisplayerHeader("REGISTERED " + MenuTypeTitle.ToUpper());
            if (entities != null)
            {
                foreach (T e in entities)
                {
                    Console.WriteLine("  - " + e.ToString());
                }
            }
        }

        protected override string SelectOption()
        {
            Console.WriteLine($" - Enter 1 to insert a new {MenuTypeTitle}.");
            Console.WriteLine($" - Enter 2 to visualize existing {MenuTypeTitle}.");
            Console.WriteLine($" - Enter 3 to modify an existing {MenuTypeTitle}.");
            Console.WriteLine($" - Enter 4 to remove an existing {MenuTypeTitle}.");
            Console.WriteLine($" - Enter 5 to remove all existing {MenuTypeTitle}.");
            Console.WriteLine(" - Enter Q to quit.");

            string option = Console.ReadLine();

            return option;
        }
    }
}
