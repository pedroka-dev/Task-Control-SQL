
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTodoTaskScreen));
            this.groupBoxTodoTask = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDeleteEntity = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridTodoTask = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageConcludedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conclusionTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetTodoTask = new System.Data.DataSet();
            this.dtTodoTask = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.groupBoxTodoTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTodoTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTodoTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodoTask)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTodoTask
            // 
            this.groupBoxTodoTask.Controls.Add(this.btnEdit);
            this.groupBoxTodoTask.Controls.Add(this.btnDeleteEntity);
            this.groupBoxTodoTask.Controls.Add(this.btnAdd);
            this.groupBoxTodoTask.Controls.Add(this.dataGridTodoTask);
            this.groupBoxTodoTask.Location = new System.Drawing.Point(17, 16);
            this.groupBoxTodoTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxTodoTask.Name = "groupBoxTodoTask";
            this.groupBoxTodoTask.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxTodoTask.Size = new System.Drawing.Size(644, 425);
            this.groupBoxTodoTask.TabIndex = 0;
            this.groupBoxTodoTask.TabStop = false;
            this.groupBoxTodoTask.Text = "Registered Todo Tasks";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(259, 369);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnDeleteEntity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 39);
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
            this.dataGridTodoTask.AutoGenerateColumns = false;
            this.dataGridTodoTask.ColumnHeadersHeight = 29;
            this.dataGridTodoTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn,
            this.creationTimeDataGridViewTextBoxColumn,
            this.percentageConcludedDataGridViewTextBoxColumn,
            this.conclusionTimeDataGridViewTextBoxColumn});
            this.dataGridTodoTask.DataMember = "TableTodoTask";
            this.dataGridTodoTask.DataSource = this.dataSetTodoTask;
            this.dataGridTodoTask.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridTodoTask.Location = new System.Drawing.Point(19, 23);
            this.dataGridTodoTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridTodoTask.MultiSelect = false;
            this.dataGridTodoTask.Name = "dataGridTodoTask";
            this.dataGridTodoTask.ReadOnly = true;
            this.dataGridTodoTask.RowHeadersVisible = false;
            this.dataGridTodoTask.RowHeadersWidth = 45;
            this.dataGridTodoTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTodoTask.Size = new System.Drawing.Size(600, 325);
            this.dataGridTodoTask.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            this.priorityDataGridViewTextBoxColumn.ReadOnly = true;
            this.priorityDataGridViewTextBoxColumn.Width = 125;
            // 
            // creationTimeDataGridViewTextBoxColumn
            // 
            this.creationTimeDataGridViewTextBoxColumn.DataPropertyName = "CreationTime";
            this.creationTimeDataGridViewTextBoxColumn.HeaderText = "CreationTime";
            this.creationTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creationTimeDataGridViewTextBoxColumn.Name = "creationTimeDataGridViewTextBoxColumn";
            this.creationTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.creationTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // percentageConcludedDataGridViewTextBoxColumn
            // 
            this.percentageConcludedDataGridViewTextBoxColumn.DataPropertyName = "PercentageConcluded";
            this.percentageConcludedDataGridViewTextBoxColumn.HeaderText = "PercentageConcluded";
            this.percentageConcludedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.percentageConcludedDataGridViewTextBoxColumn.Name = "percentageConcludedDataGridViewTextBoxColumn";
            this.percentageConcludedDataGridViewTextBoxColumn.ReadOnly = true;
            this.percentageConcludedDataGridViewTextBoxColumn.Width = 125;
            // 
            // conclusionTimeDataGridViewTextBoxColumn
            // 
            this.conclusionTimeDataGridViewTextBoxColumn.DataPropertyName = "ConclusionTime";
            this.conclusionTimeDataGridViewTextBoxColumn.HeaderText = "ConclusionTime";
            this.conclusionTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.conclusionTimeDataGridViewTextBoxColumn.Name = "conclusionTimeDataGridViewTextBoxColumn";
            this.conclusionTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.conclusionTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataSetTodoTask
            // 
            this.dataSetTodoTask.DataSetName = "dataSetTodoTask";
            this.dataSetTodoTask.Tables.AddRange(new System.Data.DataTable[] {
            this.dtTodoTask});
            // 
            // dtTodoTask
            // 
            this.dtTodoTask.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.dtTodoTask.TableName = "TableTodoTask";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Id";
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Title";
            this.dataColumn2.ColumnName = "Title";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Priority";
            this.dataColumn3.ColumnName = "Priority";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "Creation Time";
            this.dataColumn4.ColumnName = "CreationTime";
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "Percentage Concluded";
            this.dataColumn5.ColumnName = "PercentageConcluded";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "Conclusion Time";
            this.dataColumn6.ColumnName = "ConclusionTime";
            // 
            // ManageTodoTaskScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 458);
            this.Controls.Add(this.groupBoxTodoTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ManageTodoTaskScreen";
            this.Text = "Manage Tasks";
            this.groupBoxTodoTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTodoTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTodoTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodoTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTodoTask;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridTodoTask;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDeleteEntity;
        private System.Data.DataSet dataSetTodoTask;
        private System.Data.DataTable dtTodoTask;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageConcludedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conclusionTimeDataGridViewTextBoxColumn;
    }
}