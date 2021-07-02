using System;
using System.Collections.Generic;
using System.Linq;
using TaskControlSql.Control;
using TaskControlSql.Domain;

namespace TaskControlSql.ConsoleApp
{
    public class TodoTaskMenu : RegistrationMenu<TodoTask>
    {
        public TodoTaskMenu(TodoTaskController taskController, ConsoleColor fontColor)
        {
            this.mainController = taskController;
            MenuTypeTitle = "task";
            this.fontColor = fontColor;
        }


        protected override TodoTask UserInputToEntity(int id)
        {
            Console.WriteLine(" - Enter the priority of the task (HIGH, MEDIUM or LOW):");
            string priority = Console.ReadLine();

            Console.WriteLine(" - Enter the title of the task:");
            string title = Console.ReadLine();

            Console.WriteLine(" - Enter the percentage concluded of the task (100 to complete):");
            string percentageConcludedTxt = Console.ReadLine();

            TodoTask todoTask = new TodoTask(id, priority, title, DateTime.Now);

            if (!float.TryParse(percentageConcludedTxt, out float percentageConcluded))
                throw new ArgumentException("Attribute percentageConcluded must a valid positive float.");
            else
                todoTask.UpdatePercentageConcluded(percentageConcluded);

            return todoTask;

        }

        protected override List<TodoTask> OrderList(List<TodoTask> EntityList)
        {
            return EntityList.OrderBy(x => x.Priority == "LOW").ThenBy(x => x.Priority == "MEDIUM").ThenBy(x => x.Priority == "HIGH").ToList();
        }
    }
}
