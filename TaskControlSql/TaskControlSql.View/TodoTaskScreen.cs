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
    public partial class TodoTaskScreen : Form
    {
        TodoTaskController taskController;

        public TodoTaskScreen(TodoTaskController taskController)
        {
            this.taskController = taskController;
            InitializeComponent();
        }

        private void TodoTaskScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
