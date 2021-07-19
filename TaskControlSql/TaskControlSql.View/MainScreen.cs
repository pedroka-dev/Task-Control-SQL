using System;
using System.Windows.Forms;
using TaskControlSql.Control;

namespace TaskControlSql.View
{
    public partial class MainScreen : Form
    {
        TodoTaskController taskController;
        ContactController contactController;
        AppointmentController appoitmentController;

        public MainScreen()
        {
            taskController = new TodoTaskController();
            contactController = new ContactController();
            appoitmentController = new AppointmentController(contactController);
            InitializeComponent();
        }

        private void btnManageTasks_Click(object sender, EventArgs e)
        {
            ManageTodoTaskScreen menuScreen = new ManageTodoTaskScreen(taskController);
            menuScreen.ShowDialog();
        }

        private void btnManageContacts_Click(object sender, EventArgs e)
        {
            ManageContactScreen menuScreen = new ManageContactScreen(contactController);
            menuScreen.ShowDialog();
        }

        private void btnManageAppoitments_Click(object sender, EventArgs e)
        {
            ManageAppointmentScreen menuScreen = new ManageAppointmentScreen(appoitmentController);
            menuScreen.ShowDialog();
        }
    }
}
