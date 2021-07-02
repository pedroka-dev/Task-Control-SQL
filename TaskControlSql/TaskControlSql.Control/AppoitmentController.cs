using System;
using System.Data;
using System.Data.SqlClient;
using TaskControlSql.Domain;

namespace TaskControlSql.Control
{
    public class AppoitmentController : Controller<Appointment>
    {
        public ContactController contactController;

        public AppoitmentController(ContactController contactController)
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
        protected override SqlCommand SqlInsertCommand(Appointment entity, SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = conectionDatabase
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

        protected override SqlCommand SqlUpdateCommand(Appointment entity, SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = conectionDatabase
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

        protected override SqlCommand SqlSelectEntityCommand(int id, SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = conectionDatabase
            };

            string sqlCommand = @"SELECT
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
					[Id] = @Id";

            sqlCommand += @"SELECT SCOPE_IDENTITY();";

            command.CommandText = sqlCommand;

            command.Parameters.AddWithValue("Id", id);
            return command;
        }

        protected override SqlCommand SqlSelectAllCommand(SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = conectionDatabase
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

        protected override SqlCommand SqlExistEntityCommand(int id, SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = conectionDatabase
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

        protected override SqlCommand SqlDeleteEntityCommand(int id, SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = conectionDatabase
            };

            string sqlCommand = @"DELETE FROM [Appointment] WHERE [Id] = @Id";

            command.CommandText = sqlCommand;

            command.Parameters.AddWithValue("Id", id);
            return command;
        }

        protected override SqlCommand SqlDeleteAllCommand(SqlConnection conectionDatabase)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = conectionDatabase
            };

            string sqlCommand = @"DELETE FROM Appointment";

            command.CommandText = sqlCommand;
            return command;
        }
    }
}
