using PZ1.db;
using PZ1.forms.workers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PZ1.forms
{
    public partial class Main : Form
    {
        private DataSet1 dataSet = new DataSet1();
        private string dataPath = "db.xml";

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (File.Exists(dataPath))
            {
                dataSet.ReadXml(dataPath);
            }
            dataGridView1.DataSource = dataSet.Worker;
            dataGridView2.DataSource = dataSet.WorkLog;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddWorkerButton_Click(object sender, EventArgs e)
        {
            AddWorkerForm addWorkerForm = new AddWorkerForm(dataSet, dataPath);
            addWorkerForm.ShowDialog(this);

            dataGridView1.Refresh();
            dataGridView2.Refresh();
        }

        private void EditWorkerButton_Click(object sender, EventArgs e)
        {
            var view = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            var row = (DataSet1.WorkerRow)view.Row;

            EditWorkerForm editWorkerForm = new EditWorkerForm(row, dataPath);
            editWorkerForm.ShowDialog(this);

            dataGridView1.Refresh();
            dataGridView2.Refresh();
        }
        private void DeleteWorkerButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите работника для удаления!");
                return;
            }

            var view = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            var row = (DataSet1.WorkerRow)view.Row;

            var res = MessageBox.Show($"Вы действительно хотите удалить {row.fio}?", "Подтверждение", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                row.Delete();
                dataSet.WriteXml(dataPath);
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button4");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button5");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button6");
        }

    }
}
