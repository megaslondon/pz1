using PZ1.db;
using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace PZ1.forms.workers
{
    public partial class EditWorkerForm : Form
    {
        private DataSet1.WorkerRow workerRow;
        private string dataPath;

        public EditWorkerForm(DataSet1.WorkerRow row, string path)
        {
            InitializeComponent();
            this.workerRow = row;
            this.dataPath = path;
            this.FIOTextBox.Text = row.fio; 
            this.RoleTextBox.Text = row.role;
            this.INNTextBox.Text = row.inn;
        }


        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditWorkerButton_Click(object sender, EventArgs e)
        {
            workerRow.fio = FIOTextBox.Text;
            workerRow.role = RoleTextBox.Text;
            workerRow.inn = INNTextBox.Text;

            if (string.IsNullOrEmpty(workerRow.fio))
            {
                MessageBox.Show("Введите ФИО работника!");
                return;
            }


            if (string.IsNullOrEmpty(workerRow.role))
            {
                MessageBox.Show("Введите должность работника!");
                return;
            }

            if (workerRow.inn.Length != 12)
            {
                MessageBox.Show("ИНН должен содержать ровно 12 цифр!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                INNTextBox.Focus();
                INNTextBox.SelectAll();
                return;
            }


            workerRow.fio = FIOTextBox.Text;
            workerRow.role = RoleTextBox.Text;
            workerRow.inn = INNTextBox.Text;

            workerRow.Table.WriteXml(dataPath);
            MessageBox.Show($"Работник {workerRow.fio} был успешно сохранен!");
            this.Close();
        }

        private void FIOTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var key = e.KeyChar;

            if (char.IsDigit(key))
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
                if (char.IsDigit(key))
                {
                    foreach (char c in RoleTextBox.Text)
                    {
                        if (char.IsLetter(c)) return;
                    }
                    MessageBox.Show("sadasd", "Error", MessageBoxButtons.OK);
                    e.Handled = true;
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
            else if (key != (char)Keys.Back && !char.IsDigit(key))
            {
                e.Handled = true;
            }
        }
    }
}
