using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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

        protected override List<DbParameter> ReceiveEntityParameters(TodoTask entity, DbCommand command)
        {
            List<DbParameter> parameters = new List<DbParameter>();

            DbParameter priorityParam = command.CreateParameter();
            priorityParam.ParameterName = "Priority";
            priorityParam.Value = entity.Priority;
            parameters.Add(priorityParam);

            DbParameter titleParam = command.CreateParameter();
            titleParam.ParameterName = "Title";
            titleParam.Value = entity.Title;
            parameters.Add(titleParam);

            DbParameter dateCreationParam = command.CreateParameter();
            dateCreationParam.ParameterName = "DateCreation";
            dateCreationParam.Value = entity.CreationTime;
            parameters.Add(dateCreationParam);

            DbParameter dateConclusionParam = command.CreateParameter();
            dateConclusionParam.ParameterName = "DateConclusion";
            object dateConclusionValue = DBNull.Value;
            if (entity.ConclusionTime != null)
                dateConclusionValue = entity.ConclusionTime;
            dateConclusionParam.Value = dateConclusionValue;
            parameters.Add(dateConclusionParam);

            DbParameter percentageConcludedParam = command.CreateParameter();
            percentageConcludedParam.ParameterName = "PercentageConcluded";
            percentageConcludedParam.Value = entity.PercentageConcluded;
            parameters.Add(percentageConcludedParam);

            return parameters;
        }

        protected override string SqlInsertCommand()
        {
            return @"INSERT INTO [TodoTask]
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
        }

        protected override string SqlUpdateCommand()
        {
            return @"UPDATE [TodoTask] 
				SET
		            [Priority] = @Priority,
		            [Title] = @Title,
		            [DateConclusion] = @DateConclusion,
		            [PercentageConcluded] = @PercentageConcluded

				WHERE [Id] = @Id;";
        }

        protected override string SqlSelectEntityCommand()
        {
            return @"SELECT
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
        }

        protected override string SqlSelectAllCommand()
        {
            return @"SELECT
		            [Id],
		            [Priority],
		            [Title],
		            [DateCreation],
		            [DateConclusion],
		            [PercentageConcluded]
	            FROM 
					[TodoTask]";
        }

        protected override string SqlExistEntityCommand()
        {
            return @"SELECT
		            COUNT(*) 
	            FROM 
					[TodoTask]
				WHERE
					[Id] = @Id;";
        }

        protected override string SqlDeleteEntityCommand()
        {
            return @"DELETE FROM [TodoTask] WHERE [Id] = @Id"; ;
        }

        protected override string SqlDeleteAllCommand()
        {
            return @"DELETE FROM TodoTask;";
        }
    }
}
