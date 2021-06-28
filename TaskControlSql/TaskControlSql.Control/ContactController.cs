using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskControlSql.ConsoleApp.Domain;

namespace TaskControlSql.ConsoleApp.Control
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

        protected override SqlCommand SqlInsertCommand(Contact entity, SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conectionDatabase;

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

            sqlCommand += @"SELECT SCOPE_IDENTITY();";

            command.CommandText = sqlCommand;

            command.Parameters.AddWithValue("Name", entity.Name);
            command.Parameters.AddWithValue("Email", entity.Email);
            command.Parameters.AddWithValue("PhoneNumber", entity.PhoneNumber);
            command.Parameters.AddWithValue("BusinessCompany", entity.BusinessCompany);
            command.Parameters.AddWithValue("CompanyPosition", entity.CompanyPosition);

            return command;
        }

        protected override SqlCommand SqlUpdateCommand(Contact entity, SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conectionDatabase;

            string sqlCommand = @"UPDATE [Contact] 
				SET
		            [Name] = @Name,
		            [Email] = @Email,
		            [PhoneNumber] = @PhoneNumber,
		            [BusinessCompany] = @BusinessCompany,
		            [CompanyPosition] = @CompanyPosition

				WHERE [Id] = @Id;";

            sqlCommand += @"SELECT SCOPE_IDENTITY();";

            command.CommandText = sqlCommand;

            command.Parameters.AddWithValue("Id", entity.Id);
            command.Parameters.AddWithValue("Name", entity.Name);
            command.Parameters.AddWithValue("Email", entity.Email);
            command.Parameters.AddWithValue("PhoneNumber", entity.PhoneNumber);
            command.Parameters.AddWithValue("BusinessCompany", entity.BusinessCompany);
            command.Parameters.AddWithValue("CompanyPosition", entity.CompanyPosition);

            return command;
        }

        protected override SqlCommand SqlSelectEntityCommand(int id, SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conectionDatabase;

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
					[Id] = @Id";

            sqlCommand += @"SELECT SCOPE_IDENTITY();";

            command.CommandText = sqlCommand;

            command.Parameters.AddWithValue("Id", id);
            return command;
        }

        protected override SqlCommand SqlSelectAllCommand(SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand();
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

        protected override SqlCommand SqlExistEntityCommand(int id, SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conectionDatabase;

            string sqlCommand = @"SELECT
		            COUNT(*) 
	            FROM 
					[Contact]
				WHERE
					[Id] = @Id;";

            command.CommandText = sqlCommand;

            command.Parameters.AddWithValue("Id", id);
            return command;
        }

        protected override SqlCommand SqlDeleteEntityCommand(int id, SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conectionDatabase;

            string sqlCommand = @"DELETE FROM [Contact] WHERE [Id] = @Id";

            command.CommandText = sqlCommand;

            command.Parameters.AddWithValue("Id", id);
            return command;
        }

        protected override SqlCommand SqlDeleteAllCommand(SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conectionDatabase;

            string sqlCommand = @"DELETE FROM Contact";

            command.CommandText = sqlCommand;
            return command;
        }
    }
}
