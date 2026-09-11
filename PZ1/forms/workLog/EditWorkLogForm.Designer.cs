namespace PZ1.forms.workLog
{
    partial class EditWorkLogForm
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
            this.WorkerComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddWorkLogButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WorkDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // WorkerComboBox
            // 
            this.WorkerComboBox.DisplayMember = "fio";
            this.WorkerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.WorkerComboBox.FormattingEnabled = true;
            this.WorkerComboBox.Location = new System.Drawing.Point(446, 133);
            this.WorkerComboBox.Name = "WorkerComboBox";
            this.WorkerComboBox.Size = new System.Drawing.Size(265, 24);
            this.WorkerComboBox.TabIndex = 23;
            this.WorkerComboBox.ValueMember = "id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(362, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Работник";
            // 
            // AddWorkLogButton
            // 
            this.AddWorkLogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.AddWorkLogButton.Location = new System.Drawing.Point(608, 382);
            this.AddWorkLogButton.Name = "AddWorkLogButton";
            this.AddWorkLogButton.Size = new System.Drawing.Size(103, 37);
            this.AddWorkLogButton.TabIndex = 21;
            this.AddWorkLogButton.Text = "Добавить";
            this.AddWorkLogButton.UseVisualStyleBackColor = true;
            this.AddWorkLogButton.Click += new System.EventHandler(this.AddWorkLogButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.goBackButton.Location = new System.Drawing.Point(12, 12);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(103, 37);
            this.goBackButton.TabIndex = 20;
            this.goBackButton.Text = "Назад";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(309, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Описание работы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(320, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Дата окончания";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(344, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Дата начала";
            // 
            // WorkDescriptionTextBox
            // 
            this.WorkDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.WorkDescriptionTextBox.Location = new System.Drawing.Point(446, 274);
            this.WorkDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.WorkDescriptionTextBox.Multiline = true;
            this.WorkDescriptionTextBox.Name = "WorkDescriptionTextBox";
            this.WorkDescriptionTextBox.Size = new System.Drawing.Size(265, 80);
            this.WorkDescriptionTextBox.TabIndex = 16;
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.EndTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.EndTimePicker.Location = new System.Drawing.Point(446, 226);
            this.EndTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.EndTimePicker.MaxDate = new System.DateTime(2026, 9, 11, 0, 0, 0, 0);
            this.EndTimePicker.MinDate = new System.DateTime(2026, 7, 11, 0, 0, 0, 0);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.Size = new System.Drawing.Size(265, 22);
            this.EndTimePicker.TabIndex = 15;
            this.EndTimePicker.Value = new System.DateTime(2026, 9, 11, 0, 0, 0, 0);
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.StartTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.StartTimePicker.Location = new System.Drawing.Point(446, 178);
            this.StartTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.StartTimePicker.MaxDate = new System.DateTime(2026, 9, 11, 0, 0, 0, 0);
            this.StartTimePicker.MinDate = new System.DateTime(2026, 7, 11, 0, 0, 0, 0);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.Size = new System.Drawing.Size(265, 22);
            this.StartTimePicker.TabIndex = 14;
            this.StartTimePicker.Value = new System.DateTime(2026, 9, 11, 0, 0, 0, 0);
            // 
            // EditWorkLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 630);
            this.Controls.Add(this.WorkerComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddWorkLogButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WorkDescriptionTextBox);
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.StartTimePicker);
            this.Name = "EditWorkLogForm";
            this.Text = "EditWorkLogForm";
            this.Load += new System.EventHandler(this.EditWorkLogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox WorkerComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddWorkLogButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WorkDescriptionTextBox;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
    }
}