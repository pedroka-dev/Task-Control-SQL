using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskControlSql.ConsoleApp.Domain;

namespace TaskControlSql.ConsoleApp.Control
{
    class TodoTaskController : Controller<TodoTask>
    {
        public override string CreateEntity(TodoTask entity)
        {
            throw new NotImplementedException();
        }

        public override bool ExistEntity(int index)
        {
            throw new NotImplementedException();
        }

        public override TodoTask ReceiveEntity(int index)
        {
            throw new NotImplementedException();
        }

        public override List<TodoTask> ReceiveAllEntities()
        {
            throw new NotImplementedException();
        }

        public override string UpdateEntity(TodoTask entity)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }
    }
}
