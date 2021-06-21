using System;
using System.Collections.Generic;
using TaskControlSql.ConsoleApp.Domain;

namespace TaskControlSql.ConsoleApp.Control
{
    public abstract class Controller<T> where T : Entity
    {
        protected int lastRegisteredId = 0;
        object DB;

        public string CreateEntity(T entity)
        {
            string operationMessage;

            try
            {
                entity.Id = this.GenerateId();
                //DB.PostCreateEntity(entity);
                operationMessage = "OP_SUCCESS";
            }
            catch (Exception e)
            {
                operationMessage = "Error: " + e.Message;
            }

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

        protected int GenerateId()
        {
            return ++lastRegisteredId;
        }
    }
}
