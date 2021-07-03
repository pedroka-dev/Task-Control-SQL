using System;
using System.Data;
using System.Data.SqlClient;
using TaskControlSql.Domain;

namespace TaskControlSql.Control
{
    public class TodoTaskController : Controller<TodoTask>
    {
        protected override TodoTask ConvertToEntity(IDataReader reader)
        {
            int Id = Convert.ToInt32(reader["Id"]);
            string Priority = Convert.ToString(reader["Priority"]);
            string Title = Convert.ToString(reader["Title"]);
            DateTime dateCreation = Convert.ToDateTime(reader["DateCreation"]);
            object dateConclusionRaw = reader["DateConclusion"];
            DateTime dateConclusion;
            if (dateConclusionRaw == DBNull.Value)
                dateConclusion = DateTime.MinValue;
            else
                dateConclusion = Convert.ToDateTime(dateConclusionRaw);
            TodoTask task = new TodoTask(Id, Priority, Title, dateCreation);

            float percentual = (float)Convert.ToDouble(reader["PercentageConcluded"]);
            task.UpdatePercentageConcluded(percentual, dateConclusion);

            return task;
        }

        protected override SqlCommand SqlInsertCommand(TodoTask entity, SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = conectionDatabase
            };

            string sqlCommand = @"INSERT INTO [TodoTask]
	            (
		            [Priority],
		            [Title],
		            [DateCreation],
		            [DateConclusion],
		            [PercentageConcluded]
	            )
	            VALUES
	            (
		            @Priority,
		            @Title,
		            @DateCreation,
		            @DateConclusion,
		            @PercentageConcluded
	             );";

            sqlCommand += @"SELECT SCOPE_IDENTITY();";

            command.CommandText = sqlCommand;

            command.Parameters.AddWithValue("Priority", entity.Priority);
            command.Parameters.AddWithValue("Title", entity.Title);
            command.Parameters.AddWithValue("DateCreation", entity.CreationTime);
            if (entity.ConclusionTime == null)
                command.Parameters.AddWithValue("DateConclusion", DBNull.Value);
            else
                command.Parameters.AddWithValue("DateConclusion", entity.ConclusionTime);
            command.Parameters.AddWithValue("PercentageConcluded", entity.PercentageConcluded);

            return command;
        }

        protected override SqlCommand SqlUpdateCommand(TodoTask entity, SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = conectionDatabase
            };

            string sqlCommand = @"UPDATE [TodoTask] 
				SET
		            [Priority] = @Priority,
		            [Title] = @Title,
		            [DateConclusion] = @DateConclusion,
		            [PercentageConcluded] = @PercentageConcluded

				WHERE [Id] = @Id;";

            sqlCommand += @"SELECT SCOPE_IDENTITY();";

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

        protected override SqlCommand SqlSelectEntityCommand(int id, SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = conectionDatabase
            };

            string sqlCommand = @"SELECT
		            [Id],
		            [Priority],
		            [Title],
		            [DateCreation],
		            [DateConclusion],
		            [PercentageConcluded]
	            FROM 
					[TodoTask]
				WHERE
					[Id] = @Id;";

            sqlCommand += @"SELECT SCOPE_IDENTITY();";

            command.CommandText = sqlCommand;

            command.Parameters.AddWithValue("Id", id);
            return command;
        }

        protected override SqlCommand SqlSelectAllCommand(SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = conectionDatabase
            };

            string sqlCommand = @"SELECT
		            [Id],
		            [Priority],
		            [Title],
		            [DateCreation],
		            [DateConclusion],
		            [PercentageConcluded]
	            FROM 
					[TodoTask]";

            command.CommandText = sqlCommand;

            return command;
        }

        protected override SqlCommand SqlExistEntityCommand(int id, SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = conectionDatabase
            };

            string sqlCommand = @"SELECT
		            COUNT(*) 
	            FROM 
					[TodoTask]
				WHERE
					[Id] = @Id;";

            command.CommandText = sqlCommand;

            command.Parameters.AddWithValue("Id", id);
            return command;
        }

        protected override SqlCommand SqlDeleteEntityCommand(int id, SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = conectionDatabase
            };

            string sqlCommand = @"DELETE FROM [TodoTask] WHERE [Id] = @Id";

            command.CommandText = sqlCommand;

            command.Parameters.AddWithValue("Id", id);
            return command;
        }

        protected override SqlCommand SqlDeleteAllCommand(SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = conectionDatabase
            };

            string sqlCommand = @"DELETE FROM TodoTask;";
            sqlCommand += " DBCC CHECKIDENT('TodoTask', RESEED, 0)";

            command.CommandText = sqlCommand;
            return command;
        }
    }
}
