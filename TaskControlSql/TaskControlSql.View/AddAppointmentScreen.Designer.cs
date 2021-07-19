
namespace TaskControlSql.View
{
    partial class AddAppointmentScreen
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
            this.groupBoxTodoTask = new System.Windows.Forms.GroupBox();
            this.dateEndTime = new System.Windows.Forms.DateTimePicker();
            this.dateStartTime = new System.Windows.Forms.DateTimePicker();
            this.dateMeetingDate = new System.Windows.Forms.DateTimePicker();
            this.chkIsRemoteMeeting = new System.Windows.Forms.CheckBox();
            this.cmbContact = new System.Windows.Forms.ComboBox();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelCompanyPosition = new System.Windows.Forms.Label();
            this.txtMeetingPlace = new System.Windows.Forms.TextBox();
            this.labelMeetingPlace = new System.Windows.Forms.Label();
            this.txtMeetingSubject = new System.Windows.Forms.TextBox();
            this.labelMeetingSubject = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelContact = new System.Windows.Forms.Label();
            this.groupBoxTodoTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTodoTask
            // 
            this.groupBoxTodoTask.Controls.Add(this.dateEndTime);
            this.groupBoxTodoTask.Controls.Add(this.dateStartTime);
            this.groupBoxTodoTask.Controls.Add(this.dateMeetingDate);
            this.groupBoxTodoTask.Controls.Add(this.chkIsRemoteMeeting);
            this.groupBoxTodoTask.Controls.Add(this.cmbContact);
            this.groupBoxTodoTask.Controls.Add(this.labelEndTime);
            this.groupBoxTodoTask.Controls.Add(this.labelStartTime);
            this.groupBoxTodoTask.Controls.Add(this.labelCompanyPosition);
            this.groupBoxTodoTask.Controls.Add(this.txtMeetingPlace);
            this.groupBoxTodoTask.Controls.Add(this.labelMeetingPlace);
            this.groupBoxTodoTask.Controls.Add(this.txtMeetingSubject);
            this.groupBoxTodoTask.Controls.Add(this.labelMeetingSubject);
            this.groupBoxTodoTask.Controls.Add(this.btnCancel);
            this.groupBoxTodoTask.Controls.Add(this.btnSave);
            this.groupBoxTodoTask.Controls.Add(this.labelContact);
            this.groupBoxTodoTask.Location = new System.Drawing.Point(17, 16);
            this.groupBoxTodoTask.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTodoTask.Name = "groupBoxTodoTask";
            this.groupBoxTodoTask.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTodoTask.Size = new System.Drawing.Size(205, 457);
            this.groupBoxTodoTask.TabIndex = 0;
            this.groupBoxTodoTask.TabStop = false;
            this.groupBoxTodoTask.Text = "Appointment Details";
            // 
            // dateEndTime
            // 
            this.dateEndTime.AllowDrop = true;
            this.dateEndTime.CustomFormat = "\"HH:mm\"";
            this.dateEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateEndTime.Location = new System.Drawing.Point(11, 370);
            this.dateEndTime.Name = "dateEndTime";
            this.dateEndTime.Size = new System.Drawing.Size(183, 22);
            this.dateEndTime.TabIndex = 7;
            // 
            // dateStartTime
            // 
            this.dateStartTime.AllowDrop = true;
            this.dateStartTime.CustomFormat = "\"HH:mm\"";
            this.dateStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateStartTime.Location = new System.Drawing.Point(11, 310);
            this.dateStartTime.Name = "dateStartTime";
            this.dateStartTime.Size = new System.Drawing.Size(183, 22);
            this.dateStartTime.TabIndex = 6;
            // 
            // dateMeetingDate
            // 
            this.dateMeetingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateMeetingDate.Location = new System.Drawing.Point(11, 253);
            this.dateMeetingDate.Name = "dateMeetingDate";
            this.dateMeetingDate.Size = new System.Drawing.Size(183, 22);
            this.dateMeetingDate.TabIndex = 5;
            // 
            // chkIsRemoteMeeting
            // 
            this.chkIsRemoteMeeting.AutoSize = true;
            this.chkIsRemoteMeeting.Location = new System.Drawing.Point(11, 138);
            this.chkIsRemoteMeeting.Name = "chkIsRemoteMeeting";
            this.chkIsRemoteMeeting.Size = new System.Drawing.Size(155, 21);
            this.chkIsRemoteMeeting.TabIndex = 3;
            this.chkIsRemoteMeeting.Text = "Is Remote Meeting?";
            this.chkIsRemoteMeeting.UseVisualStyleBackColor = true;
            // 
            // cmbContact
            // 
            this.cmbContact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContact.FormattingEnabled = true;
            this.cmbContact.Location = new System.Drawing.Point(11, 43);
            this.cmbContact.Name = "cmbContact";
            this.cmbContact.Size = new System.Drawing.Size(183, 24);
            this.cmbContact.TabIndex = 1;
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Location = new System.Drawing.Point(8, 350);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(72, 17);
            this.labelEndTime.TabIndex = 16;
            this.labelEndTime.Text = "End Time:";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(8, 289);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(77, 17);
            this.labelStartTime.TabIndex = 15;
            this.labelStartTime.Text = "Start Time:";
            // 
            // labelCompanyPosition
            // 
            this.labelCompanyPosition.AutoSize = true;
            this.labelCompanyPosition.Location = new System.Drawing.Point(8, 232);
            this.labelCompanyPosition.Name = "labelCompanyPosition";
            this.labelCompanyPosition.Size = new System.Drawing.Size(96, 17);
            this.labelCompanyPosition.TabIndex = 12;
            this.labelCompanyPosition.Text = "Meeting Date:";
            // 
            // txtMeetingPlace
            // 
            this.txtMeetingPlace.Location = new System.Drawing.Point(11, 191);
            this.txtMeetingPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeetingPlace.MaxLength = 200;
            this.txtMeetingPlace.Name = "txtMeetingPlace";
            this.txtMeetingPlace.Size = new System.Drawing.Size(183, 22);
            this.txtMeetingPlace.TabIndex = 4;
            // 
            // labelMeetingPlace
            // 
            this.labelMeetingPlace.AutoSize = true;
            this.labelMeetingPlace.Location = new System.Drawing.Point(8, 171);
            this.labelMeetingPlace.Name = "labelMeetingPlace";
            this.labelMeetingPlace.Size = new System.Drawing.Size(139, 17);
            this.labelMeetingPlace.TabIndex = 10;
            this.labelMeetingPlace.Text = "Meeting Place / Link:";
            // 
            // txtMeetingSubject
            // 
            this.txtMeetingSubject.Location = new System.Drawing.Point(11, 100);
            this.txtMeetingSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeetingSubject.MaxLength = 200;
            this.txtMeetingSubject.Name = "txtMeetingSubject";
            this.txtMeetingSubject.Size = new System.Drawing.Size(183, 22);
            this.txtMeetingSubject.TabIndex = 2;
            // 
            // labelMeetingSubject
            // 
            this.labelMeetingSubject.AutoSize = true;
            this.labelMeetingSubject.Location = new System.Drawing.Point(8, 80);
            this.labelMeetingSubject.Name = "labelMeetingSubject";
            this.labelMeetingSubject.Size = new System.Drawing.Size(113, 17);
            this.labelMeetingSubject.TabIndex = 6;
            this.labelMeetingSubject.Text = "Meeting Subject:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(125, 412);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(11, 412);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(8, 23);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(60, 17);
            this.labelContact.TabIndex = 0;
            this.labelContact.Text = "Contact:";
            // 
            // AddAppointmentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 484);
            this.Controls.Add(this.groupBoxTodoTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddAppointmentScreen";
            this.Text = "Edit Appointment";
            this.groupBoxTodoTask.ResumeLayout(false);
            this.groupBoxTodoTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTodoTask;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMeetingSubject;
        private System.Windows.Forms.Label labelMeetingSubject;
        private System.Windows.Forms.Label labelCompanyPosition;
        private System.Windows.Forms.TextBox txtMeetingPlace;
        private System.Windows.Forms.Label labelMeetingPlace;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.ComboBox cmbContact;
        private System.Windows.Forms.CheckBox chkIsRemoteMeeting;
        private System.Windows.Forms.DateTimePicker dateEndTime;
        private System.Windows.Forms.DateTimePicker dateStartTime;
        private System.Windows.Forms.DateTimePicker dateMeetingDate;
    }
}