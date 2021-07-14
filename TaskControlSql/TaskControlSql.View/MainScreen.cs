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

        private void ScheduleControlScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnManageTasks_Click(object sender, EventArgs e)
        {
            TodoTaskScreen menuScreen = new TodoTaskScreen(taskController);
            menuScreen.Show();
        }

        private void btnManageContacts_Click(object sender, EventArgs e)
        {

        }

        private void btnManageAppoitments_Click(object sender, EventArgs e)
        {

        }
    }
}
