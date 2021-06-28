using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskControlSql.ConsoleApp.Control;
using TaskControlSql.ConsoleApp.Domain;

namespace TaskControlSql.ConsoleApp.View
{
    class AppointmentMenu : RegistrationMenu<Appointment>
    {
        ContactController contactController;

        public AppointmentMenu(AppoitmentController appoitmentController, ContactController contactController, ConsoleColor fontColor)
        {
            this.mainController = appoitmentController;
            this.contactController = contactController;
            MenuTypeTitle = "appointment";
            this.fontColor = fontColor;
        }

        public override void RegisterElement()
        {
            DisplayerHeader("REGISTER "+ MenuTypeTitle.ToUpper());

            Console.WriteLine(" - Enter id of the appoitment's contact <0 for null>");
            string idContactTxt = Console.ReadLine();

            if (!int.TryParse(idContactTxt, out int idContact))
            {
                DisplayErrorText("Attribute id must a valid integer.");
                return;
            }
            if (!contactController.ExistEntity(idContact))
            {
                DisplayErrorText("Entity id does not exist.");
                return;
            }

            Contact contact = null;
            if(idContact != 0)
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
            {
                DisplayErrorText("Use the only available Y or N for isRemoteMeeting.");
                return;
            }

            Console.WriteLine(" - Enter the place/link of the appoiment's meeting:");
            string meetingPlace = Console.ReadLine();

            Console.WriteLine(" - Enter the date of appoiment:");
            string meetingDateTxt = Console.ReadLine();
            if (!meetingDateTxt.Contains("/") || !DateTime.TryParse(meetingDateTxt, out DateTime meetingDate))
            {
                DisplayErrorText("Attribute meetingDate must a valid DateTime date.");
                return;
            }

            Console.WriteLine(" - Enter the starting time of the appoiment:");
            string startTimeTxt = Console.ReadLine();
            if (!startTimeTxt.Contains(":") ||  !DateTime.TryParse(startTimeTxt, out DateTime startTime))
            {
                DisplayErrorText("Attribute meetingDate must a valid DateTime hours and minutes.");
                return;
            }
            startTime = meetingDate.AddMinutes(startTime.Hour+startTime.Minute);

            Console.WriteLine(" - Enter the ending time of the appoiment:");
            string endTimeTxt = Console.ReadLine();
            if (!endTimeTxt.Contains(":") || !DateTime.TryParse(endTimeTxt, out DateTime endTime))
            {
                DisplayErrorText("Attribute meetingDate must a valid DateTime hours and minutes.");
                return;
            }
            endTime = meetingDate.AddMinutes(endTime.Hour + endTime.Minute);

            Appointment appointment;

            try
            {
                appointment = new Appointment(0, contact, meetingSubject, isRemoteMeeting, meetingPlace, meetingDate, startTime, endTime);
            }
            catch (Exception e)
            {
                DisplayErrorText("Error: " + e.Message);
                return;
            }
            string response = mainController.CreateEntity(appointment);

            if (response != "OP_SUCCESS")
                DisplayErrorText(response);
            else
            {
                DisplaySuccessText("Register Operation Sucessful.");
                Console.ReadLine();
                return;
            }
        }

        public override void ModifyElement()
        {
            VisualizeAllElements();
            DisplayerHeader("MODIFY " + MenuTypeTitle.ToUpper());

            Console.WriteLine(" - Enter id of the task to Modify.");
            string idTxt = Console.ReadLine();

            if (!int.TryParse(idTxt, out int id))
            {
                DisplayErrorText("Attribute id must a valid integer.");
                return;
            }
            if (!mainController.ExistEntity(id))
            {
                DisplayErrorText("Entity id does not exist.");
                return;
            }

            Console.WriteLine(" - Enter id of the appoitment's contact <0 for null>");
            string idContactTxt = Console.ReadLine();

            if (!int.TryParse(idContactTxt, out int idContact))
            {
                DisplayErrorText("Attribute id must a valid integer.");
                return;
            }
            if (!contactController.ExistEntity(idContact))
            {
                DisplayErrorText("Entity id does not exist.");
                return;
            }

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
            {
                DisplayErrorText("Use the only available Y or N for isRemoteMeeting.");
                return;
            }

            Console.WriteLine(" - Enter the place/link of the appoiment's meeting:");
            string meetingPlace = Console.ReadLine();

            Console.WriteLine(" - Enter the date of appoiment:");
            string meetingDateTxt = Console.ReadLine();
            if (!DateTime.TryParse(meetingDateTxt, out DateTime meetingDate))
            {
                DisplayErrorText("Attribute meetingDate must a valid DateTime.");
                return;
            }

            Console.WriteLine(" - Enter the starting time of the appoiment:");
            string startTimeTxt = Console.ReadLine();

            if (!DateTime.TryParse(startTimeTxt, out DateTime startTime))
            {
                DisplayErrorText("Attribute meetingDate must a valid DateTime.");
                return;
            }

            Console.WriteLine(" - Enter the ending time of the appoiment:");
            string endTimeTxt = Console.ReadLine();

            if (!DateTime.TryParse(endTimeTxt, out DateTime endTime))
            {
                DisplayErrorText("Attribute meetingDate must a valid DateTime.");
                return;
            }

            Appointment appointment;

            try
            {
                appointment = new Appointment(id, contact, meetingSubject, isRemoteMeeting, meetingPlace, meetingDate, startTime, endTime);
            }
            catch (Exception e)
            {
                DisplayErrorText("Error: " + e.Message);
                return;
            }

            string response = mainController.UpdateEntity(appointment);

            if (response != "OP_SUCCESS")
                DisplayErrorText(response);
            else
            {
                DisplaySuccessText("Modify Operation Sucessful");
                Console.ReadLine();
                return;
            }
        }

        protected override List<Appointment> OrderList(List<Appointment> EntityList)
        {
            return EntityList.OrderBy(x => x.EndTime <= DateTime.Now).ToList();
        }
    }
}
