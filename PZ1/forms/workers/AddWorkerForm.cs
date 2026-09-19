using PZ1.db;
using System;
using System.Linq;
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
                MessageBox.Show("go");
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
            else if (key!=(char)Keys.Back&&!char.IsDigit(key))
            {
                e.Handled = true;
            }
        }
    }
}
