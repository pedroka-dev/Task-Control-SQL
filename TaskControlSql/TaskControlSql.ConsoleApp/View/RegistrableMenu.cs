using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskControlSql.ConsoleApp.Control;
using TaskControlSql.ConsoleApp.Domain;

namespace TaskControlSql.ConsoleApp.View
{
    abstract class RegistrableMenu <T> : Menu where T : Entity
    {
        protected string MenuTypeTitle;
        protected Controller<T> mainController;

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

            if (mainController.DeleteEntity(id))
            {
                DisplaySuccessText("Delete operation sucessful");
                return;
            }
            else
            {
                DisplayErrorText("Delete operation failed. Element not found.");
                Console.ReadLine();
            }
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

                    default:
                        DisplayErrorText("Invalid option. Use only the available options from above.");
                        break;
                }
                Console.ReadLine();
            }
        }

        public void VisualizeAllElements()
        {
            List<T> entities = mainController.ReceiveAllEntities();
            DisplayerHeader("REGISTERED " + MenuTypeTitle.ToUpper());
            foreach (T e in entities)
            {
                Console.WriteLine("  - " + e.ToString());
            }
        }

        protected override string SelectOption()
        {
            Console.WriteLine($" - Enter 1 to insert a new {MenuTypeTitle}.");
            Console.WriteLine($" - Enter 2 to visualize existing {MenuTypeTitle}.");
            Console.WriteLine($" - Enter 3 to modify an existing {MenuTypeTitle}.");
            Console.WriteLine($" - Enter 4 to remove an existing {MenuTypeTitle}.");
            Console.WriteLine(" - Enter Q to quit.");

            string option = Console.ReadLine();

            return option;
        }
    }
}
