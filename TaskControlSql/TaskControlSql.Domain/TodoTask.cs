using System;

namespace TaskControlSql.ConsoleApp.Domain
{
    public class TodoTask : Entity
    {
        private string priority;
        private string title;
        private DateTime creationTime;
        private DateTime? conclusionTime;
        private float percentageConcluded;

        public TodoTask(int id, string priority, string title, DateTime creationTime)
        {
            if (id < 0)
                throw new ArgumentException("Attribute 'id' cannot be a number smaller than 0.");
            if (string.IsNullOrEmpty(priority))
                throw new ArgumentNullException("Attribute 'priority' cannot be null or empty.");
            if (string.IsNullOrEmpty(title))
                throw new ArgumentNullException("Attribute 'title' cannot be null or empty.");
            if (creationTime > DateTime.Now)
                throw new ArgumentException("Attribute 'creationTime' cannot a date from the future.");

            this.id = id;
            this.priority = priority;
            this.title = title;
            this.creationTime = creationTime;
            percentageConcluded = 0;
        }

        public string Priority { get => priority; }
        public string Title { get => title; }
        public DateTime CreationTime { get => creationTime; }
        public DateTime? ConclusionTime { get => conclusionTime; }
        public float PercentageConcluded { get => percentageConcluded; }

        public void UpdatePercentageConcluded(float percentage)
        {
            if (percentage >= 100)
            {
                percentageConcluded = 100;
                conclusionTime = DateTime.Now;
            }
            else if (percentage >= 0)
            {
                percentageConcluded = percentage;
                conclusionTime = null;
            }
        }

        public override string ToString()
        {
            return $"Todo Task {id} = [{priority},{title},{creationTime},{conclusionTime},{percentageConcluded}]";
        }
    }
}
