using PZ1.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PZ1.db.DataSet1;

namespace PZ1.forms.workers
{
    public partial class AddWorkerForm : Form
    {
        private DataSet1 dataSet;
        private string dataPath;

        public AddWorkerForm(DataSet1 ds, string path)
        {
            this.dataSet = ds;
            this.dataPath = path;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void goBackButton_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void AddWorkerButton_Click(object sender, EventArgs e)
        {
            DataSet1.WorkerRow newRow = dataSet.Worker.NewWorkerRow();
            newRow.fio = FIOTextBox.Text;
            newRow.role = RoleTextBox.Text;

            string innText = INNTextBox.Text.Trim();

            if (string.IsNullOrEmpty(innText))
            {
                MessageBox.Show("Введите ИНН!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                INNTextBox.Focus();
                return;
            }

            if (innText.Length != 12)
            {
                MessageBox.Show("ИНН должен содержать ровно 12 цифр!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                INNTextBox.Focus();
                INNTextBox.SelectAll();
                return;
            }

            foreach (char c in innText)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("ИНН должен содержать только цифры!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    INNTextBox.Focus();
                    INNTextBox.SelectAll();
                    return;
                }
            }

            newRow.inn = innText;

            if (string.IsNullOrEmpty(newRow.fio)) {
                MessageBox.Show("Введите ФИО работника!");
                return;
            }

            foreach (char c in FIOTextBox.Text)
            {
                if (!char.IsLetter(c) && c != ' ' && c != '-')
                {
                    MessageBox.Show("ФИО должна содержать только буквы!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FIOTextBox.Focus();
                    FIOTextBox.SelectAll();
                    return;
                }
            }

           newRow.fio= FIOTextBox.Text;

            if (string.IsNullOrEmpty(newRow.role))
            {
                MessageBox.Show("Введите должность работника!");
                return;
            }

            foreach (char c in RoleTextBox.Text)
            {
                if (!char.IsLetter(c) && c != ' ' && c != '-')
                {
                    MessageBox.Show("Должность должна содержать только буквы!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RoleTextBox.Focus();
                    RoleTextBox.SelectAll();
                    return;
                }
            }

            newRow.role = RoleTextBox.Text;

            dataSet.Worker.AddWorkerRow(newRow);
            dataSet.WriteXml(dataPath);
            MessageBox.Show($"Работник {newRow.fio} был успешно добавлен!");
            this.Close();
        }

        private void INNTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем только цифры и клавишу Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // блокируем ввод
                INNTextBox.Text = "Разрешены только цифры!";
            }
            else
            {
                INNTextBox.Text = "";
            }
        }
    }
}
