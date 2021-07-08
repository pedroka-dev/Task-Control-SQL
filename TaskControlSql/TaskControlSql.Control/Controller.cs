using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using TaskControlSql.Domain;

namespace TaskControlSql.Control
{
    public delegate T ConverterDelegate<T>(IDataReader reader);

    public abstract class Controller<T> where T : Entity
    {
        public static readonly string databaseType = ConfigurationManager.AppSettings["databaseType"].ToLower();
        protected abstract List<DbParameter> ReceiveEntityParameters(T entity, DbCommand command);
        protected abstract T ConvertToEntity(IDataReader reader);
        protected abstract string SqlInsertCommand();
        protected abstract string SqlUpdateCommand();
        protected abstract string SqlSelectEntityCommand();
        protected abstract string SqlSelectAllCommand();
        protected abstract string SqlExistEntityCommand();
        protected abstract string SqlDeleteEntityCommand();
        protected abstract string SqlDeleteAllCommand();

        public string CreateEntity(T entity)
        {
            DbConnection conectionDatabase = ConnectToDatabase();
            DbCommand commandInsertEntity = ExecuteDBInsert(entity, conectionDatabase);

            string operationMessage;
            try
            {
                entity.Id = Convert.ToInt32(commandInsertEntity.ExecuteScalar());
                operationMessage = "OP_SUCCESS";
            }
            catch (Exception e)
            {
                operationMessage = "Error: " + e.Message;
            }

            conectionDatabase.Close();
            return operationMessage;
        }

        public bool ExistEntity(int index)
        {
            DbConnection conectionDatabase = ConnectToDatabase();
            DbCommand commandExistEntity = ExecuteDBExistEntity(index, conectionDatabase);

            int numberRows = Convert.ToInt32(commandExistEntity.ExecuteScalar());
            bool result = numberRows > 0;

            conectionDatabase.Close();
            return result;
        }

        public T ReceiveEntity(int index)
        {
            DbConnection conectionDatabase = ConnectToDatabase();
            DbCommand commandReceiveEntity = ExecuteDBSelectEntity(index, conectionDatabase);

            T entity = null;

            DbDataReader reader = commandReceiveEntity.ExecuteReader();
            while (reader.Read())
            {
                entity = ConvertToEntity(reader);
            }

            conectionDatabase.Close();
            return entity;
        }

        public List<T> ReceiveAllEntities()
        {
            DbConnection conectionDatabase = ConnectToDatabase();
            DbCommand commandReceiveAllEntities = ExecuteDBSelectAll(conectionDatabase);

            List<T> entities = new List<T>();

            DbDataReader reader = commandReceiveAllEntities.ExecuteReader();

            while (reader.Read())
            {
                T entity = ConvertToEntity(reader);
                entities.Add(entity);
            }

            conectionDatabase.Close();
            return entities;
        }

        public string UpdateEntity(T entity)
        {
            DbConnection conectionDatabase = ConnectToDatabase();
            DbCommand commandUpdate = ExecuteDBUpdate(entity, conectionDatabase);

            string operationMessage;
            try
            {
                commandUpdate.ExecuteNonQuery();
                operationMessage = "OP_SUCCESS";
            }
            catch (Exception e)
            {
                operationMessage = "Error: " + e.Message;
            }

            conectionDatabase.Close();
            return operationMessage;
        }

        public bool DeleteEntity(int index)
        {
            DbConnection conectionDatabase = ConnectToDatabase();
            DbCommand commandDeleteEntity = ExecuteDBDeleteEntity(index, conectionDatabase);

            bool result;

            object task = commandDeleteEntity.ExecuteNonQuery();
            if (task != null)
                result = true;
            else
                result = false;

            conectionDatabase.Close();
            return result;
        }

        public string DeleteAllEntities()
        {
            DbConnection conectionDatabase = ConnectToDatabase();
            DbCommand commandDeleteAll = ExecuteDBDeleteAll(conectionDatabase);

            string operationMessage;
            try
            {
                commandDeleteAll.ExecuteNonQuery();
                operationMessage = "OP_SUCCESS";
            }
            catch (Exception e)
            {
                operationMessage = "Error: " + e.Message;
            }

            conectionDatabase.Close();
            return operationMessage;
        }

        protected static DbConnection ConnectToDatabase()       //colocar as ConnectionString no App.config
        {
            DbConnection connection = null;

            if (databaseType.Equals("sql"))
            {
                connection = new SqlConnection
                {
                    ConnectionString = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTaskControl;Integrated Security=True;Pooling=False"
                };
                ;
            }
            else if (databaseType.Equals("sqlite"))
            {
                connection = new SQLiteConnection
                {
                    ConnectionString = @"Data Source=\Users\Pedroska\Documents\GitHub\Task-Control-SQL\TaskControlSql\TaskControlSql.Control\bin\Database\DBTaskControlSqLite.db"
                };
                ;
            }
            else
            {
                throw new Exception("Database type of " + databaseType + " not yet suported. Use only 'sql' or 'sqlite'");
            }
            connection.Open();
            return connection;
        }

        protected DbCommand ExecuteDBInsert(T entity, DbConnection conectionDatabase)
        {

            DbCommand command;
            string selectScopeCommand;
            if (databaseType == "sql")
            {
                command = new SqlCommand();
                selectScopeCommand = @"SELECT SCOPE_IDENTITY();";
            }
            else
            {
                command = new SQLiteCommand();
                selectScopeCommand = @"SELECT last_insert_rowid();";
            }

            command.Connection = conectionDatabase;

            command.CommandText = SqlInsertCommand() + selectScopeCommand;

            List<DbParameter> parameterList = ReceiveEntityParameters(entity, command);

            foreach (DbParameter param in parameterList)
            {
                command.Parameters.Add(param);
            }

            return command;
        }

        protected DbCommand ExecuteDBUpdate(T entity, DbConnection conectionDatabase)
        {
            DbCommand command;
            string selectScopeCommand;
            if (databaseType == "sql")
            {
                command = new SqlCommand();
                selectScopeCommand = @"SELECT SCOPE_IDENTITY();";
            }
            else
            {
                command = new SQLiteCommand();
                selectScopeCommand = @"SELECT last_insert_rowid();";
            }

            command.Connection = conectionDatabase;

            command.CommandText = SqlUpdateCommand() + selectScopeCommand;

            List<DbParameter> parameterList = ReceiveEntityParameters(entity, command);

            foreach (DbParameter param in parameterList)
            {
                command.Parameters.Add(param);
            }

            DbParameter parameterId = command.CreateParameter();
            parameterId.ParameterName = "Id";
            parameterId.Value = entity.Id;
            command.Parameters.Add(parameterId);

            return command;
        }

        protected DbCommand ExecuteDBSelectEntity(int id, DbConnection conectionDatabase)
        {
            DbCommand command;

            if (databaseType == "sql")
                command = new SqlCommand();
            else
                command = new SQLiteCommand();

            command.Connection = conectionDatabase;

            command.CommandText = SqlSelectEntityCommand();

            DbParameter parameterId = command.CreateParameter();
            parameterId.ParameterName = "Id";
            parameterId.Value = id;
            command.Parameters.Add(parameterId);


            return command;
        }

        protected DbCommand ExecuteDBSelectAll(DbConnection conectionDatabase)
        {
            DbCommand command;
            if (databaseType == "sql")
                command = new SqlCommand();
            else
                command = new SQLiteCommand();

            command.Connection = conectionDatabase;

            command.CommandText = SqlSelectAllCommand();

            return command;
        }

        protected DbCommand ExecuteDBExistEntity(int id, DbConnection conectionDatabase)
        {
            DbCommand command;
            if (databaseType == "sql")
                command = new SqlCommand();
            else
                command = new SQLiteCommand();

            command.Connection = conectionDatabase;

            command.CommandText = SqlExistEntityCommand();

            DbParameter parameterId = command.CreateParameter();
            parameterId.ParameterName = "Id";
            parameterId.Value = id;
            command.Parameters.Add(parameterId);

            return command;
        }

        protected DbCommand ExecuteDBDeleteEntity(int id, DbConnection conectionDatabase)
        {
            DbCommand command;
            if (databaseType == "sql")
                command = new SqlCommand();
            else
                command = new SQLiteCommand();

            command.Connection = conectionDatabase;

            command.CommandText = SqlDeleteEntityCommand();

            DbParameter parameterId = command.CreateParameter();
            parameterId.ParameterName = "Id";
            parameterId.Value = id;
            command.Parameters.Add(parameterId);

            return command;
        }
        
        protected DbCommand ExecuteDBDeleteAll(DbConnection conectionDatabase)  // to reseed " DBCC CHECKIDENT('TodoTask', RESEED, 0)";
        {
            DbCommand command;

            if (databaseType == "sql")
                command = new SqlCommand();
            else
                command = new SQLiteCommand();

            command.Connection = conectionDatabase;

            command.CommandText = SqlDeleteAllCommand();
            return command;
        }
    }
}
