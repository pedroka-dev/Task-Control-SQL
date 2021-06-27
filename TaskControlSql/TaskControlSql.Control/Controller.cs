using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TaskControlSql.ConsoleApp.Domain;

namespace TaskControlSql.ConsoleApp.Control
{
    public delegate T ConverterDelegate<T>(IDataReader reader);

    public abstract class Controller<T> where T : Entity
    {
        protected abstract T ConvertToEntity(IDataReader reader);
        protected abstract SqlCommand SqlInsertCommand(T entity,SqlConnection conectionDatabase);
        protected abstract SqlCommand SqlUpdateCommand(T entity, SqlConnection conectionDatabase);
        protected abstract SqlCommand SqlSelectEntityCommand(int id, SqlConnection conectionDatabase);
        protected abstract SqlCommand SqlSelectAllCommand(SqlConnection conectionDatabase);
        protected abstract SqlCommand SqlExistEntityCommand(int id, SqlConnection conectionDatabase);
        protected abstract SqlCommand SqlDeleteEntityCommand(int id, SqlConnection conectionDatabase);
        protected abstract SqlCommand SqlDeleteAllCommand(SqlConnection conectionDatabase);
        

        public string CreateEntity(T entity)
        {
            SqlConnection conectionDatabase = ConnectToDatabase();
            SqlCommand commandInsertEntity = SqlInsertCommand(entity, conectionDatabase);

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
            SqlConnection conectionDatabase = ConnectToDatabase();
            SqlCommand commandExistEntity = SqlExistEntityCommand(index,conectionDatabase);

                int numberRows = Convert.ToInt32(commandExistEntity.ExecuteScalar());
                bool result = numberRows > 0;

            conectionDatabase.Close();
            return result;
        }

        public T ReceiveEntity(int index)
        {
            SqlConnection conectionDatabase = ConnectToDatabase();
            SqlCommand commandReceiveEntity = SqlSelectEntityCommand(index, conectionDatabase);

            T entity;
            try
            {
                SqlDataReader reader = commandReceiveEntity.ExecuteReader();
                entity = ConvertToEntity(reader);
            }
            catch (Exception e)
            {
                entity = null;
            }

            conectionDatabase.Close();
            return entity;
        }

        public List<T> ReceiveAllEntities()
        {
            SqlConnection conectionDatabase = ConnectToDatabase();
            SqlCommand commandReceiveAllEntities = SqlSelectAllCommand(conectionDatabase);

            List<T> entities = new List<T>();
            
                SqlDataReader reader = commandReceiveAllEntities.ExecuteReader();

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
            SqlConnection conectionDatabase = ConnectToDatabase();
            SqlCommand commandUpdate = SqlUpdateCommand(entity, conectionDatabase);

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
            SqlConnection conectionDatabase = ConnectToDatabase();
            SqlCommand commandDeleteEntity = SqlDeleteEntityCommand(index, conectionDatabase);

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
            SqlConnection conectionDatabase = ConnectToDatabase();
            SqlCommand commandDeleteAll = SqlDeleteAllCommand(conectionDatabase);

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

        protected static SqlConnection ConnectToDatabase()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTaskControl;Integrated Security=True;Pooling=False"; ;
            connection.Open();
            return connection;
        }
    }
}
