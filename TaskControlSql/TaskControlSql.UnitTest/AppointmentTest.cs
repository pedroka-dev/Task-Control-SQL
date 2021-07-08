using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskControlSql.Domain;

namespace TaskControlSql.UnitTest
{
    [TestClass]
    public class AppointmentTest
    {
        [TestMethod]
        public void Should_InstantiateAppoitment_Correctly()
        {
            int correctId = 0;
            Contact correctContact = new Contact(0, "José", "jose@jose.com.jose", "495959195295", "josé e co. ltda.", "josé senior");
            string correctMeetingSubject = "Business negocioations";
            bool correctIsRemoteMeeting = false;
            string correctMeetingPlace = "http:/meet.google.com/";
            DateTime correctMeetingDate = DateTime.Today;
            DateTime correctStartTime = DateTime.Today.AddHours(2);
            DateTime correctEndTime = DateTime.Today.AddHours(4);

            Appointment appointment = new Appointment(correctId, correctContact, correctMeetingSubject, correctIsRemoteMeeting, correctMeetingPlace, correctMeetingDate, correctStartTime, correctEndTime);

            appointment.Id.Should().Be(correctId);
            appointment.Contact.Should().Be(correctContact);
            appointment.MeetingSubject.Should().Be(correctMeetingSubject);
            appointment.IsRemoteMeeting.Should().Be(correctIsRemoteMeeting);
            appointment.MeetingPlace.Should().Be(correctMeetingPlace);
            appointment.MeetingDate.Should().Be(correctMeetingDate);
            appointment.StartTime.Should().Be(correctStartTime);
            appointment.EndTime.Should().Be(correctEndTime);
        }

        [TestMethod]
        public void Should_InstantiateAppoitment_WithoutContactCorrectly()
        {
            int correctId = 0;
            string correctMeetingSubject = "Business negocioations";
            bool correctIsRemoteMeeting = false;
            string correctMeetingPlace = "http:/meet.google.com/";
            DateTime correctMeetingDate = DateTime.Today;
            DateTime correctStartTime = DateTime.Today.AddHours(2);
            DateTime correctEndTime = DateTime.Today.AddHours(4);

            Appointment appointment = new Appointment(correctId, null, correctMeetingSubject, correctIsRemoteMeeting, correctMeetingPlace, correctMeetingDate, correctStartTime, correctEndTime);

            appointment.Id.Should().Be(correctId);
            appointment.Contact.Should().BeNull();
            appointment.MeetingSubject.Should().Be(correctMeetingSubject);
            appointment.IsRemoteMeeting.Should().Be(correctIsRemoteMeeting);
            appointment.MeetingPlace.Should().Be(correctMeetingPlace);
            appointment.MeetingDate.Should().Be(correctMeetingDate);
            appointment.StartTime.Should().Be(correctStartTime);
            appointment.EndTime.Should().Be(correctEndTime);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_ThrowArgumentException_IdIsNegativeNumber()
        {
            int correctId = -1;
            Contact correctContact = new Contact(0, "José", "jose@jose.com.jose", "495959195295", "josé e co. ltda.", "josé senior");
            string correctMeetingSubject = "Business negocioations";
            bool correctIsRemoteMeeting = false;
            string correctMeetingPlace = "http:/meet.google.com/";
            DateTime correctMeetingDate = DateTime.Today;
            DateTime correctStartTime = DateTime.Today.AddHours(2);
            DateTime correctEndTime = DateTime.Today.AddHours(4);

            Appointment appointment = new Appointment(correctId, correctContact, correctMeetingSubject, correctIsRemoteMeeting, correctMeetingPlace, correctMeetingDate, correctStartTime, correctEndTime);
        }
    }
}
