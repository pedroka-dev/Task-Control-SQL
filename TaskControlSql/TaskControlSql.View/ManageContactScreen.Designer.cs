
namespace TaskControlSql.View
{
    partial class ManageContactScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxContact = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDeleteEntity = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridContact = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetContact = new System.Data.DataSet();
            this.dtContact = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.groupBoxContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtContact)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxContact
            // 
            this.groupBoxContact.Controls.Add(this.btnEdit);
            this.groupBoxContact.Controls.Add(this.btnDeleteEntity);
            this.groupBoxContact.Controls.Add(this.btnAdd);
            this.groupBoxContact.Controls.Add(this.dataGridContact);
            this.groupBoxContact.Location = new System.Drawing.Point(13, 13);
            this.groupBoxContact.Name = "groupBoxContact";
            this.groupBoxContact.Size = new System.Drawing.Size(483, 345);
            this.groupBoxContact.TabIndex = 0;
            this.groupBoxContact.TabStop = false;
            this.groupBoxContact.Text = "Registered Contact";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(194, 300);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 32);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDeleteEntity
            // 
            this.btnDeleteEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEntity.Location = new System.Drawing.Point(367, 300);
            this.btnDeleteEntity.Name = "btnDeleteEntity";
            this.btnDeleteEntity.Size = new System.Drawing.Size(98, 32);
            this.btnDeleteEntity.TabIndex = 3;
            this.btnDeleteEntity.Text = "Delete";
            this.btnDeleteEntity.UseVisualStyleBackColor = true;
            this.btnDeleteEntity.Click += new System.EventHandler(this.btnDeleteEntity_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(15, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridContact
            // 
            this.dataGridContact.AllowUserToAddRows = false;
            this.dataGridContact.AllowUserToDeleteRows = false;
            this.dataGridContact.AllowUserToResizeRows = false;
            this.dataGridContact.AutoGenerateColumns = false;
            this.dataGridContact.ColumnHeadersHeight = 29;
            this.dataGridContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.businessCompanyDataGridViewTextBoxColumn,
            this.companyPositionDataGridViewTextBoxColumn});
            this.dataGridContact.DataMember = "TableContact";
            this.dataGridContact.DataSource = this.dataSetContact;
            this.dataGridContact.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridContact.Location = new System.Drawing.Point(14, 19);
            this.dataGridContact.MultiSelect = false;
            this.dataGridContact.Name = "dataGridContact";
            this.dataGridContact.ReadOnly = true;
            this.dataGridContact.RowHeadersVisible = false;
            this.dataGridContact.RowHeadersWidth = 45;
            this.dataGridContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridContact.Size = new System.Drawing.Size(450, 264);
            this.dataGridContact.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // businessCompanyDataGridViewTextBoxColumn
            // 
            this.businessCompanyDataGridViewTextBoxColumn.DataPropertyName = "BusinessCompany";
            this.businessCompanyDataGridViewTextBoxColumn.HeaderText = "BusinessCompany";
            this.businessCompanyDataGridViewTextBoxColumn.Name = "businessCompanyDataGridViewTextBoxColumn";
            this.businessCompanyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyPositionDataGridViewTextBoxColumn
            // 
            this.companyPositionDataGridViewTextBoxColumn.DataPropertyName = "CompanyPosition";
            this.companyPositionDataGridViewTextBoxColumn.HeaderText = "CompanyPosition";
            this.companyPositionDataGridViewTextBoxColumn.Name = "companyPositionDataGridViewTextBoxColumn";
            this.companyPositionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataSetContact
            // 
            this.dataSetContact.DataSetName = "dataSetContact";
            this.dataSetContact.Tables.AddRange(new System.Data.DataTable[] {
            this.dtContact});
            // 
            // dtContact
            // 
            this.dtContact.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.dtContact.TableName = "TableContact";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Id";
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Name";
            this.dataColumn2.ColumnName = "Name";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Email";
            this.dataColumn3.ColumnName = "Email";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "Phone Number";
            this.dataColumn4.ColumnName = "PhoneNumber";
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "Business Company";
            this.dataColumn5.ColumnName = "BusinessCompany";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "Company Position";
            this.dataColumn6.ColumnName = "CompanyPosition";
            // 
            // ManageContactScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 372);
            this.Controls.Add(this.groupBoxContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ManageContactScreen";
            this.Text = "Manage Contact";
            this.groupBoxContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxContact;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridContact;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDeleteEntity;
        private System.Data.DataSet dataSetContact;
        private System.Data.DataTable dtContact;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyPositionDataGridViewTextBoxColumn;
    }
}