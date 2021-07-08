using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskControlSql.Control;
using TaskControlSql.Domain;

namespace TaskControlSql.UnitTest
{
    [TestClass]
    public class AppointmentControllerTest
    {
        ContactController contactController;
        AppointmentController appointmentController;
        public AppointmentControllerTest()
        {
            contactController = new ContactController();
            appointmentController = new AppointmentController(contactController);
            appointmentController.DeleteAllEntities();
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnInsertAppoitment()
        {
            int correctId = 0;
            Contact correctContact = new Contact(0, "José", "jose@jose.com.jose", "495959195295", "josé e co. ltda.", "josé senior");
            string correctMeetingSubject = "Business negocioations";
            bool correctIsRemoteMeeting = false;
            string correctMeetingPlace = "http:/meet.google.com/";
            DateTime correctMeetingDate = DateTime.Today;
            DateTime correctStartTime = DateTime.Today.AddHours(2);
            DateTime correctEndTime = DateTime.Today.AddHours(4);

            contactController.CreateEntity(correctContact);
            Appointment appointment = new Appointment(correctId, correctContact, correctMeetingSubject, correctIsRemoteMeeting, correctMeetingPlace, correctMeetingDate, correctStartTime, correctEndTime);
            string response = appointmentController.CreateEntity(appointment);

            response.Should().Be("OP_SUCCESS");
            appointmentController.ReceiveEntity(appointment.Id).Should().Be(appointment);
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnInsertAppoitmentWithoutContact()
        {
            int correctId = 0;
            string correctMeetingSubject = "Business negocioations";
            bool correctIsRemoteMeeting = false;
            string correctMeetingPlace = "http:/meet.google.com/";
            DateTime correctMeetingDate = DateTime.Today;
            DateTime correctStartTime = DateTime.Today.AddHours(2);
            DateTime correctEndTime = DateTime.Today.AddHours(4);

            Appointment appointment = new Appointment(correctId, null, correctMeetingSubject, correctIsRemoteMeeting, correctMeetingPlace, correctMeetingDate, correctStartTime, correctEndTime);
            string response = appointmentController.CreateEntity(appointment);

            response.Should().Be("OP_SUCCESS");
            appointmentController.ReceiveEntity(appointment.Id).Should().Be(appointment);
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnInsertMultipleAppointments()
        {
            int correctId = 0;
            Contact correctContact = new Contact(0, "José", "jose@jose.com.jose", "495959195295", "josé e co. ltda.", "josé senior");
            string correctMeetingSubject = "Business negocioations";
            bool correctIsRemoteMeeting = false;
            string correctMeetingPlace = "http:/meet.google.com/";
            DateTime correctMeetingDate = DateTime.Today;
            DateTime correctStartTime = DateTime.Today.AddHours(2);
            DateTime correctEndTime = DateTime.Today.AddHours(4);

            contactController.CreateEntity(correctContact);
            Appointment appointment1 = new Appointment(correctId, correctContact, correctMeetingSubject, correctIsRemoteMeeting, correctMeetingPlace, correctMeetingDate, correctStartTime, correctEndTime);
            Appointment appointment2 = new Appointment(correctId, correctContact, correctMeetingSubject, correctIsRemoteMeeting, correctMeetingPlace, correctMeetingDate, correctStartTime, correctEndTime);
            Appointment appointment3 = new Appointment(correctId, correctContact, correctMeetingSubject, correctIsRemoteMeeting, correctMeetingPlace, correctMeetingDate, correctStartTime, correctEndTime);
            string response1 = appointmentController.CreateEntity(appointment1);
            string response2 = appointmentController.CreateEntity(appointment2);
            string response3 = appointmentController.CreateEntity(appointment3);

            response1.Should().Be("OP_SUCCESS");
            appointmentController.ReceiveEntity(appointment1.Id).Should().Be(appointment1);
            response2.Should().Be("OP_SUCCESS");
            appointmentController.ReceiveEntity(appointment2.Id).Should().Be(appointment2);
            response3.Should().Be("OP_SUCCESS");
            appointmentController.ReceiveEntity(appointment3.Id).Should().Be(appointment3);
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnUpdateAppointment()
        {
            int correctId = 0;
            Contact correctContact = new Contact(0, "José", "jose@jose.com.jose", "495959195295", "josé e co. ltda.", "josé senior");
            string correctMeetingSubject = "Business negocioations";
            bool correctIsRemoteMeeting = false;
            string correctMeetingPlace = "http:/meet.google.com/";
            DateTime correctMeetingDate = DateTime.Today;
            DateTime correctStartTime = DateTime.Today.AddHours(2);
            DateTime correctEndTime = DateTime.Today.AddHours(4);
            string newMeetingSubject = "Talking for fun";
            string newMeetingPlace = "That building over there";
            bool newIsRemoteMeeting = true;

            contactController.CreateEntity(correctContact);
            Appointment appointment = new Appointment(correctId, correctContact, correctMeetingSubject, correctIsRemoteMeeting, correctMeetingPlace, correctMeetingDate, correctStartTime, correctEndTime);
            appointmentController.CreateEntity(appointment);
            Appointment updatedAppointment = new Appointment(correctId, correctContact, newMeetingSubject, newIsRemoteMeeting, newMeetingPlace, correctMeetingDate, correctStartTime, correctEndTime);
            updatedAppointment.Id = appointment.Id;
            string response = appointmentController.UpdateEntity(updatedAppointment);

            response.Should().Be("OP_SUCCESS");
            appointmentController.ReceiveEntity(updatedAppointment.Id).Should().Be(updatedAppointment);
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnUpdateAppointmentWithoutContact()
        {
            int correctId = 0;
            Contact correctContact = new Contact(0, "José", "jose@jose.com.jose", "495959195295", "josé e co. ltda.", "josé senior");
            string correctMeetingSubject = "Business negocioations";
            bool correctIsRemoteMeeting = false;
            string correctMeetingPlace = "http:/meet.google.com/";
            DateTime correctMeetingDate = DateTime.Today;
            DateTime correctStartTime = DateTime.Today.AddHours(2);
            DateTime correctEndTime = DateTime.Today.AddHours(4);
            string newMeetingSubject = "Talking for fun";
            string newMeetingPlace = "That building over there";
            bool newIsRemoteMeeting = true;

            contactController.CreateEntity(correctContact);
            Appointment appointment = new Appointment(correctId, correctContact, correctMeetingSubject, correctIsRemoteMeeting, correctMeetingPlace, correctMeetingDate, correctStartTime, correctEndTime);
            appointmentController.CreateEntity(appointment);
            Appointment updatedAppointment = new Appointment(correctId, null, newMeetingSubject, newIsRemoteMeeting, newMeetingPlace, correctMeetingDate, correctStartTime, correctEndTime);
            updatedAppointment.Id = appointment.Id;
            string response = appointmentController.UpdateEntity(updatedAppointment);

            response.Should().Be("OP_SUCCESS");
            appointmentController.ReceiveEntity(updatedAppointment.Id).Should().Be(updatedAppointment);
        }

        [TestMethod]
        public void Should_ReturnFalse_OnExistEntityWithoutTodoTask()
        {
            int correctId = 0;
            Contact correctContact = new Contact(0, "José", "jose@jose.com.jose", "495959195295", "josé e co. ltda.", "josé senior");
            string correctMeetingSubject = "Business negocioations";
            bool correctIsRemoteMeeting = false;
            string correctMeetingPlace = "http:/meet.google.com/";
            DateTime correctMeetingDate = DateTime.Today;
            DateTime correctStartTime = DateTime.Today.AddHours(2);
            DateTime correctEndTime = DateTime.Today.AddHours(4);

            contactController.CreateEntity(correctContact);
            Appointment appointment = new Appointment(correctId, correctContact, correctMeetingSubject, correctIsRemoteMeeting, correctMeetingPlace, correctMeetingDate, correctStartTime, correctEndTime);

            appointmentController.ExistEntity(appointment.Id).Should().BeFalse();
        }

        [TestMethod]
        public void Should_ReturnTrue_OnExistEntityWithOneAppointment()
        {
            int correctId = 0;
            Contact correctContact = new Contact(0, "José", "jose@jose.com.jose", "495959195295", "josé e co. ltda.", "josé senior");
            string correctMeetingSubject = "Business negocioations";
            bool correctIsRemoteMeeting = false;
            string correctMeetingPlace = "http:/meet.google.com/";
            DateTime correctMeetingDate = DateTime.Today;
            DateTime correctStartTime = DateTime.Today.AddHours(2);
            DateTime correctEndTime = DateTime.Today.AddHours(4);

            contactController.CreateEntity(correctContact);
            Appointment appointment = new Appointment(correctId, correctContact, correctMeetingSubject, correctIsRemoteMeeting, correctMeetingPlace, correctMeetingDate, correctStartTime, correctEndTime);
            appointmentController.CreateEntity(appointment);

            appointmentController.ExistEntity(appointment.Id).Should().BeTrue();
        }

        [TestMethod]
        public void Should_ReturnTrue_OnExistEntityWithMultipleAppointments()
        {
            int correctId = 0;
            Contact correctContact = new Contact(0, "José", "jose@jose.com.jose", "495959195295", "josé e co. ltda.", "josé senior");
            string correctMeetingSubject = "Business negocioations";
            bool correctIsRemoteMeeting = false;
            string correctMeetingPlace = "http:/meet.google.com/";
            DateTime correctMeetingDate = DateTime.Today;
            DateTime correctStartTime = DateTime.Today.AddHours(2);
            DateTime correctEndTime = DateTime.Today.AddHours(4);

            contactController.CreateEntity(correctContact);
            Appointment appointment1 = new Appointment(correctId, correctContact, correctMeetingSubject, correctIsRemoteMeeting, correctMeetingPlace, correctMeetingDate, correctStartTime, correctEndTime);
            Appointment appointment2 = new Appointment(correctId, correctContact, correctMeetingSubject, correctIsRemoteMeeting, correctMeetingPlace, correctMeetingDate, correctStartTime, correctEndTime);
            Appointment appointment3 = new Appointment(correctId, correctContact, correctMeetingSubject, correctIsRemoteMeeting, correctMeetingPlace, correctMeetingDate, correctStartTime, correctEndTime);
            appointmentController.CreateEntity(appointment1);
            appointmentController.CreateEntity(appointment2);
            appointmentController.CreateEntity(appointment3);

            appointmentController.ExistEntity(appointment1.Id).Should().BeTrue();
            appointmentController.ExistEntity(appointment2.Id).Should().BeTrue();
            appointmentController.ExistEntity(appointment3.Id).Should().BeTrue();
        }
    }
}
