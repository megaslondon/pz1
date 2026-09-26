namespace PZ1.forms
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PZ1.db.DataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.workLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddWorkerButton = new System.Windows.Forms.Button();
            this.EditWorkerButton = new System.Windows.Forms.Button();
            this.DeleteWorkerButton = new System.Windows.Forms.Button();
            this.AddWorkLogButton = new System.Windows.Forms.Button();
            this.EditWorkLogButton = new System.Windows.Forms.Button();
            this.DeleteWorkLogButton = new System.Windows.Forms.Button();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.innDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // innDataGridViewTextBoxColumn
            // 
            this.innDataGridViewTextBoxColumn.DataPropertyName = "inn";
            this.innDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.innDataGridViewTextBoxColumn.Name = "innDataGridViewTextBoxColumn";
            // 
            // workerBindingSource1
            // 
            this.workerBindingSource1.DataMember = "Worker";
            this.workerBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.workeridDataGridViewTextBoxColumn,
            this.startedatDataGridViewTextBoxColumn,
            this.endedatDataGridViewTextBoxColumn,
            this.workdescriptionDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.workLogBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 196);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(345, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView2_DataBindingComplete);
            // 
            // workLogBindingSource
            // 
            this.workLogBindingSource.DataMember = "WorkLog";
            this.workLogBindingSource.DataSource = this.dataSet1;
            // 
            // AddWorkerButton
            // 
            this.AddWorkerButton.Location = new System.Drawing.Point(378, 6);
            this.AddWorkerButton.Name = "AddWorkerButton";
            this.AddWorkerButton.Size = new System.Drawing.Size(125, 43);
            this.AddWorkerButton.TabIndex = 11;
            this.AddWorkerButton.Text = "Добавить работника";
            this.AddWorkerButton.UseVisualStyleBackColor = true;
            this.AddWorkerButton.Click += new System.EventHandler(this.AddWorkerButton_Click);
            // 
            // EditWorkerButton
            // 
            this.EditWorkerButton.Location = new System.Drawing.Point(378, 62);
            this.EditWorkerButton.Name = "EditWorkerButton";
            this.EditWorkerButton.Size = new System.Drawing.Size(127, 43);
            this.EditWorkerButton.TabIndex = 11;
            this.EditWorkerButton.Text = "Редактировать работника";
            this.EditWorkerButton.UseVisualStyleBackColor = true;
            this.EditWorkerButton.Click += new System.EventHandler(this.EditWorkerButton_Click);
            // 
            // DeleteWorkerButton
            // 
            this.DeleteWorkerButton.Location = new System.Drawing.Point(378, 119);
            this.DeleteWorkerButton.Name = "DeleteWorkerButton";
            this.DeleteWorkerButton.Size = new System.Drawing.Size(125, 43);
            this.DeleteWorkerButton.TabIndex = 4;
            this.DeleteWorkerButton.Text = "Удалить работника";
            this.DeleteWorkerButton.UseVisualStyleBackColor = true;
            this.DeleteWorkerButton.Click += new System.EventHandler(this.DeleteWorkerButton_Click);
            // 
            // AddWorkLogButton
            // 
            this.AddWorkLogButton.Location = new System.Drawing.Point(378, 181);
            this.AddWorkLogButton.Name = "AddWorkLogButton";
            this.AddWorkLogButton.Size = new System.Drawing.Size(125, 43);
            this.AddWorkLogButton.TabIndex = 5;
            this.AddWorkLogButton.Text = "Добавить выполненную работу";
            this.AddWorkLogButton.UseVisualStyleBackColor = true;
            this.AddWorkLogButton.Click += new System.EventHandler(this.AddWorkLogButton_Click);
            // 
            // EditWorkLogButton
            // 
            this.EditWorkLogButton.Location = new System.Drawing.Point(378, 246);
            this.EditWorkLogButton.Name = "EditWorkLogButton";
            this.EditWorkLogButton.Size = new System.Drawing.Size(125, 39);
            this.EditWorkLogButton.TabIndex = 6;
            this.EditWorkLogButton.Text = "Редактировать выполенную работу";
            this.EditWorkLogButton.UseVisualStyleBackColor = true;
            this.EditWorkLogButton.Click += new System.EventHandler(this.EditWorkLogButton_Click);
            // 
            // DeleteWorkLogButton
            // 
            this.DeleteWorkLogButton.Location = new System.Drawing.Point(378, 307);
            this.DeleteWorkLogButton.Name = "DeleteWorkLogButton";
            this.DeleteWorkLogButton.Size = new System.Drawing.Size(125, 39);
            this.DeleteWorkLogButton.TabIndex = 7;
            this.DeleteWorkLogButton.Text = "Удалить выполненную работу";
            this.DeleteWorkLogButton.UseVisualStyleBackColor = true;
            this.DeleteWorkLogButton.Click += new System.EventHandler(this.DeleteWorkLogButton_Click);
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.dataSet1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // workeridDataGridViewTextBoxColumn
            // 
            this.workeridDataGridViewTextBoxColumn.DataPropertyName = "worker_id";
            this.workeridDataGridViewTextBoxColumn.HeaderText = "Идентификатор работника";
            this.workeridDataGridViewTextBoxColumn.Name = "workeridDataGridViewTextBoxColumn";
            this.workeridDataGridViewTextBoxColumn.Visible = false;
            // 
            // startedatDataGridViewTextBoxColumn
            // 
            this.startedatDataGridViewTextBoxColumn.DataPropertyName = "started_at";
            this.startedatDataGridViewTextBoxColumn.HeaderText = "Начало работы";
            this.startedatDataGridViewTextBoxColumn.Name = "startedatDataGridViewTextBoxColumn";
            // 
            // endedatDataGridViewTextBoxColumn
            // 
            this.endedatDataGridViewTextBoxColumn.DataPropertyName = "ended_at";
            this.endedatDataGridViewTextBoxColumn.HeaderText = "Конец работы";
            this.endedatDataGridViewTextBoxColumn.Name = "endedatDataGridViewTextBoxColumn";
            // 
            // workdescriptionDataGridViewTextBoxColumn
            // 
            this.workdescriptionDataGridViewTextBoxColumn.DataPropertyName = "work_description";
            this.workdescriptionDataGridViewTextBoxColumn.HeaderText = "Описание работы";
            this.workdescriptionDataGridViewTextBoxColumn.Name = "workdescriptionDataGridViewTextBoxColumn";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 359);
            this.Controls.Add(this.DeleteWorkLogButton);
            this.Controls.Add(this.EditWorkLogButton);
            this.Controls.Add(this.AddWorkLogButton);
            this.Controls.Add(this.DeleteWorkerButton);
            this.Controls.Add(this.EditWorkerButton);
            this.Controls.Add(this.AddWorkerButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Основная форма";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource workerBindingSource;
        private db.DataSet1 dataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource workerBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource workLogBindingSource;
        private System.Windows.Forms.Button AddWorkerButton;
        private System.Windows.Forms.Button EditWorkerButton;
        private System.Windows.Forms.Button DeleteWorkerButton;
        private System.Windows.Forms.Button AddWorkLogButton;
        private System.Windows.Forms.Button EditWorkLogButton;
        private System.Windows.Forms.Button DeleteWorkLogButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workdescriptionDataGridViewTextBoxColumn;
    }
}