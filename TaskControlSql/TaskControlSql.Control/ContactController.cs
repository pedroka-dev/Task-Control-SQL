using System;
using System.Collections.Generic;
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

        protected override List<DbParameter> ReceiveEntityParameters(Contact entity,DbCommand command)
        {
            List<DbParameter> parameters = new List<DbParameter>(); 

            DbParameter nameParam = command.CreateParameter();
            nameParam.ParameterName = "Name";
            nameParam.Value = entity.Name;
            parameters.Add(nameParam);

            DbParameter emailParam = command.CreateParameter();
            emailParam.ParameterName = "Email";
            emailParam.Value = entity.Email;
            parameters.Add(emailParam);

            DbParameter phoneNumberParam = command.CreateParameter();
            phoneNumberParam.ParameterName = "PhoneNumber";
            phoneNumberParam.Value = entity.PhoneNumber;
            parameters.Add(phoneNumberParam);

            DbParameter businessCompanyParam = command.CreateParameter();
            businessCompanyParam.ParameterName = "BusinessCompany";
            businessCompanyParam.Value = entity.BusinessCompany;
            parameters.Add(businessCompanyParam);

            DbParameter companyPositionParam = command.CreateParameter();
            companyPositionParam.ParameterName = "CompanyPosition";
            companyPositionParam.Value = entity.CompanyPosition;
            parameters.Add(companyPositionParam);

            return parameters;
        }

        protected override string SqlInsertCommand()
        {
            return @"INSERT INTO 
                        [Contact]
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
        }

        protected override string SqlUpdateCommand()
        {
            return @"UPDATE 
                        [Contact] 
				    SET
		                [Name] = @Name,
		                [Email] = @Email,
		                [PhoneNumber] = @PhoneNumber,
		                [BusinessCompany] = @BusinessCompany,
		                [CompanyPosition] = @CompanyPosition

				    WHERE [Id] = @Id;";
        }

        protected override string SqlSelectEntityCommand()
        {
            return @"SELECT 
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
        }

        protected override string SqlSelectAllCommand()
        {
            return @"SELECT
		                [Id],
		                [Name],
		                [Email],
		                [PhoneNumber],
		                [BusinessCompany],
		                [CompanyPosition]
	             FROM 
					    [Contact]";
        }

        protected override string SqlExistEntityCommand()
        {
            return @"SELECT
		                COUNT(*) 
	                FROM 
					    [Contact]
				    WHERE
					    [Id] = @Id;";
        }

        protected override string SqlDeleteEntityCommand()
        {
            return @"DELETE FROM [Contact] WHERE [Id] = @Id";
        }

        protected override string SqlDeleteAllCommand()
        {
            return @"DELETE FROM [Contact]";
        }
    }
}
