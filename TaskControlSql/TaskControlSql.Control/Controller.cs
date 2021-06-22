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

        public string CreateEntity(T entity)
        {
            entity.Id = this.GenerateId();

            string adressDataBase = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTaskControl;Integrated Security=True;Pooling=False";
            SqlConnection conectionDatabase = new SqlConnection();
            conectionDatabase.ConnectionString = adressDataBase;
            conectionDatabase.Open();

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
            throw new NotImplementedException();
            //try
            //{
            //    return DB.GetExistEntity(index);
            //}
            //catch (Exception)
            //{
            //    return false;
            //}
        }

        public T ReceiveEntity(int index)
        {
            throw new NotImplementedException();
            //T entityAux = null;

            //try
            //{
            //    return DB.GetEntity(index);
            //}
            //catch (Exception)
            //{
            //    return entityAux;
            //}
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
            throw new NotImplementedException();
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
            string adressDataBase = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTaskControl;Integrated Security=True;Pooling=False";
            SqlConnection conectionDatabase = new SqlConnection();
            conectionDatabase.ConnectionString = adressDataBase;
            conectionDatabase.Open();

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

        protected int GenerateId()
        {
            return ++lastRegisteredId;
        }
    }
}
