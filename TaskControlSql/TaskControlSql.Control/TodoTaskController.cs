using System;
using System.Data.SqlClient;
using TaskControlSql.ConsoleApp.Domain;

namespace TaskControlSql.ConsoleApp.Control
{
    public class TodoTaskController : Controller<TodoTask>
    {
        protected override SqlCommand SqlInsertCommand(TodoTask entity, SqlConnection conectionDatabase)
		{
			SqlCommand command = new SqlCommand();
			command.Connection = conectionDatabase;

			string sqlInsert = @"INSERT INTO TodoTask
	            (
		            [Id],
		            [Priority],
		            [Title],
		            [DateCreation],
		            [DateConclusion],
		            [PercentageConcluded]
	            )
	            VALUES
	            (
		            @Id,
		            @Priority,
		            @Title,
		            @DateCreation,
		            @DateConclusion,
		            @PercentageConcluded
	             );";

			//sqlInsert += @"SELECT SCOPE_IDENTITY();";

			command.CommandText = sqlInsert;

			command.Parameters.AddWithValue("Id", entity.Id);
			command.Parameters.AddWithValue("Priority", entity.Priority);
			command.Parameters.AddWithValue("Title", entity.Title);
			command.Parameters.AddWithValue("DateCreation", entity.CreationTime);
			if(entity.ConclusionTime == null)
				command.Parameters.AddWithValue("DateConclusion", DBNull.Value);
			else
				command.Parameters.AddWithValue("DateConclusion", entity.ConclusionTime);
			command.Parameters.AddWithValue("PercentageConcluded", entity.PercentageConcluded);

			return command;
		}

		protected override SqlCommand SqlDeleteAllCommand(SqlConnection conectionDatabase)
		{
			SqlCommand command = new SqlCommand();
			command.Connection = conectionDatabase;

			string sqlDeleteAll = @"DELETE FROM TodoTask";

			command.CommandText = sqlDeleteAll;
			return command;

		}

        protected override SqlCommand SqlSelectEntity(int id, SqlConnection conectionDatabase)
        {
			SqlCommand command = new SqlCommand();
			command.Connection = conectionDatabase;

			string sqlInsert = @"SELECT * FROM TodoTask WHERE Id = @Id";

			//sqlInsert += @"SELECT SCOPE_IDENTITY();";

			command.CommandText = sqlInsert;

			command.Parameters.AddWithValue("Id", id);
			return command;
		}
    }
}
