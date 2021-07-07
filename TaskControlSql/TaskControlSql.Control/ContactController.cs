using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using TaskControlSql.Domain;

namespace TaskControlSql.Control
{
    public class ContactController : Controller<Contact>
    {
        protected override Contact ConvertToEntity(IDataReader reader)
        {
            int Id = Convert.ToInt32(reader["Id"]);
            string Name = Convert.ToString(reader["Name"]);
            string Email = Convert.ToString(reader["Email"]);
            string PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
            string BusinessCompany = Convert.ToString(reader["BusinessCompany"]);
            string PositionCompany = Convert.ToString(reader["CompanyPosition"]);

            Contact contact = new Contact(Id, Name, Email, PhoneNumber, BusinessCompany, PositionCompany);
            return contact;
        }

        //remover duplicacao de codigo usando os parametros atraves do command.CreateParameter(); e command.Parameters.Add(parameter);
        //DbCommand command;
        //    if (databaseType == "sql")
        //        command = new SqlCommand();
        //    else
        //        command = new SQLiteCommand();

        protected override DbCommand DBInsertCommand(Contact entity, DbConnection conectionDatabase)
        {
            string sqlCommand = @"INSERT INTO [Contact]
	            (
		            [Name],
		            [Email],
		            [PhoneNumber],
		            [BusinessCompany],
		            [CompanyPosition]
	            )
	            VALUES
	            (
		            @Name,
		            @Email,
		            @PhoneNumber,
		            @BusinessCompany,
		            @CompanyPosition
	             );";

            if (databaseType == "sql")
            {
                SqlCommand command = new SqlCommand();
                command.Connection = (SqlConnection)conectionDatabase;
                string selectScopeCommand = @"SELECT SCOPE_IDENTITY();";

                command.CommandText = sqlCommand + selectScopeCommand;

                command.Parameters.AddWithValue("Name", entity.Name);
                command.Parameters.AddWithValue("Email", entity.Email);
                command.Parameters.AddWithValue("PhoneNumber", entity.PhoneNumber);
                command.Parameters.AddWithValue("BusinessCompany", entity.BusinessCompany);
                command.Parameters.AddWithValue("CompanyPosition", entity.CompanyPosition);
                return command;
            }
            else
            {
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = (SQLiteConnection)conectionDatabase;
                string selectScopeCommand = @"SELECT last_insert_rowid();";

                command.CommandText = sqlCommand + selectScopeCommand;

                command.Parameters.AddWithValue("Name", entity.Name);
                command.Parameters.AddWithValue("Email", entity.Email);
                command.Parameters.AddWithValue("PhoneNumber", entity.PhoneNumber);
                command.Parameters.AddWithValue("BusinessCompany", entity.BusinessCompany);
                command.Parameters.AddWithValue("CompanyPosition", entity.CompanyPosition);
                return command;
            }
        }

        protected override DbCommand DBUpdateCommand(Contact entity, DbConnection conectionDatabase)
        {
            string sqlCommand = @"UPDATE [Contact] 
				SET
		            [Name] = @Name,
		            [Email] = @Email,
		            [PhoneNumber] = @PhoneNumber,
		            [BusinessCompany] = @BusinessCompany,
		            [CompanyPosition] = @CompanyPosition

				WHERE [Id] = @Id;";

            if (databaseType == "sql")
            {
                SqlCommand command = new SqlCommand();
                command.Connection = (SqlConnection)conectionDatabase;
                string selectScopeCommand = @"SELECT SCOPE_IDENTITY();";

                command.CommandText = sqlCommand + selectScopeCommand;

                command.Parameters.AddWithValue("Id", entity.Id);
                command.Parameters.AddWithValue("Name", entity.Name);
                command.Parameters.AddWithValue("Email", entity.Email);
                command.Parameters.AddWithValue("PhoneNumber", entity.PhoneNumber);
                command.Parameters.AddWithValue("BusinessCompany", entity.BusinessCompany);
                command.Parameters.AddWithValue("CompanyPosition", entity.CompanyPosition);
                return command;
            }
            else
            {
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = (SQLiteConnection)conectionDatabase;
                string selectScopeCommand = @"SELECT last_insert_rowid();";

                command.CommandText = sqlCommand + selectScopeCommand;

                command.Parameters.AddWithValue("Id", entity.Id);
                command.Parameters.AddWithValue("Name", entity.Name);
                command.Parameters.AddWithValue("Email", entity.Email);
                command.Parameters.AddWithValue("PhoneNumber", entity.PhoneNumber);
                command.Parameters.AddWithValue("BusinessCompany", entity.BusinessCompany);
                command.Parameters.AddWithValue("CompanyPosition", entity.CompanyPosition);
                return command;
            }
        }

        protected override DbCommand DBSelectEntityCommand(int id, DbConnection conectionDatabase)
        {
            string sqlCommand = @"SELECT 
		            [Id],
		            [Name],
		            [Email],
		            [PhoneNumber],
		            [BusinessCompany],
		            [CompanyPosition]
	            FROM 
					[Contact]
				WHERE
					[Id] = @Id; ";

            if (databaseType == "sql")
            {
                SqlCommand command = new SqlCommand();
                command.Connection = (SqlConnection)conectionDatabase;
                string selectScopeCommand = @"SELECT SCOPE_IDENTITY();";

                command.CommandText = sqlCommand + selectScopeCommand;

                command.Parameters.AddWithValue("Id", id);
                return command;
            }
            else
            {
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = (SQLiteConnection)conectionDatabase;
                string selectScopeCommand = @"SELECT last_insert_rowid();";

                command.CommandText = sqlCommand + selectScopeCommand;

                command.Parameters.AddWithValue("Id", id);
                return command;
            }
        }

        protected override DbCommand DBSelectAllCommand(DbConnection conectionDatabase)
        {
            DbCommand command;

            if (databaseType == "sql")
                command = new SqlCommand();
            else
                command = new SQLiteCommand();

            command.Connection = conectionDatabase;

            string sqlCommand = @"SELECT
		            [Id],
		            [Name],
		            [Email],
		            [PhoneNumber],
		            [BusinessCompany],
		            [CompanyPosition]
	            FROM 
					[Contact]";


            command.CommandText = sqlCommand;

            return command;
        }

        protected override DbCommand DBExistEntityCommand(int id, DbConnection conectionDatabase)
        {
            string sqlCommand = @"SELECT
		            COUNT(*) 
	            FROM 
					[Contact]
				WHERE
					[Id] = @Id;";

            if (databaseType == "sql")
            {
                SqlCommand command = new SqlCommand();
                command.Connection = (SqlConnection)conectionDatabase;

                command.CommandText = sqlCommand;

                command.Parameters.AddWithValue("Id", id);
                return command;
            }
            else
            {
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = (SQLiteConnection)conectionDatabase;

                command.CommandText = sqlCommand;

                command.Parameters.AddWithValue("Id", id);
                return command;
            }
        }

        protected override DbCommand DBDeleteEntityCommand(int id, DbConnection conectionDatabase)
        {

            string sqlCommand = @"DELETE FROM [Contact] WHERE [Id] = @Id";

            if (databaseType == "sql")
            {
                SqlCommand command = new SqlCommand();
                command.Connection = (SqlConnection)conectionDatabase;

                command.CommandText = sqlCommand;

                command.Parameters.AddWithValue("Id", id);
                return command;
            }
            else
            {
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = (SQLiteConnection)conectionDatabase;

                command.CommandText = sqlCommand;

                command.Parameters.AddWithValue("Id", id);
                return command;
            }
        }

        protected override DbCommand DBDeleteAllCommand(DbConnection conectionDatabase)
        {
            DbCommand command;

            if (databaseType == "sql")
                command = new SqlCommand();
            else
                command = new SQLiteCommand();

            command.Connection = conectionDatabase;

            string sqlCommand = @"DELETE FROM Contact";

            command.CommandText = sqlCommand;
            return command;
        }
    }
}
