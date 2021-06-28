using System;
using System.Collections.Generic;
using System.Linq;
using TaskControlSql.ConsoleApp.Control;
using TaskControlSql.ConsoleApp.Domain;

namespace TaskControlSql.ConsoleApp.View
{
    public class TodoTaskMenu : RegistrableMenu<TodoTask>
    {
        public TodoTaskMenu(TodoTaskController taskController, ConsoleColor fontColor)
        {
            this.mainController = taskController;
            MenuTypeTitle = "task";
            this.fontColor = fontColor;
        }
        
        public override void RegisterElement()
        {
            DisplayerHeader("REGISTER TASK");

            Console.WriteLine(" - Enter the priority of the task (HIGH, MEDIUM or LOW):");
            string priority = Console.ReadLine();

            Console.WriteLine(" - Enter the title of the task:");
            string title = Console.ReadLine();

            TodoTask todoTask;

            try
            {
                todoTask = new TodoTask(0, priority, title, DateTime.Now);
            }
            catch (Exception e)
            {
                DisplayErrorText("Error: " + e.Message);
                return;
            }
            string response = mainController.CreateEntity(todoTask);

            if (response != "OP_SUCCESS")
                DisplayErrorText(response);
            else
            {
                DisplaySuccessText("Register Operation Sucessful.");
                Console.ReadLine();
                return;
            }
        }

        public override void ModifyElement()
        {
            VisualizeAllElements();
            DisplayerHeader("MODIFY TASK");

            Console.WriteLine(" - Enter id of the task to Modify.");
            string idTxt = Console.ReadLine();

            if (!int.TryParse(idTxt, out int id))
            {
                DisplayErrorText("Attribute id must a valid integer.");
                return;
            }
            if (!mainController.ExistEntity(id))
            {
                DisplayErrorText("Entity id does not exist.");
                return;
            }

            Console.WriteLine(" - Enter the priority of the task (HIGH, MEDIUM or LOW):");
            string priority = Console.ReadLine();

            Console.WriteLine(" - Enter the title of the task:");
            string title = Console.ReadLine();

            TodoTask todoTask;
            try
            {
                todoTask = new TodoTask(id, priority, title, DateTime.MinValue);
            }
            catch (Exception e)
            {
                DisplayErrorText("Error: " + e.Message);
                return;
            }

            Console.WriteLine(" - Enter the percentage concluded of the task (100 to complete):");
            string percentageConcludedTxt = Console.ReadLine();

            if (!float.TryParse(percentageConcludedTxt, out float percentageConcluded))
            {
                DisplayErrorText("Attribute percentageConcluded must a valid positive float.");
                return;
            }
            else
            {
                todoTask.UpdatePercentageConcluded(percentageConcluded);
            }

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

        protected override List<TodoTask> OrderList(List<TodoTask> EntityList)
        {
            return EntityList.OrderBy(x => x.Priority == "LOW").ThenBy(x => x.Priority == "MEDIUM").ThenBy(x => x.Priority == "HIGH").ToList();
        }
    }
}
