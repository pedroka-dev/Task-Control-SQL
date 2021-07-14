
namespace TaskControlSql.View
{
    partial class MainScreen
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
            this.btnManageTasks = new System.Windows.Forms.Button();
            this.btnManageContacts = new System.Windows.Forms.Button();
            this.btnManageAppoitments = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManageTasks
            // 
            this.btnManageTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTasks.Location = new System.Drawing.Point(22, 64);
            this.btnManageTasks.Name = "btnManageTasks";
            this.btnManageTasks.Size = new System.Drawing.Size(127, 47);
            this.btnManageTasks.TabIndex = 0;
            this.btnManageTasks.Text = "Manage Tasks";
            this.btnManageTasks.UseVisualStyleBackColor = true;
            this.btnManageTasks.Click += new System.EventHandler(this.btnManageTasks_Click);
            // 
            // btnManageContacts
            // 
            this.btnManageContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageContacts.Location = new System.Drawing.Point(22, 117);
            this.btnManageContacts.Name = "btnManageContacts";
            this.btnManageContacts.Size = new System.Drawing.Size(127, 47);
            this.btnManageContacts.TabIndex = 1;
            this.btnManageContacts.Text = "Manage Contacts";
            this.btnManageContacts.UseVisualStyleBackColor = true;
            this.btnManageContacts.Click += new System.EventHandler(this.btnManageContacts_Click);
            // 
            // btnManageAppoitments
            // 
            this.btnManageAppoitments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAppoitments.Location = new System.Drawing.Point(22, 170);
            this.btnManageAppoitments.Name = "btnManageAppoitments";
            this.btnManageAppoitments.Size = new System.Drawing.Size(127, 47);
            this.btnManageAppoitments.TabIndex = 2;
            this.btnManageAppoitments.Text = "Manage Appoitments";
            this.btnManageAppoitments.UseVisualStyleBackColor = true;
            this.btnManageAppoitments.Click += new System.EventHandler(this.btnManageAppoitments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a Menu";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnManageAppoitments);
            this.Controls.Add(this.btnManageContacts);
            this.Controls.Add(this.btnManageTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Text = "Schedule Control";
            this.Load += new System.EventHandler(this.ScheduleControlScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageTasks;
        private System.Windows.Forms.Button btnManageContacts;
        private System.Windows.Forms.Button btnManageAppoitments;
        private System.Windows.Forms.Label label1;
    }
}

