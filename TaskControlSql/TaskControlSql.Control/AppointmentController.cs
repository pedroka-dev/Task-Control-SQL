using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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

        protected override List<DbParameter> ReceiveEntityParameters(Appointment entity, DbCommand command)
        {
            List<DbParameter> parameters = new List<DbParameter>();

            DbParameter idContactParam = command.CreateParameter();
            object idContactValue = DBNull.Value;
            if (entity.Contact != null)
                idContactValue = entity.Contact.Id;
            idContactParam.ParameterName = "Id_Contact";
            idContactParam.Value = idContactValue;
            parameters.Add(idContactParam);

            DbParameter meetingSubjectParam = command.CreateParameter();
            meetingSubjectParam.ParameterName = "MeetingSubject";
            meetingSubjectParam.Value = entity.MeetingSubject;
            parameters.Add(meetingSubjectParam);

            DbParameter isRemoteMeeting = command.CreateParameter();
            isRemoteMeeting.ParameterName = "IsRemoteMeeting";
            isRemoteMeeting.Value = entity.IsRemoteMeeting;
            parameters.Add(isRemoteMeeting);

            DbParameter meetingPlaceParam = command.CreateParameter();
            meetingPlaceParam.ParameterName = "MeetingPlace";
            meetingPlaceParam.Value = entity.MeetingPlace;
            parameters.Add(meetingPlaceParam);

            DbParameter meetingDateParam = command.CreateParameter();
            meetingDateParam.ParameterName = "MeetingDate";
            meetingDateParam.Value = entity.MeetingDate;
            parameters.Add(meetingDateParam);

            DbParameter StartTimeParam = command.CreateParameter();
            StartTimeParam.ParameterName = "StartTime";
            StartTimeParam.Value = entity.StartTime;
            parameters.Add(StartTimeParam);

            DbParameter endTimeParam = command.CreateParameter();
            endTimeParam.ParameterName = "EndTime";
            endTimeParam.Value = entity.EndTime;
            parameters.Add(endTimeParam);

            return parameters;
        }

        protected override string SqlInsertCommand()
        {
            return @"INSERT INTO [Appointment]
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
        }

        protected override string SqlUpdateCommand()
        {
            return @"UPDATE [Appointment] 
				SET
		            [Id_Contact] = @Id_Contact,
		            [MeetingSubject] = @MeetingSubject,
		            [IsRemoteMeeting] = @IsRemoteMeeting,
		            [MeetingPlace] = @MeetingPlace,
		            [MeetingDate] = @MeetingDate,
                    [StartTime] = @StartTime,
		            [EndTime] = @EndTime

				WHERE [Id] = @Id;";
        }

        protected override string SqlSelectEntityCommand()
        {
            return @"SELECT
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
        }

        protected override string SqlSelectAllCommand()
        {
            return @"SELECT
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
        }

        protected override string SqlExistEntityCommand()
        {
            return @"SELECT
		            COUNT(*) 
	            FROM 
					[Appointment]
				WHERE
					[Id] = @Id;";
        }

        protected override string SqlDeleteEntityCommand()
        {
            return @"DELETE FROM [Appointment] WHERE [Id] = @Id";
        }

        protected override string SqlDeleteAllCommand()
        {
            return @"DELETE FROM [Appointment]";
        }
    }
}
