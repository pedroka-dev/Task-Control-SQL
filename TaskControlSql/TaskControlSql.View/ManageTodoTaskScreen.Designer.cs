
namespace TaskControlSql.View
{
    partial class ManageTodoTaskScreen
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDeleteEntity = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridTodoTask = new System.Windows.Forms.DataGridView();
            this.groupBoxTodoTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTodoTask)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTodoTask
            // 
            this.groupBoxTodoTask.Controls.Add(this.btnEdit);
            this.groupBoxTodoTask.Controls.Add(this.btnDeleteEntity);
            this.groupBoxTodoTask.Controls.Add(this.btnAdd);
            this.groupBoxTodoTask.Controls.Add(this.dataGridTodoTask);
            this.groupBoxTodoTask.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTodoTask.Name = "groupBoxTodoTask";
            this.groupBoxTodoTask.Size = new System.Drawing.Size(483, 345);
            this.groupBoxTodoTask.TabIndex = 0;
            this.groupBoxTodoTask.TabStop = false;
            this.groupBoxTodoTask.Text = "Registered Todo Tasks";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(194, 300);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 32);
            this.btnEdit.TabIndex = 3;
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
            this.btnDeleteEntity.TabIndex = 2;
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
            // dataGridTodoTask
            // 
            this.dataGridTodoTask.AllowUserToAddRows = false;
            this.dataGridTodoTask.AllowUserToDeleteRows = false;
            this.dataGridTodoTask.AllowUserToResizeRows = false;
            this.dataGridTodoTask.ColumnHeadersHeight = 29;
            this.dataGridTodoTask.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridTodoTask.Location = new System.Drawing.Point(15, 19);
            this.dataGridTodoTask.MultiSelect = false;
            this.dataGridTodoTask.Name = "dataGridTodoTask";
            this.dataGridTodoTask.ReadOnly = true;
            this.dataGridTodoTask.RowHeadersVisible = false;
            this.dataGridTodoTask.RowHeadersWidth = 45;
            this.dataGridTodoTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTodoTask.Size = new System.Drawing.Size(450, 264);
            this.dataGridTodoTask.TabIndex = 0;
            // 
            // ManageTodoTaskScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 372);
            this.Controls.Add(this.groupBoxTodoTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ManageTodoTaskScreen";
            this.Text = "Manage Tasks";
            this.groupBoxTodoTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTodoTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTodoTask;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridTodoTask;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDeleteEntity;
    }
}