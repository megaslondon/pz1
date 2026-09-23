using PZ1.db;
using System.Windows.Forms;

namespace PZ1.forms.workers
{
    partial class AddWorkerForm
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
            this.FIOTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RoleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.INNTextBox = new System.Windows.Forms.TextBox();
            this.goBackButton = new System.Windows.Forms.Button();
            this.AddWorkerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Location = new System.Drawing.Point(272, 46);
            this.FIOTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FIOTextBox.Multiline = true;
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.ShortcutsEnabled = false;
            this.FIOTextBox.Size = new System.Drawing.Size(515, 40);
            this.FIOTextBox.TabIndex = 0;
            this.FIOTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FIOTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Должность :";
            // 
            // RoleTextBox
            // 
            this.RoleTextBox.Location = new System.Drawing.Point(272, 136);
            this.RoleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RoleTextBox.Multiline = true;
            this.RoleTextBox.Name = "RoleTextBox";
            this.RoleTextBox.ShortcutsEnabled = false;
            this.RoleTextBox.Size = new System.Drawing.Size(515, 40);
            this.RoleTextBox.TabIndex = 1;
            this.RoleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RoleTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ИНН :";
            // 
            // INNTextBox
            // 
            this.INNTextBox.Location = new System.Drawing.Point(272, 222);
            this.INNTextBox.MaxLength = 12;
            this.INNTextBox.Multiline = true;
            this.INNTextBox.Name = "INNTextBox";
            this.INNTextBox.ShortcutsEnabled = false;
            this.INNTextBox.Size = new System.Drawing.Size(515, 40);
            this.INNTextBox.TabIndex = 2;
            this.INNTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.INNTextBox_KeyPress);
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(12, 12);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(103, 37);
            this.goBackButton.TabIndex = 4;
            this.goBackButton.Text = "Назад";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // AddWorkerButton
            // 
            this.AddWorkerButton.Location = new System.Drawing.Point(685, 289);
            this.AddWorkerButton.Name = "AddWorkerButton";
            this.AddWorkerButton.Size = new System.Drawing.Size(102, 37);
            this.AddWorkerButton.TabIndex = 3;
            this.AddWorkerButton.Text = "Добавить";
            this.AddWorkerButton.UseVisualStyleBackColor = true;
            this.AddWorkerButton.Click += new System.EventHandler(this.AddWorkerButton_Click);
            // 
            // AddWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 554);
            this.Controls.Add(this.AddWorkerButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.INNTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoleTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FIOTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddWorkerForm";
            this.Text = "AddWorkerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FIOTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RoleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox INNTextBox;
        private System.Windows.Forms.Button goBackButton;
        private Button AddWorkerButton;
    }
}