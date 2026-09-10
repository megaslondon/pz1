using PZ1.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            newRow.inn = INNTextBox.Text;

            if (string.IsNullOrEmpty(newRow.fio)) {
                MessageBox.Show("Введите ФИО работника!");
                return;
            }

            if (newRow.fio.Any(char.IsDigit))
            {
                MessageBox.Show("ФИО работника не должна содержать чисел!");
                return;
            }

            if (string.IsNullOrEmpty(newRow.role))
            {
                MessageBox.Show("Введите должность работника!");
                return;
            }

            if (newRow.role.Any(char.IsDigit))
            {
                MessageBox.Show("Должность работника не должна содержать чисел!");
                return;
            }

            if (string.IsNullOrEmpty(newRow.inn))
            {
                MessageBox.Show("Введите ИНН работника!");
                return;
            }

            if (newRow.inn.Length!=12)
            {
                MessageBox.Show("ИНН работника должно содержать ровно 12 цифр!");
                return;
            }

            dataSet.Worker.AddWorkerRow(newRow);
            dataSet.WriteXml(dataPath);
            MessageBox.Show($"Работник {newRow.fio} был успешно добавлен!");
            this.Close();
        }

    }
}
