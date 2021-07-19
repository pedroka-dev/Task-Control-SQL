
namespace TaskControlSql.View
{
    partial class ManageAppointmentScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAppointmentScreen));
            this.groupBoxTodoTask = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDeleteEntity = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridAppointment = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRemoteMeetingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetAppointment = new System.Data.DataSet();
            this.dtAppointment = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.groupBoxTodoTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTodoTask
            // 
            this.groupBoxTodoTask.Controls.Add(this.btnEdit);
            this.groupBoxTodoTask.Controls.Add(this.btnDeleteEntity);
            this.groupBoxTodoTask.Controls.Add(this.btnAdd);
            this.groupBoxTodoTask.Controls.Add(this.dataGridAppointment);
            this.groupBoxTodoTask.Location = new System.Drawing.Point(17, 16);
            this.groupBoxTodoTask.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTodoTask.Name = "groupBoxTodoTask";
            this.groupBoxTodoTask.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTodoTask.Size = new System.Drawing.Size(644, 425);
            this.groupBoxTodoTask.TabIndex = 0;
            this.groupBoxTodoTask.TabStop = false;
            this.groupBoxTodoTask.Text = "Registered Appointment";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(259, 369);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(131, 39);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDeleteEntity
            // 
            this.btnDeleteEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEntity.Location = new System.Drawing.Point(489, 369);
            this.btnDeleteEntity.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteEntity.Name = "btnDeleteEntity";
            this.btnDeleteEntity.Size = new System.Drawing.Size(131, 39);
            this.btnDeleteEntity.TabIndex = 3;
            this.btnDeleteEntity.Text = "Delete";
            this.btnDeleteEntity.UseVisualStyleBackColor = true;
            this.btnDeleteEntity.Click += new System.EventHandler(this.btnDeleteEntity_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(20, 369);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 39);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridAppointment
            // 
            this.dataGridAppointment.AllowUserToAddRows = false;
            this.dataGridAppointment.AllowUserToDeleteRows = false;
            this.dataGridAppointment.AllowUserToResizeRows = false;
            this.dataGridAppointment.AutoGenerateColumns = false;
            this.dataGridAppointment.ColumnHeadersHeight = 29;
            this.dataGridAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.contactDataGridViewTextBoxColumn,
            this.meetingSubjectDataGridViewTextBoxColumn,
            this.isRemoteMeetingDataGridViewTextBoxColumn,
            this.meetingPlaceDataGridViewTextBoxColumn,
            this.meetingDateDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.dataGridAppointment.DataMember = "TableAppointment";
            this.dataGridAppointment.DataSource = this.dataSetAppointment;
            this.dataGridAppointment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridAppointment.Location = new System.Drawing.Point(19, 23);
            this.dataGridAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridAppointment.MultiSelect = false;
            this.dataGridAppointment.Name = "dataGridAppointment";
            this.dataGridAppointment.ReadOnly = true;
            this.dataGridAppointment.RowHeadersVisible = false;
            this.dataGridAppointment.RowHeadersWidth = 45;
            this.dataGridAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAppointment.Size = new System.Drawing.Size(600, 325);
            this.dataGridAppointment.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactDataGridViewTextBoxColumn.Width = 125;
            // 
            // meetingSubjectDataGridViewTextBoxColumn
            // 
            this.meetingSubjectDataGridViewTextBoxColumn.DataPropertyName = "MeetingSubject";
            this.meetingSubjectDataGridViewTextBoxColumn.HeaderText = "MeetingSubject";
            this.meetingSubjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.meetingSubjectDataGridViewTextBoxColumn.Name = "meetingSubjectDataGridViewTextBoxColumn";
            this.meetingSubjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.meetingSubjectDataGridViewTextBoxColumn.Width = 125;
            // 
            // isRemoteMeetingDataGridViewTextBoxColumn
            // 
            this.isRemoteMeetingDataGridViewTextBoxColumn.DataPropertyName = "IsRemoteMeeting";
            this.isRemoteMeetingDataGridViewTextBoxColumn.HeaderText = "IsRemoteMeeting";
            this.isRemoteMeetingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isRemoteMeetingDataGridViewTextBoxColumn.Name = "isRemoteMeetingDataGridViewTextBoxColumn";
            this.isRemoteMeetingDataGridViewTextBoxColumn.ReadOnly = true;
            this.isRemoteMeetingDataGridViewTextBoxColumn.Width = 125;
            // 
            // meetingPlaceDataGridViewTextBoxColumn
            // 
            this.meetingPlaceDataGridViewTextBoxColumn.DataPropertyName = "MeetingPlace";
            this.meetingPlaceDataGridViewTextBoxColumn.HeaderText = "MeetingPlace";
            this.meetingPlaceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.meetingPlaceDataGridViewTextBoxColumn.Name = "meetingPlaceDataGridViewTextBoxColumn";
            this.meetingPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.meetingPlaceDataGridViewTextBoxColumn.Width = 125;
            // 
            // meetingDateDataGridViewTextBoxColumn
            // 
            this.meetingDateDataGridViewTextBoxColumn.DataPropertyName = "MeetingDate";
            this.meetingDateDataGridViewTextBoxColumn.HeaderText = "MeetingDate";
            this.meetingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.meetingDateDataGridViewTextBoxColumn.Name = "meetingDateDataGridViewTextBoxColumn";
            this.meetingDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.meetingDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.endTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataSetAppointment
            // 
            this.dataSetAppointment.DataSetName = "dataSetAppointment";
            this.dataSetAppointment.Tables.AddRange(new System.Data.DataTable[] {
            this.dtAppointment});
            // 
            // dtAppointment
            // 
            this.dtAppointment.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.dtAppointment.TableName = "TableAppointment";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Id";
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Contact";
            this.dataColumn2.ColumnName = "Contact";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Meeting Subject";
            this.dataColumn3.ColumnName = "MeetingSubject";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "Is Remote Meeting";
            this.dataColumn4.ColumnName = "IsRemoteMeeting";
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "Meeting Place";
            this.dataColumn5.ColumnName = "MeetingPlace";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "Meeting Date";
            this.dataColumn6.ColumnName = "MeetingDate";
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "Start Time";
            this.dataColumn7.ColumnName = "StartTime";
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "End Time";
            this.dataColumn8.ColumnName = "EndTime";
            // 
            // ManageAppointmentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 458);
            this.Controls.Add(this.groupBoxTodoTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ManageAppointmentScreen";
            this.Text = "Manage Appointment";
            this.groupBoxTodoTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAppointment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTodoTask;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridAppointment;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDeleteEntity;
        private System.Data.DataSet dataSetAppointment;
        private System.Data.DataTable dtAppointment;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isRemoteMeetingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
    }
}