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
        protected abstract SqlCommand SqlDeleteAllCommand(SqlConnection conectionDatabase);
        protected abstract SqlCommand SqlSelectEntity(int id, SqlConnection conectionDatabase);

        public string CreateEntity(T entity)
        {
            entity.Id = this.GenerateId();
            SqlConnection conectionDatabase = ConnectToDatabase();
            SqlCommand commandInsert = SqlInsertCommand(entity, conectionDatabase);

            string operationMessage;
            try
            {
                commandInsert.ExecuteScalar();
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
            SqlCommand commandInsert = SqlSelectEntity(index,conectionDatabase);

            bool result;
            try
            {
                object task = commandInsert.ExecuteScalar();
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
            SqlCommand commandInsert = SqlSelectEntity(index, conectionDatabase);

            T entity;
            try
            {
                entity = (T)commandInsert.ExecuteScalar();
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
            throw new NotImplementedException();
            //List<T> entityAux = null;

            //try
            //{
            //    return DB.GetAllEntities();
            //}
            //catch (Exception)
            //{
            //    return entityAux;
            //}

        }

        public string UpdateEntity(T entity)   //DO NOT UPDATE ATTRIBUTE TodoTask.CreationTime
        {
            throw new NotImplementedException();
            //string operationMessage;

            //try
            //{
            //    entity.Id = this.GenerateId();
            //    DB.PostUpdateEntity(entity);
            //    operationMessage = "OP_SUCCESS";
            //}
            //catch (Exception e)
            //{
            //    operationMessage = "Error: " + e.Message;
            //}

            //return operationMessage;
        }

        public bool DeleteEntity(int index)
        {
            return false;
            //try
            //{
            //    DB.PostDeleteEntity(index);
            //    return true;
            //}
            //catch (Exception)
            //{
            //    return false;
            //}
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
