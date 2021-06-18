using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskControlSql.ConsoleApp.Domain
{
    class TodoTask : Entity 
    {
        private string priority;
        private string title;
        private DateTime creationTime;
        private DateTime? conclusionTime;
        private float percentageConcluded;

        public TodoTask(int id, string priority, string title, DateTime creationTime, DateTime? conclusionTime, float percentageConcluded)
        {
            if (id < 0)
                throw new ArgumentException("Attribute 'id' cannot be a number smaller than 0.");
            if (string.IsNullOrEmpty(priority))
                throw new ArgumentNullException("Attribute 'priority' cannot be null or empty.");
            if (string.IsNullOrEmpty(title))
                throw new ArgumentNullException("Attribute 'title' cannot be null or empty.");
            if (creationTime > DateTime.Now)
                throw new ArgumentException("Attribute 'creationTime' cannot a date from the future.");
            if (percentageConcluded < 0)
                throw new ArgumentException("Attribute 'percentageConcluded' cannot be a number smaller than 0.");

            this.id = id;
            this.priority = priority;
            this.title = title;
            this.creationTime = creationTime;
            this.conclusionTime = conclusionTime;
            this.percentageConcluded = percentageConcluded;
        }

        public string Priority { get => priority;}
        public string Title { get => title;}
        public DateTime CreationTime { get => creationTime;}
        public DateTime? ConclusionTime { get => conclusionTime; set => conclusionTime = value; }
        public float PercentageConcluded { get => percentageConcluded;}

        public override string ToString()
        {
            return $"Todo Task {id} = [{priority},{title},{creationTime},{conclusionTime},{percentageConcluded}]";
        }
    }
}
