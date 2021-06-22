using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TaskControlSql.ConsoleApp.Domain;

namespace TaskControlSql.ConsoleApp.Control
{
    public abstract class Controller<T> where T : Entity
    {
        protected int lastRegisteredId = 0;
        protected abstract SqlCommand SqlInsertCommand(T entity,SqlConnection conectionDatabase);
        protected abstract SqlCommand SqlUpdateCommand(T entity, SqlConnection conectionDatabase);
        protected abstract SqlCommand SqlSelectEntityCommand(int id, SqlConnection conectionDatabase);
        protected abstract SqlCommand SqlSelectAllCommand(SqlConnection conectionDatabase);
        protected abstract SqlCommand SqlDeleteEntityCommand(int id, SqlConnection conectionDatabase);
        protected abstract SqlCommand SqlDeleteAllCommand(SqlConnection conectionDatabase);
        

        public string CreateEntity(T entity)
        {
            entity.Id = this.GenerateId();
            SqlConnection conectionDatabase = ConnectToDatabase();
            SqlCommand commandInsertEntity = SqlInsertCommand(entity, conectionDatabase);

            string operationMessage;
            try
            {
                commandInsertEntity.ExecuteScalar();
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
            SqlCommand commandExistEntity = SqlSelectEntityCommand(index,conectionDatabase);

            bool result;
            try
            {
                object task = commandExistEntity.ExecuteScalar();
                if(task != null)
                    result = true;
                else
                    result = false;
            }
            catch (Exception e)
            {
                result = false;
            }

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
                entity = (T)commandReceiveEntity.ExecuteScalar();
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
            SqlCommand commandReceiveEntity = SqlSelectAllCommand( conectionDatabase);

            List<T> entities;
            try
            {
                entities = (List<T>)commandReceiveEntity.ExecuteScalar();
            }
            catch (Exception e)
            {
                entities = null;
            }

            conectionDatabase.Close();
            return entities;
        }

        public string UpdateEntity(T entity)
        {
            entity.Id = this.GenerateId();
            SqlConnection conectionDatabase = ConnectToDatabase();
            SqlCommand commandUpdate = SqlUpdateCommand(entity, conectionDatabase);

            string operationMessage;
            try
            {
                commandUpdate.ExecuteScalar();
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
            try
            {
                object task = commandDeleteEntity.ExecuteScalar();
                if (task != null)
                    result = true;
                else
                    result = false;
            }
            catch (Exception e)
            {
                result = false;
            }

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
                commandDeleteAll.ExecuteScalar();
                operationMessage = "OP_SUCCESS";
            }
            catch (Exception e)
            {
                operationMessage = "Error: " + e.Message;
            }

            conectionDatabase.Close();
            return operationMessage;
        }

        protected int GenerateId()
        {
            return ++lastRegisteredId;
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
