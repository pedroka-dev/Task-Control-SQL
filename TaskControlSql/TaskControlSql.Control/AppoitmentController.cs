using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskControlSql.ConsoleApp.Domain;

namespace TaskControlSql.ConsoleApp.Control
{
    public class AppoitmentController : Controller<Appointment>
    {
        protected override Appointment ConvertToEntity(IDataReader reader)
        {
            throw new NotImplementedException();
        }

        protected override SqlCommand SqlDeleteAllCommand(SqlConnection conectionDatabase)
        {
            throw new NotImplementedException();
        }

        protected override SqlCommand SqlDeleteEntityCommand(int id, SqlConnection conectionDatabase)
        {
            throw new NotImplementedException();
        }

        protected override SqlCommand SqlExistEntityCommand(int id, SqlConnection conectionDatabase)
        {
            throw new NotImplementedException();
        }

        protected override SqlCommand SqlInsertCommand(Appointment entity, SqlConnection conectionDatabase)
        {
            throw new NotImplementedException();
        }

        protected override SqlCommand SqlSelectAllCommand(SqlConnection conectionDatabase)
        {
            throw new NotImplementedException();
        }

        protected override SqlCommand SqlSelectEntityCommand(int id, SqlConnection conectionDatabase)
        {
            throw new NotImplementedException();
        }

        protected override SqlCommand SqlUpdateCommand(Appointment entity, SqlConnection conectionDatabase)
        {
            throw new NotImplementedException();
        }
    }
}
