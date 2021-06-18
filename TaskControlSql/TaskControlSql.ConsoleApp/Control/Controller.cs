using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskControlSql.ConsoleApp.Domain;

namespace TaskControlSql.ConsoleApp.Control
{
    class Controller<T> where T : Entity
    {
        internal bool DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }

        internal List<T> SelectAllEntities()
        {
            throw new NotImplementedException();
        }

        internal string UpdateEntity(TodoTask todoTask)
        {
            throw new NotImplementedException();
        }
    }
}
