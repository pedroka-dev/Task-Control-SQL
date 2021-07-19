using System;
using System.Windows.Forms;
using TaskControlSql.Control;
using TaskControlSql.Domain;

namespace TaskControlSql.View
{
    public partial class EditTodoTaskScreen : Form
    {
        TodoTaskController mainController;
        int entityId;

        public EditTodoTaskScreen(TodoTask todoTask, TodoTaskController mainController)
        {
            this.mainController = mainController;
            this.entityId = todoTask.Id;
            InitializeComponent();

            this.Text += " - Id : " + entityId;
            this.txtTitle.Text = todoTask.Title;
            this.numPercentageConcluded.Value = new decimal((double)todoTask.PercentageConcluded);
            switch (todoTask.Priority)
            {
                case "HIGH":
                    this.cmbPriority.SelectedIndex = 2;
                    break;
                case "MEDIUM":
                    this.cmbPriority.SelectedIndex = 1;
                    break;
                default:
                    this.cmbPriority.SelectedIndex = 0;
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save a the edited Task?", "Confirmation needed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

                TodoTask todoTask = new TodoTask(entityId, priority, title, DateTime.Now);
                todoTask.UpdatePercentageConcluded(percentageConcluded, DateTime.Now);

                string operationMessage = mainController.UpdateEntity(todoTask);
                if (string.Equals("OP_SUCCESS", operationMessage))
                    MessageBox.Show("Sucessfully edited existing Task.", "Operation Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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