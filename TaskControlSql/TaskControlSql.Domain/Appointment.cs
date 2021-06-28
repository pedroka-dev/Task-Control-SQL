using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskControlSql.ConsoleApp.Domain
{
    public class Appointment : Entity
    {
        private string contactName = " ";
        private Contact contact;
        private string meetingSubject;
        private bool isRemoteMeeting;
        private string meetingPlace;
        private DateTime meetingDate;
        private DateTime startTime;
        private DateTime endTime;

        public Appointment(int id, Contact contact, string meetingSubject, bool isRemoteMeeting, string meetingPlace, DateTime meetingDate, DateTime startTime, DateTime endTime)
        {
            if (id < 0)
                throw new ArgumentException("Attribute 'id' cannot be a number smaller than 0.");

            this.id = id;
            this.contact = contact;
            this.meetingSubject = meetingSubject;
            this.isRemoteMeeting = isRemoteMeeting;
            this.meetingPlace = meetingPlace;
            this.meetingDate = meetingDate;
            this.startTime = startTime;
            this.endTime = endTime;

            if (contact != null)
                contactName = contact.Name;
        }

        public Contact Contact { get => contact; }
        public string MeetingSubject { get => meetingSubject;}
        public bool IsRemoteMeeting { get => isRemoteMeeting; }
        public string MeetingPlace { get => meetingPlace;}
        public DateTime MeetingDate { get => meetingDate;}
        public DateTime StartTime { get => startTime;}
        public DateTime EndTime { get => endTime;}

        public override string ToString()
        {
            return $"Appointment [ id='{id}, contact = {contactName}, meetingSubject = {meetingSubject}, meetingPlace = {meetingPlace}, meetingDate = {meetingDate}, startTime = {startTime}, endTime = {endTime} ]";
        }
    }
}
