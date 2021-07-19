using System;
using System.Windows.Forms;
using TaskControlSql.Control;
using TaskControlSql.Domain;

namespace TaskControlSql.View
{
    public partial class AddTodoTaskScreen : Form
    {
        TodoTaskController mainController;

        public AddTodoTaskScreen(TodoTaskController mainController)
        {
            this.mainController = mainController;
            InitializeComponent();
            this.cmbPriority.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save a new Task?", "Confirmation needed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string title = txtTitle.Text;
                string priority = cmbPriority.SelectedItem.ToString();
                int percentageConcluded = (int)numPercentageConcluded.Value;

                if (string.IsNullOrEmpty(title))
                {
                    MessageBox.Show("Attribute Title cannot be null or empty.", "Invalid argument", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TodoTask todoTask = new TodoTask(0, priority, title, DateTime.Now);
                todoTask.UpdatePercentageConcluded(percentageConcluded, DateTime.Now);

                string operationMessage = mainController.CreateEntity(todoTask);
                if (string.Equals("OP_SUCCESS", operationMessage))
                    MessageBox.Show("Sucessfully added new Task.", "Operation Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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