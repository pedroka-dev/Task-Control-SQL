using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TaskControlSql.Control;
using TaskControlSql.Domain;

namespace TaskControlSql.View
{
    public partial class ManageContactScreen : Form
    {
        ContactController mainController;
        List<Contact> listEntities;

        public ManageContactScreen(ContactController mainController)
        {
            this.mainController = mainController;
            InitializeComponent();
            LoadEntitiesToDatagrid();
        }

        private void LoadEntitiesToDatagrid()
        {
            listEntities = mainController.ReceiveAllEntities();

            dtContact.Clear();
            foreach (Contact item in listEntities)
            {
                DataRow entityRow = dtContact.NewRow();
                entityRow["Id"] = item.Id;
                entityRow["Name"] = item.Name;
                entityRow["Email"] = item.Email;
                entityRow["PhoneNumber"] = item.PhoneNumber;
                entityRow["BusinessCompany"] = item.BusinessCompany;
                entityRow["CompanyPosition"] = item.CompanyPosition;
                dtContact.Rows.Add(entityRow);
            }

            dataGridContact.DataSource = listEntities;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddContactScreen addEntityScreen = new AddContactScreen(mainController);
            addEntityScreen.ShowDialog();
            LoadEntitiesToDatagrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedIndex = listEntities.ElementAt(dataGridContact.CurrentCell.RowIndex).Id;
            Contact contact = mainController.ReceiveEntity(selectedIndex);
            EditContactScreen editEntityScreen = new EditContactScreen(contact, mainController);
            editEntityScreen.ShowDialog();
            LoadEntitiesToDatagrid();
        }

        private void btnDeleteEntity_Click(object sender, EventArgs e)
        {
            if (dataGridContact.CurrentCell == null)
            {
                MessageBox.Show("Select at least one Contact before attempting Delete operation.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete the selected Contact?", "Confirmation needed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int selectedIndex = listEntities.ElementAt(dataGridContact.CurrentCell.RowIndex).Id;

                    if (mainController.DeleteEntity(selectedIndex))
                        MessageBox.Show("Sucessfully deleted Contact.", "Operation Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error: Contact not found", "Operation error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    LoadEntitiesToDatagrid();
                }
            }
        }
    }
}
