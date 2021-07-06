using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using TaskControlSql.Domain;

namespace TaskControlSql.Control
{
    public delegate T ConverterDelegate<T>(IDataReader reader);

    public abstract class Controller<T> where T : Entity
    {
        public static readonly string databaseType = ConfigurationManager.AppSettings["databaseType"].ToLower();

        protected abstract T ConvertToEntity(IDataReader reader);
        protected abstract DbCommand DBInsertCommand(T entity, DbConnection conectionDatabase);
        protected abstract DbCommand DBUpdateCommand(T entity, DbConnection conectionDatabase);
        protected abstract DbCommand DBSelectEntityCommand(int id, DbConnection conectionDatabase);
        protected abstract DbCommand DBSelectAllCommand(DbConnection conectionDatabase);
        protected abstract DbCommand DBExistEntityCommand(int id, DbConnection conectionDatabase);
        protected abstract DbCommand DBDeleteEntityCommand(int id, DbConnection conectionDatabase);
        protected abstract DbCommand DBDeleteAllCommand(DbConnection conectionDatabase);


        public string CreateEntity(T entity)
        {
            DbConnection conectionDatabase = ConnectToDatabase();
            DbCommand commandInsertEntity = DBInsertCommand(entity, conectionDatabase);

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
            DbCommand commandExistEntity = DBExistEntityCommand(index, conectionDatabase);

            int numberRows = Convert.ToInt32(commandExistEntity.ExecuteScalar());
            bool result = numberRows > 0;

            conectionDatabase.Close();
            return result;
        }

        public T ReceiveEntity(int index)
        {
            DbConnection conectionDatabase = ConnectToDatabase();
            DbCommand commandReceiveEntity = DBSelectEntityCommand(index, conectionDatabase);

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
            DbCommand commandReceiveAllEntities = DBSelectAllCommand(conectionDatabase);

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
            DbCommand commandUpdate = DBUpdateCommand(entity, conectionDatabase);

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
            DbCommand commandDeleteEntity = DBDeleteEntityCommand(index, conectionDatabase);

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
            DbCommand commandDeleteAll = DBDeleteAllCommand(conectionDatabase);

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

        protected static DbConnection ConnectToDatabase()
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
                //sql litle here
            }
            else
            {
                throw new Exception("Database type of "+databaseType+" not yet suported. Use only 'sql' or 'sqlite'");
            }
            connection.Open();
            return connection;
        }
    }
}
