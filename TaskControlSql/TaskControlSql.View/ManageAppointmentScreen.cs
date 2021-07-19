using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskControlSql.Control;
using TaskControlSql.Domain;

namespace TaskControlSql.View
{
    public partial class ManageAppointmentScreen : Form
    {
        AppointmentController mainController;
        List<Appointment> listEntities;

        public ManageAppointmentScreen(AppointmentController mainController)
        {
            this.mainController = mainController;
            InitializeComponent();
            LoadEntitiesToDatagrid();
        }

        private void LoadEntitiesToDatagrid()
        {
            listEntities = mainController.ReceiveAllEntities();

            dtAppointment.Clear();
            foreach (Appointment item in listEntities)
            {
                DataRow entityRow = dtAppointment.NewRow();

                entityRow["Id"] = item.Id;
                string contactId = "";
                if (item.Contact != null)
                    contactId = item.Contact.Id.ToString(); 
                entityRow["Contact"] = contactId;       //why tf its returning contact.ToString()?
                entityRow["MeetingSubject"] = item.MeetingSubject;
                entityRow["IsRemoteMeeting"] = item.IsRemoteMeeting.ToString();
                entityRow["MeetingPlace"] = item.MeetingPlace;
                entityRow["MeetingDate"] = item.MeetingDate.ToString();
                entityRow["StartTime"] = item.StartTime.ToString();
                entityRow["EndTime"] = item.EndTime.ToString();

                dtAppointment.Rows.Add(entityRow);
            }

            dataGridAppointment.DataSource = listEntities;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAppointmentScreen addEntityScreen = new AddAppointmentScreen(mainController);
            addEntityScreen.ShowDialog();
            LoadEntitiesToDatagrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedIndex = listEntities.ElementAt(dataGridAppointment.CurrentCell.RowIndex).Id;
            Appointment appointment = mainController.ReceiveEntity(selectedIndex);
            //EditAppointmenScreen editEntityScreen = new EditAppointmenScreen(appointment, mainController);
            //editEntityScreen.ShowDialog();
            LoadEntitiesToDatagrid();
        }

        private void btnDeleteEntity_Click(object sender, EventArgs e)
        {
            if(dataGridAppointment.CurrentCell == null)
            {
                MessageBox.Show("Select at least one Appointment before attempting Delete operation.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete the selected Appointment?", "Confirmation needed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int selectedIndex = listEntities.ElementAt(dataGridAppointment.CurrentCell.RowIndex).Id;
                    
                    if (mainController.DeleteEntity(selectedIndex))
                        MessageBox.Show("Sucessfully deleted Appointment.", "Operation Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error: Appointment not found", "Operation error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    LoadEntitiesToDatagrid(); 
                }
            }
        }
    }
}
