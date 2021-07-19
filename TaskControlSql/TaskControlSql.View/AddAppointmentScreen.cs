using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TaskControlSql.Control;
using TaskControlSql.Domain;

namespace TaskControlSql.View
{
    public partial class AddAppointmentScreen : Form
    {
        AppointmentController mainController;
   

        public AddAppointmentScreen(AppointmentController mainController)
        {
            this.mainController = mainController;
            InitializeComponent();
            List<Contact> contacts = mainController.contactController.ReceiveAllEntities();

            foreach(Contact item in contacts)
            {
                cmbContact.Items.Add(item.Id);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save a new Appointment?", "Confirmation needed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                
                Contact contact = null;
                if (cmbContact.SelectedItem != null)
                    contact = mainController.contactController.ReceiveEntity(int.Parse(cmbContact.SelectedItem.ToString()));
                string meetingSubject = txtMeetingPlace.Text;
                bool isRemoteMeeting = chkIsRemoteMeeting.Checked;
                string meetingPlace = txtMeetingPlace.Text;
                DateTime meetingDate = dateMeetingDate.Value;
                DateTime startTimeAux = dateStartTime.Value;
                DateTime endTimeAux = dateEndTime.Value;

                DateTime startTime = meetingDate.AddMinutes(startTimeAux.Hour + startTimeAux.Minute);
                DateTime endTime = meetingDate.AddMinutes(endTimeAux.Hour + endTimeAux.Minute);

                Appointment appointment = new Appointment(0, contact, meetingSubject, isRemoteMeeting, meetingPlace, meetingDate, startTime, endTime);

                string operationMessage = mainController.CreateEntity(appointment);
                if (string.Equals("OP_SUCCESS", operationMessage))
                    MessageBox.Show("Sucessfully added new Appointment.", "Operation Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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