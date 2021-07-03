using System;
using System.Collections.Generic;

namespace TaskControlSql.Domain
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
        public string MeetingSubject { get => meetingSubject; }
        public bool IsRemoteMeeting { get => isRemoteMeeting; }
        public string MeetingPlace { get => meetingPlace; }
        public DateTime MeetingDate { get => meetingDate; }
        public DateTime StartTime { get => startTime; }
        public DateTime EndTime { get => endTime; }

        public override bool Equals(object obj)
        {
            return obj is Appointment appointment &&
                   id == appointment.id &&
                   contactName == appointment.contactName &&
                   EqualityComparer<Contact>.Default.Equals(contact, appointment.contact) &&
                   meetingSubject == appointment.meetingSubject &&
                   isRemoteMeeting == appointment.isRemoteMeeting &&
                   meetingPlace == appointment.meetingPlace &&
                   meetingDate == appointment.meetingDate &&
                   startTime == appointment.startTime &&
                   endTime == appointment.endTime &&
                   EqualityComparer<Contact>.Default.Equals(Contact, appointment.Contact);
        }

        public override int GetHashCode()
        {
            int hashCode = 1021881164;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(contactName);
            hashCode = hashCode * -1521134295 + EqualityComparer<Contact>.Default.GetHashCode(contact);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(meetingSubject);
            hashCode = hashCode * -1521134295 + isRemoteMeeting.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(meetingPlace);
            hashCode = hashCode * -1521134295 + meetingDate.GetHashCode();
            hashCode = hashCode * -1521134295 + startTime.GetHashCode();
            hashCode = hashCode * -1521134295 + endTime.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Contact>.Default.GetHashCode(Contact);
            return hashCode;
        }

        public override string ToString()
        {
            return $"Appointment [ id='{id}', contact = '{contactName}', meetingSubject = '{meetingSubject}', meetingPlace = '{meetingPlace}', meetingDate = '{meetingDate}', startTime = '{startTime}', endTime = '{endTime}' ]";
        }
    }
}
