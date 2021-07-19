
namespace TaskControlSql.View
{
    partial class AddTodoTaskScreen
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.numPercentageConcluded = new System.Windows.Forms.NumericUpDown();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxTodoTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPercentageConcluded)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTodoTask
            // 
            this.groupBoxTodoTask.Controls.Add(this.btnCancel);
            this.groupBoxTodoTask.Controls.Add(this.btnSave);
            this.groupBoxTodoTask.Controls.Add(this.numPercentageConcluded);
            this.groupBoxTodoTask.Controls.Add(this.cmbPriority);
            this.groupBoxTodoTask.Controls.Add(this.txtTitle);
            this.groupBoxTodoTask.Controls.Add(this.label1);
            this.groupBoxTodoTask.Controls.Add(this.labelPriority);
            this.groupBoxTodoTask.Controls.Add(this.labelTitle);
            this.groupBoxTodoTask.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTodoTask.Name = "groupBoxTodoTask";
            this.groupBoxTodoTask.Size = new System.Drawing.Size(154, 195);
            this.groupBoxTodoTask.TabIndex = 0;
            this.groupBoxTodoTask.TabStop = false;
            this.groupBoxTodoTask.Text = "Task Details";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(92, 166);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // numPercentageConcluded
            // 
            this.numPercentageConcluded.Location = new System.Drawing.Point(8, 128);
            this.numPercentageConcluded.Margin = new System.Windows.Forms.Padding(2);
            this.numPercentageConcluded.Name = "numPercentageConcluded";
            this.numPercentageConcluded.Size = new System.Drawing.Size(138, 20);
            this.numPercentageConcluded.TabIndex = 2;
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.Items.AddRange(new object[] {
            "LOW",
            "MEDIUM",
            "HIGH"});
            this.cmbPriority.Location = new System.Drawing.Point(8, 78);
            this.cmbPriority.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(138, 21);
            this.cmbPriority.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(8, 35);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.MaxLength = 200;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(138, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Percentage Concluded:";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(5, 63);
            this.labelPriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(41, 13);
            this.labelPriority.TabIndex = 1;
            this.labelPriority.Text = "Priority:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(6, 19);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title:";
            // 
            // AddTodoTaskScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 218);
            this.Controls.Add(this.groupBoxTodoTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTodoTaskScreen";
            this.Text = "Add Task";
            this.groupBoxTodoTask.ResumeLayout(false);
            this.groupBoxTodoTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPercentageConcluded)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTodoTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.NumericUpDown numPercentageConcluded;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}