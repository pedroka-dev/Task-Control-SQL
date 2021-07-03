using System;
using System.Collections.Generic;

namespace TaskControlSql.Domain
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
            priority = priority.ToUpper();
            if (id < 0)
                throw new ArgumentException("Attribute 'id' cannot be a number smaller than 0.");
            if (string.IsNullOrEmpty(priority))
                throw new ArgumentNullException("Attribute 'priority' cannot be null or empty.");
            if (string.IsNullOrEmpty(title))
                throw new ArgumentNullException("Attribute 'title' cannot be null or empty.");
            if (creationTime > DateTime.Now)
                throw new ArgumentException("Attribute 'creationTime' cannot a date from the future.");
            if (!priority.StartsWith("HIGH") && !priority.StartsWith("MEDIUM") && !priority.StartsWith("LOW"))
                throw new ArgumentException("Attribute 'priority' cannot a string different from 'HIGH', 'MEDIUM' or 'LOW'.");

            this.id = id;
            this.priority = priority;
            this.title = title;
            this.creationTime = creationTime;
            percentageConcluded = 0;
            conclusionTime = null;
        }

        public string Priority { get => priority; }
        public string Title { get => title; }
        public DateTime CreationTime { get => creationTime; }
        public DateTime? ConclusionTime { get => conclusionTime; }
        public float PercentageConcluded { get => percentageConcluded; }

        public void UpdatePercentageConcluded(float percentage, DateTime timeToConclude)
        {
            if (percentage >= 100)
            {
                percentageConcluded = 100;
                conclusionTime = timeToConclude;
            }
            else if (percentage >= 0)
            {
                percentageConcluded = percentage;
                conclusionTime = null;
            }
        }


        public override bool Equals(object obj)
        {
            return obj is TodoTask task &&
                   id == task.id &&
                   priority == task.priority &&
                   title == task.title &&
                   creationTime == task.creationTime &&
                   conclusionTime == task.conclusionTime &&
                   percentageConcluded == task.percentageConcluded;
        }

        public override int GetHashCode()
        {
            int hashCode = -2116570414;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(priority);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(title);
            hashCode = hashCode * -1521134295 + creationTime.GetHashCode();
            hashCode = hashCode * -1521134295 + conclusionTime.GetHashCode();
            hashCode = hashCode * -1521134295 + percentageConcluded.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"TodoTask [ id='{id}', priority='{priority}', title='{title}', creationTime='{creationTime}', conclusionTime='{conclusionTime}', percentageConcluded='{percentageConcluded}' ]";
        }
    }
}
