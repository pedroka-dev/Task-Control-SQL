using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskControlSql.ConsoleApp.Domain;

namespace TaskControlSql.ConsoleApp.View
{
    class TodoTaskMenu : RegistrableMenu<TodoTask>
    {
        public TodoTaskMenu(ConsoleColor fontColor)
        {
            MenuTypeTitle = "task";
            this.fontColor = fontColor;
        }
        //int id, string priority, string title, DateTime creationTime, DateTime? conclusionTime, float percentageConcluded
        public override void RegisterElement()
        {
            DisplayerHeader("REGISTER TASK");

            Console.WriteLine(" - Enter the priority of the task:");
            string priority = Console.ReadLine();

            Console.WriteLine(" - Enter the title of the task:");
            string title = Console.ReadLine();

            TodoTask todoTask = new TodoTask(0, priority, title, DateTime.Now, null, 0);
            string response = mainController.UpdateEntity(todoTask);

            if (response != "OP_SUCCESS")
                DisplayErrorText(response);
            else
            {
                DisplaySuccessText("Register Operation Sucessful");
                Console.ReadLine();
                return;
            }
        }

        public override void ModifyElement()
        {
            DisplayerHeader("REGISTER TASK");

            Console.WriteLine(" - Enter id of the friend to Modify.");
            string idTxt = Console.ReadLine();

            if (!int.TryParse(idTxt, out int id))
            {
                DisplayErrorText("Attribute id must a valid integer.");
                return;
            }

            Console.WriteLine(" - Enter the priority of the task:");
            string priority = Console.ReadLine();

            Console.WriteLine(" - Enter the title of the task:");
            string title = Console.ReadLine();

            //needs conclusionTime and percentageConcluded

            TodoTask todoTask = new TodoTask(id, priority, title, DateTime.Now, null, 0);
            string response = mainController.UpdateEntity(todoTask);

            if (response != "OP_SUCCESS")
                DisplayErrorText(response);
            else
            {
                DisplaySuccessText("Register Operation Sucessful");
                Console.ReadLine();
                return;
            }
        }   
    }
}
