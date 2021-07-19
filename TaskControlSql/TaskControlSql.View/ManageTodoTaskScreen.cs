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
    public partial class ManageTodoTaskScreen : Form
    {
        TodoTaskController mainController;
        List<TodoTask> listEntities;

        public ManageTodoTaskScreen(TodoTaskController mainController)
        {
            this.mainController = mainController;
            InitializeComponent();
            LoadEntitiesToDatagrid();
        }

        private void LoadEntitiesToDatagrid()
        {
            listEntities = mainController.ReceiveAllEntities();

            dtTodoTask.Clear();
            foreach (TodoTask item in listEntities)
            {
                DataRow entityRow = dtTodoTask.NewRow();
                entityRow["Id"] = item.Id;
                entityRow["Title"] = item.Title;
                entityRow["Priority"] = item.Priority;
                entityRow["CreationTime"] = item.CreationTime.ToString();
                entityRow["PercentageConcluded"] = item.PercentageConcluded;
                entityRow["ConclusionTime"] = item.ConclusionTime;
                dtTodoTask.Rows.Add(entityRow);
            }

            dataGridTodoTask.DataSource = listEntities;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTodoTaskScreen addEntityScreen = new AddTodoTaskScreen(mainController);
            addEntityScreen.ShowDialog();
            LoadEntitiesToDatagrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedIndex = listEntities.ElementAt(dataGridTodoTask.CurrentCell.RowIndex).Id;
            TodoTask todoTask = mainController.ReceiveEntity(selectedIndex);
            EditTodoTaskScreen editTodoTaskScreen = new EditTodoTaskScreen(todoTask, mainController);
            editTodoTaskScreen.ShowDialog();
            LoadEntitiesToDatagrid();
        }

        private void btnDeleteEntity_Click(object sender, EventArgs e)
        {
            if(dataGridTodoTask.CurrentCell == null)
            {
                MessageBox.Show("Select at least one Task before attempting Delete operation.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete the selected Task?", "Confirmation needed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int selectedIndex = listEntities.ElementAt(dataGridTodoTask.CurrentCell.RowIndex).Id;
                    
                    if (mainController.DeleteEntity(selectedIndex))
                        MessageBox.Show("Sucessfully deleted Task.", "Operation Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error: Task not found", "Operation error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    LoadEntitiesToDatagrid();
                    
                }
            }
        }
    }
}
