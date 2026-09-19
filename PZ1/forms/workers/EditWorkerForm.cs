using PZ1.db;
using System;
using System.Linq;
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

        private void EditWorkerForm_Load(object sender, EventArgs e)
        {

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

            string fioText = FIOTextBox.Text.Trim();

            foreach (char c in fioText)
            {
                
                if (!char.IsLetter(c) && c != ' ' && c != '-')
                {
                    MessageBox.Show("ФИО должна содержать только буквы, пробелы и дефисы!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FIOTextBox.Focus();
                    FIOTextBox.SelectAll();
                    return;
                }
            }

            workerRow.fio =FIOTextBox.Text;

            if (string.IsNullOrEmpty(workerRow.role))
            {
                MessageBox.Show("Введите должность работника!");
                return;
            }

            string roleText = RoleTextBox.Text.Trim();

            foreach (char c in roleText)
            {
                if (!char.IsLetter(c) && c != ' ' && c != '-')
                {
                    MessageBox.Show("Должность должна содержать только буквы, пробелы и дефисы!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RoleTextBox.Focus();
                    RoleTextBox.SelectAll();
                    return;
                }
            }

            workerRow.role = RoleTextBox.Text;

            if (string.IsNullOrEmpty(workerRow.inn))
            {
                MessageBox.Show("Введите ИНН работника!");
                return;
            }

            if (workerRow.inn.Length != 12)
            {
                MessageBox.Show("ИНН работника должно содержать ровно 12 цифр!");
                return;
            }

            foreach (char c in INNTextBox.Text)
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
                e.Handled = true;
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
