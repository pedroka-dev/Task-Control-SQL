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

        private void LoadEntitiesToDatagrid()     //manual insertion?
        {
            //dataGridTodoTask.Rows.Clear();

            listEntities = mainController.ReceiveAllEntities();

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
                    mainController.DeleteEntity(selectedIndex);
                    LoadEntitiesToDatagrid();
                    //MessageBox.Show("Debug. Selected ID = " + selectedIndex);
                }
            }
        }
    }
}
