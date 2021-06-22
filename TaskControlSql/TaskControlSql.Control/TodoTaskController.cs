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

			string sqlCommand = @"INSERT INTO TodoTask
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

			command.CommandText = sqlCommand;

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

		protected override SqlCommand SqlSelectEntityCommand(int id, SqlConnection conectionDatabase)
		{
			SqlCommand command = new SqlCommand();
			command.Connection = conectionDatabase;

			string sqlCommand = @"SELECT * FROM TodoTask WHERE Id = @Id";

			//sqlInsert += @"SELECT SCOPE_IDENTITY();";

			command.CommandText = sqlCommand;

			command.Parameters.AddWithValue("Id", id);
			return command;
		}

		protected override SqlCommand SqlSelectAllCommand(SqlConnection conectionDatabase)
		{
			SqlCommand command = new SqlCommand();
			command.Connection = conectionDatabase;

			string sqlCommand = @"SELECT * FROM TodoTask";

			//sqlInsert += @"SELECT SCOPE_IDENTITY();";

			command.CommandText = sqlCommand;

			return command;
		}


		protected override SqlCommand SqlUpdateCommand(TodoTask entity, SqlConnection conectionDatabase)
		{
			SqlCommand command = new SqlCommand();
			command.Connection = conectionDatabase;

			string sqlCommand = @"UPDATE TodoTask SET
		            [Priority] = @Priority,
		            [Title] = @Title,
		            [DateConclusion] = @DateConclusion,
		            [PercentageConcluded] =@PercentageConcluded

				WHERE Id = @Id;";

			//sqlInsert += @"SELECT SCOPE_IDENTITY();";

			command.CommandText = sqlCommand;

			command.Parameters.AddWithValue("Id", entity.Id);
			command.Parameters.AddWithValue("Priority", entity.Priority);
			command.Parameters.AddWithValue("Title", entity.Title);
			if (entity.ConclusionTime == null)
				command.Parameters.AddWithValue("DateConclusion", DBNull.Value);
			else
				command.Parameters.AddWithValue("DateConclusion", entity.ConclusionTime);
			command.Parameters.AddWithValue("PercentageConcluded", entity.PercentageConcluded);

			return command;
		}

        protected override SqlCommand SqlDeleteEntityCommand(int id, SqlConnection conectionDatabase)
        {
			SqlCommand command = new SqlCommand();
			command.Connection = conectionDatabase;

			string sqlCommand = @"DELETE FROM TodoTask WHERE Id = @Id";

			//sqlInsert += @"SELECT SCOPE_IDENTITY();";

			command.CommandText = sqlCommand;

			command.Parameters.AddWithValue("Id", id);
			return command;
		}


		protected override SqlCommand SqlDeleteAllCommand(SqlConnection conectionDatabase)
		{
			SqlCommand command = new SqlCommand();
			command.Connection = conectionDatabase;

			string sqlCommand = @"DELETE FROM TodoTask";

			command.CommandText = sqlCommand;
			return command;

		}
    }
}
