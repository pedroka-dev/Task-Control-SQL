using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TaskControlSql.Control;
using TaskControlSql.Domain;

namespace TaskControlSql.View
{
    public partial class EditAppointmentScreen : Form
    {
        AppointmentController mainController;
        int entityId;

        public EditAppointmentScreen(Appointment appointment, AppointmentController mainController)
        {
            this.mainController = mainController;
            this.entityId = appointment.Id;
            InitializeComponent();
            List<Contact> contacts = mainController.contactController.ReceiveAllEntities();

            foreach(Contact item in contacts)
            {
                cmbContact.Items.Add(item.Id);
            }

            this.Text += " - Id : " + entityId;
            this.txtMeetingSubject.Text = appointment.MeetingSubject;
            this.chkIsRemoteMeeting.Checked = appointment.IsRemoteMeeting;
            this.txtMeetingPlace.Text = appointment.MeetingPlace;
            this.dateMeetingDate.Value = appointment.MeetingDate;
            this.dateStartTime.Value = appointment.StartTime;
            this.dateEndTime.Value = appointment.EndTime;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save the edited Appointment?", "Confirmation needed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                
                Contact contact = null;
                if (cmbContact.SelectedItem != null)
                    contact = mainController.contactController.ReceiveEntity(int.Parse(cmbContact.SelectedItem.ToString()));
                string meetingSubject = txtMeetingSubject.Text;
                bool isRemoteMeeting = chkIsRemoteMeeting.Checked;
                string meetingPlace = txtMeetingPlace.Text;
                DateTime meetingDate = dateMeetingDate.Value.Date;
                DateTime startTimeAux = dateStartTime.Value;
                DateTime endTimeAux = dateEndTime.Value;

                DateTime startTime = meetingDate.AddMinutes(startTimeAux.Hour + startTimeAux.Minute);       //not returning the hours yet
                DateTime endTime = meetingDate.AddMinutes(endTimeAux.Hour + endTimeAux.Minute);             //not returning the hours yet

                Appointment appointment = new Appointment(entityId, contact, meetingSubject, isRemoteMeeting, meetingPlace, meetingDate, startTime, endTime);

                string operationMessage = mainController.UpdateEntity(appointment);
                if (string.Equals("OP_SUCCESS", operationMessage))
                    MessageBox.Show("Sucessfully edited Appointment.", "Operation Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Error: \n" + operationMessage, "Operation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.Dispose();
            }
        }
    }
}