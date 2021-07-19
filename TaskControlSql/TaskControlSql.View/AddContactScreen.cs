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
    public partial class AddContactScreen : Form
    {
        ContactController mainController;

        public AddContactScreen(ContactController mainController)
        {
            this.mainController = mainController;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save a new Contact?", "Confirmation needed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string name = txtName.Text;
                string email = txtEmail.Text;
                string phoneNumber = txtPhoneNumber.Text;
                string businessCompany = txtBusinessCompany.Text;
                string companyPosition = txtCompanyPosition.Text;

                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Attribute Email cannot be null or empty.", "Invalid argument", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(phoneNumber))
                {
                    MessageBox.Show("Attribute Phone Number cannot be null or empty.", "Invalid argument", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Contact contact = new Contact(0, name, email, phoneNumber, businessCompany, companyPosition);

                string operationMessage = mainController.CreateEntity(contact);
                if (string.Equals("OP_SUCCESS", operationMessage))
                    MessageBox.Show("Sucessfully added new Contact.", "Operation Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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