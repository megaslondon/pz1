using PZ1.db;
using System;
using System.Linq;
using System.Windows.Forms;

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

        private void goBackButton_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void AddWorkerButton_Click(object sender, EventArgs e)
        {
            DataSet1.WorkerRow newRow = dataSet.Worker.NewWorkerRow();

            string fio = FIOTextBox.Text.Trim();
            string role = RoleTextBox.Text.Trim(); 
            string inn = INNTextBox.Text.Trim();

            if (string.IsNullOrEmpty(fio)) {
                MessageBox.Show("Введите ФИО работника!");
                return;
            }

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Введите должность работника!");
                return;
            }

            if (string.IsNullOrEmpty(inn))
            {
                MessageBox.Show("Введите ИНН!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                INNTextBox.Focus();
                return;
            }

            if (inn.Length != 12)
            {
                MessageBox.Show("ИНН должен содержать ровно 12 цифр!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                INNTextBox.Focus();
                INNTextBox.SelectAll();
                return;
            }

            newRow.fio = fio;
            newRow.role = role;
            newRow.inn = inn;

            dataSet.Worker.AddWorkerRow(newRow);
            dataSet.WriteXml(dataPath);
            MessageBox.Show($"Работник {newRow.fio} был успешно добавлен!");
            this.Close();
        }

        private void FIOTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var key = e.KeyChar;

            if(char.IsDigit(key))
            {
                e.Handled = true;
            }
            else if (key == (char)Keys.Enter)
            {
                string fio = FIOTextBox.Text;
                if (fio.Length != 0) this.ProcessTabKey(true);
                else e.Handled = true;
            }
        }

        private void RoleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var key = e.KeyChar;

            if (char.IsDigit(key))
            {
                if (RoleTextBox.SelectionStart == 0 || !RoleTextBox.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Числовое значение в названии должности допустимо только тогда, когда ему предшествовало строковое описание!", "Ошибка!", MessageBoxButtons.OK);
                    e.Handled = true;
                    return;
                }
            }

            else if (key == (char)Keys.Enter)
            {
                string role = RoleTextBox.Text;
                if (role.Length != 0) this.ProcessTabKey(true);
                else e.Handled = true;
            }
        }

        private void INNTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var key = e.KeyChar;
            if (key == (char)Keys.Enter)
            {
                string inn = INNTextBox.Text;
                if (inn.Length == 12) this.ProcessTabKey(true);
                else e.Handled = true;
            }
            else if (key!=(char)Keys.Back&&!char.IsDigit(key))
            {
                e.Handled = true;
            }
        }
    }
}
