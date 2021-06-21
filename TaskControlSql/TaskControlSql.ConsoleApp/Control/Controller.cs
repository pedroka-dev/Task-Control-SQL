using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskControlSql.ConsoleApp.Domain;

namespace TaskControlSql.ConsoleApp.Control
{
    abstract class Controller<T> where T : Entity
    {
        public abstract string CreateEntity(T entity);

        public abstract bool ExistEntity(int index);

        public abstract T ReceiveEntity(int index);

        public abstract List<T> ReceiveAllEntities();

        public abstract string UpdateEntity(T entity); //DO NOT UPDATE ATTRIBUTE TodoTask.CreationTime

        public abstract bool DeleteEntity(int id);
    }
}
