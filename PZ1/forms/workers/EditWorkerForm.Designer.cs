namespace PZ1.forms.workers
{
    partial class EditWorkerForm
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
            this.EditWorkerButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.INNTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RoleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FIOTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EditWorkerButton
            // 
            this.EditWorkerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditWorkerButton.Location = new System.Drawing.Point(861, 364);
            this.EditWorkerButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditWorkerButton.Name = "EditWorkerButton";
            this.EditWorkerButton.Size = new System.Drawing.Size(136, 46);
            this.EditWorkerButton.TabIndex = 17;
            this.EditWorkerButton.Text = "Сохранить";
            this.EditWorkerButton.UseVisualStyleBackColor = true;
            this.EditWorkerButton.Click += new System.EventHandler(this.EditWorkerButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.Location = new System.Drawing.Point(11, 22);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(4);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(137, 46);
            this.goBackButton.TabIndex = 16;
            this.goBackButton.Text = "Назад";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(251, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "ИНН";
            // 
            // INNTextBox
            // 
            this.INNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.INNTextBox.Location = new System.Drawing.Point(310, 281);
            this.INNTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.INNTextBox.Multiline = true;
            this.INNTextBox.Name = "INNTextBox";
            this.INNTextBox.Size = new System.Drawing.Size(685, 48);
            this.INNTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(227, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Должность";
            // 
            // RoleTextBox
            // 
            this.RoleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleTextBox.Location = new System.Drawing.Point(310, 175);
            this.RoleTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.RoleTextBox.Multiline = true;
            this.RoleTextBox.Name = "RoleTextBox";
            this.RoleTextBox.Size = new System.Drawing.Size(685, 48);
            this.RoleTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(251, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "ФИО :";
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOTextBox.Location = new System.Drawing.Point(310, 65);
            this.FIOTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.FIOTextBox.Multiline = true;
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.Size = new System.Drawing.Size(685, 48);
            this.FIOTextBox.TabIndex = 10;
            // 
            // EditWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 522);
            this.Controls.Add(this.EditWorkerButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.INNTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoleTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FIOTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditWorkerForm";
            this.Text = "EditWorkerForm";
            this.Load += new System.EventHandler(this.EditWorkerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditWorkerButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox INNTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RoleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FIOTextBox;
    }
}