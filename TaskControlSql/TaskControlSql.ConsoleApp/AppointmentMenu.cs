using System;
using System.Collections.Generic;
using System.Linq;
using TaskControlSql.Control;
using TaskControlSql.Domain;

namespace TaskControlSql.ConsoleApp
{
    class AppointmentMenu : RegistrationMenu<Appointment>
    {
        ContactController contactController;

        public AppointmentMenu(AppointmentController appoitmentController, ContactController contactController, ConsoleColor fontColor)
        {
            this.mainController = appoitmentController;
            this.contactController = contactController;
            MenuTypeTitle = "appointment";
            this.fontColor = fontColor;
        }

        protected override Appointment UserInputToEntity(int id)
        {
            Console.WriteLine(" - Enter id of the appoitment's contact <0 for null>");
            string idContactTxt = Console.ReadLine();

            if (!int.TryParse(idContactTxt, out int idContact))
                throw new ArgumentException("Attribute id must a valid integer.");
            if (!contactController.ExistEntity(idContact))
                throw new ArgumentException("Entity id does not exist.");

            Contact contact = null;
            if (idContact != 0)
                contact = contactController.ReceiveEntity(idContact);

            Console.WriteLine(" - Enter the subject of appoiment's meeting:");
            string meetingSubject = Console.ReadLine();

            Console.WriteLine(" - Is the appoiment's meeting remote? <Y,N>");
            string isRemoteMeetingTxt = Console.ReadLine().ToUpper();

            bool isRemoteMeeting;
            if (isRemoteMeetingTxt.Equals("Y"))
                isRemoteMeeting = true;
            else if (isRemoteMeetingTxt.Equals("N"))
                isRemoteMeeting = false;
            else
                throw new ArgumentException("Use the only available Y or N for isRemoteMeeting.");


            Console.WriteLine(" - Enter the place/link of the appoiment's meeting:");
            string meetingPlace = Console.ReadLine();

            Console.WriteLine(" - Enter the date of appoiment:");
            string meetingDateTxt = Console.ReadLine();
            if (!meetingDateTxt.Contains("/") || !DateTime.TryParse(meetingDateTxt, out DateTime meetingDate))
                throw new ArgumentException("Attribute meetingDate must a valid DateTime date.");

            Console.WriteLine(" - Enter the starting time of the appoiment:");
            string startTimeTxt = Console.ReadLine();
            if (!startTimeTxt.Contains(":") || !DateTime.TryParse(startTimeTxt, out DateTime startTime))
                throw new ArgumentException("Attribute meetingDate must a valid DateTime hours and minutes.");

            startTime = meetingDate.AddMinutes(startTime.Hour + startTime.Minute);

            Console.WriteLine(" - Enter the ending time of the appoiment:");
            string endTimeTxt = Console.ReadLine();
            if (!endTimeTxt.Contains(":") || !DateTime.TryParse(endTimeTxt, out DateTime endTime))
                throw new ArgumentException("Attribute meetingDate must a valid DateTime hours and minutes.");

            endTime = meetingDate.AddMinutes(endTime.Hour + endTime.Minute);

            Appointment appointment = new Appointment(id, contact, meetingSubject, isRemoteMeeting, meetingPlace, meetingDate, startTime, endTime);
            return appointment;
        }

        protected override List<Appointment> OrderList(List<Appointment> EntityList)
        {
            return EntityList.OrderBy(x => x.EndTime <= DateTime.Now).ToList();
        }
    }
}
