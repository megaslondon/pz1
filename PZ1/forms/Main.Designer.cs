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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PZ1.db.DataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddWorkerButton = new System.Windows.Forms.Button();
            this.EditWorkerButton = new System.Windows.Forms.Button();
            this.DeleteWorkerButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "fio";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // innDataGridViewTextBoxColumn
            // 
            this.innDataGridViewTextBoxColumn.DataPropertyName = "inn";
            this.innDataGridViewTextBoxColumn.HeaderText = "inn";
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
            this.dataGridView2.Size = new System.Drawing.Size(547, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // workeridDataGridViewTextBoxColumn
            // 
            this.workeridDataGridViewTextBoxColumn.DataPropertyName = "worker_id";
            this.workeridDataGridViewTextBoxColumn.HeaderText = "worker_id";
            this.workeridDataGridViewTextBoxColumn.Name = "workeridDataGridViewTextBoxColumn";
            // 
            // startedatDataGridViewTextBoxColumn
            // 
            this.startedatDataGridViewTextBoxColumn.DataPropertyName = "started_at";
            this.startedatDataGridViewTextBoxColumn.HeaderText = "started_at";
            this.startedatDataGridViewTextBoxColumn.Name = "startedatDataGridViewTextBoxColumn";
            // 
            // endedatDataGridViewTextBoxColumn
            // 
            this.endedatDataGridViewTextBoxColumn.DataPropertyName = "ended_at";
            this.endedatDataGridViewTextBoxColumn.HeaderText = "ended_at";
            this.endedatDataGridViewTextBoxColumn.Name = "endedatDataGridViewTextBoxColumn";
            // 
            // workdescriptionDataGridViewTextBoxColumn
            // 
            this.workdescriptionDataGridViewTextBoxColumn.DataPropertyName = "work_description";
            this.workdescriptionDataGridViewTextBoxColumn.HeaderText = "work_description";
            this.workdescriptionDataGridViewTextBoxColumn.Name = "workdescriptionDataGridViewTextBoxColumn";
            // 
            // workLogBindingSource
            // 
            this.workLogBindingSource.DataMember = "WorkLog";
            this.workLogBindingSource.DataSource = this.dataSet1;
            // 
            // AddWorkerButton
            // 
            this.AddWorkerButton.Location = new System.Drawing.Point(640, 25);
            this.AddWorkerButton.Name = "AddWorkerButton";
            this.AddWorkerButton.Size = new System.Drawing.Size(161, 45);
            this.AddWorkerButton.TabIndex = 2;
            this.AddWorkerButton.Text = "Добавить работника";
            this.AddWorkerButton.UseVisualStyleBackColor = true;
            this.AddWorkerButton.Click += new System.EventHandler(this.AddWorkerButton_Click);
            // 
            // EditWorkerButton
            // 
            this.EditWorkerButton.Location = new System.Drawing.Point(640, 90);
            this.EditWorkerButton.Name = "EditWorkerButton";
            this.EditWorkerButton.Size = new System.Drawing.Size(161, 45);
            this.EditWorkerButton.TabIndex = 3;
            this.EditWorkerButton.Text = "Редактировать работника";
            this.EditWorkerButton.UseVisualStyleBackColor = true;
            this.EditWorkerButton.Click += new System.EventHandler(this.EditWorkerButton_Click);
            // 
            // DeleteWorkerButton
            // 
            this.DeleteWorkerButton.Location = new System.Drawing.Point(640, 155);
            this.DeleteWorkerButton.Name = "DeleteWorkerButton";
            this.DeleteWorkerButton.Size = new System.Drawing.Size(161, 45);
            this.DeleteWorkerButton.TabIndex = 4;
            this.DeleteWorkerButton.Text = "Удалить работника";
            this.DeleteWorkerButton.UseVisualStyleBackColor = true;
            this.DeleteWorkerButton.Click += new System.EventHandler(this.DeleteWorkerButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(640, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 45);
            this.button4.TabIndex = 5;
            this.button4.Text = "Добавить выполненную работу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(640, 287);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 45);
            this.button5.TabIndex = 6;
            this.button5.Text = "Редактировать выполенную работу";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(640, 358);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(161, 45);
            this.button6.TabIndex = 7;
            this.button6.Text = "Удалить выполненную работу";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.dataSet1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.DeleteWorkerButton);
            this.Controls.Add(this.EditWorkerButton);
            this.Controls.Add(this.AddWorkerButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main";
            this.Text = "Main";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource workerBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource workLogBindingSource;
        private System.Windows.Forms.Button AddWorkerButton;
        private System.Windows.Forms.Button EditWorkerButton;
        private System.Windows.Forms.Button DeleteWorkerButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}