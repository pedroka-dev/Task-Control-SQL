using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using TaskControlSql.Domain;

namespace TaskControlSql.Control
{
    public class AppointmentController : Controller<Appointment>
    {
        public ContactController contactController;

        public AppointmentController(ContactController contactController)
        {
            this.contactController = contactController;
        }

        protected override Appointment ConvertToEntity(IDataReader reader)
        {
            int Id = Convert.ToInt32(reader["Id"]);
            Contact Contact = null;
            object Id_Contact = reader["Id_Contact"];
            if (Id_Contact != DBNull.Value)
                Contact = contactController.ReceiveEntity((int)Id_Contact);
            string MeetingSubject = Convert.ToString(reader["MeetingSubject"]);
            bool IsRemoteMeeting = Convert.ToBoolean(reader["IsRemoteMeeting"]);
            string MeetingPlace = Convert.ToString(reader["MeetingPlace"]);
            DateTime MeetingDate = DateTime.Parse(Convert.ToString(reader["MeetingDate"]));
            DateTime StartTime = DateTime.Parse(Convert.ToString(reader["StartTime"]));
            DateTime EndTime = DateTime.Parse(Convert.ToString(reader["EndTime"]));

            Appointment appointment = new Appointment(Id, Contact, MeetingSubject, IsRemoteMeeting, MeetingPlace, MeetingDate, StartTime, EndTime);
            return appointment;
        }
        protected override DbCommand ExecuteDBInsert(Appointment entity, DbConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = (SqlConnection)conectionDatabase
            };

            string sqlCommand = @"INSERT INTO [Appointment]
	            (
		            [Id_Contact],
		            [MeetingSubject],
		            [IsRemoteMeeting],
		            [MeetingPlace],
		            [MeetingDate],
                    [StartTime],
		            [EndTime]
	            )
	            VALUES
	            (
		            @Id_Contact,
		            @MeetingSubject,
		            @IsRemoteMeeting,
		            @MeetingPlace,
		            @MeetingDate,
                    @StartTime,
		            @EndTime 
	             );";

            sqlCommand += @"SELECT SCOPE_IDENTITY();";

            command.CommandText = sqlCommand;

            if (entity.Contact == null)
                command.Parameters.AddWithValue("Id_Contact", DBNull.Value);
            else
                command.Parameters.AddWithValue("Id_Contact", entity.Contact.Id);
            command.Parameters.AddWithValue("MeetingSubject", entity.MeetingSubject);
            command.Parameters.AddWithValue("IsRemoteMeeting", entity.IsRemoteMeeting);
            command.Parameters.AddWithValue("MeetingPlace", entity.MeetingPlace);
            command.Parameters.AddWithValue("MeetingDate", entity.MeetingDate);
            command.Parameters.AddWithValue("StartTime", entity.StartTime);
            command.Parameters.AddWithValue("EndTime", entity.EndTime);

            return command;
        }

        protected override DbCommand ExecuteDBUpdate(Appointment entity, DbConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = (SqlConnection)conectionDatabase
            };

            string sqlCommand = @"UPDATE [Appointment] 
				SET
		            [Id_Contact] = @Id_Contact,
		            [MeetingSubject] = @MeetingSubject,
		            [IsRemoteMeeting] = @IsRemoteMeeting,
		            [MeetingPlace] = @MeetingPlace,
		            [MeetingDate] = @MeetingDate,
                    [StartTime] = @StartTime,
		            [EndTime] = @EndTime

				WHERE [Id] = @Id;";

            sqlCommand += @"SELECT SCOPE_IDENTITY();";

            command.CommandText = sqlCommand;

            if (entity.Contact == null)
                command.Parameters.AddWithValue("Id_Contact", DBNull.Value);
            else
                command.Parameters.AddWithValue("Id_Contact", entity.Contact.Id);
            command.Parameters.AddWithValue("MeetingSubject", entity.MeetingSubject);
            command.Parameters.AddWithValue("IsRemoteMeeting", entity.IsRemoteMeeting);
            command.Parameters.AddWithValue("MeetingPlace", entity.MeetingPlace);
            command.Parameters.AddWithValue("MeetingDate", entity.MeetingDate);
            command.Parameters.AddWithValue("StartTime", entity.StartTime);
            command.Parameters.AddWithValue("EndTime", entity.EndTime);
            command.Parameters.AddWithValue("Id", entity.Id);

            return command;
        }

        protected override DbCommand ExecuteDBSelectEntity(int id, DbConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = (SqlConnection)conectionDatabase
            };

            string sqlCommand = @"SELECT
                    [Id],
		            [Id_Contact],
		            [MeetingSubject],
		            [IsRemoteMeeting],
		            [MeetingPlace],
		            [MeetingDate],
                    [StartTime],
		            [EndTime]
	            FROM 
					[Appointment]
				WHERE
					[Id] = @Id; ";

            sqlCommand += @"SELECT SCOPE_IDENTITY();";

            command.CommandText = sqlCommand;

            command.Parameters.AddWithValue("Id", id);
            return command;
        }

        protected override DbCommand ExecuteDBSelectAll(DbConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = (SqlConnection)conectionDatabase
            };

            string sqlCommand = @"SELECT
                    [Id],
		            [Id_Contact],
		            [MeetingSubject],
		            [IsRemoteMeeting],
		            [MeetingPlace],
		            [MeetingDate],
                    [StartTime],
		            [EndTime]
	            FROM 
					[Appointment]";

            command.CommandText = sqlCommand;

            return command;
        }

        protected override DbCommand ExecuteDBExistEntity(int id, DbConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = (SqlConnection)conectionDatabase
            };

            string sqlCommand = @"SELECT
		            COUNT(*) 
	            FROM 
					[Appointment]
				WHERE
					[Id] = @Id;";

            command.CommandText = sqlCommand;

            command.Parameters.AddWithValue("Id", id);
            return command;
        }

        protected override DbCommand ExecuteDBDeleteEntity(int id, DbConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = (SqlConnection)conectionDatabase
            };

            string sqlCommand = @"DELETE FROM [Appointment] WHERE [Id] = @Id";

            command.CommandText = sqlCommand;

            command.Parameters.AddWithValue("Id", id);
            return command;
        }

        protected override DbCommand ExecuteDBDeleteAll(DbConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = (SqlConnection)conectionDatabase
            };

            string sqlCommand = @"DELETE FROM Appointment";

            command.CommandText = sqlCommand;
            return command;
        }
    }
}
