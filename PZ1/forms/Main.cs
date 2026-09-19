using PZ1.db;
using PZ1.forms.workers;
using PZ1.forms.workLog;
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

        private DataSet1.WorkerRow getSelectedWorker()
        {
            var view = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            var row = (DataSet1.WorkerRow)view.Row;
            return row;
        }
        private DataSet1.WorkLogRow getSelectedWorkLog()
        {
            var view = (DataRowView)dataGridView2.CurrentRow.DataBoundItem;
            var row = (DataSet1.WorkLogRow)view.Row;
            return row;
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
            var selectedWorker = getSelectedWorker();

            EditWorkerForm editWorkerForm = new EditWorkerForm(selectedWorker, dataPath);
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

            var selectedWorker = getSelectedWorker();

            var res = MessageBox.Show($"Вы действительно хотите удалить {selectedWorker.fio}?", "Подтверждение", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                selectedWorker.Delete();
                dataSet.WriteXml(dataPath);
                MessageBox.Show("Информация о работнике успешно удалена!");
            }

        }
        private void AddWorkLogButton_Click(object sender, EventArgs e)
        {
            AddWorkLogForm addWorkLogForm = new AddWorkLogForm(dataSet, dataPath);
            addWorkLogForm.ShowDialog(this);

            dataGridView1.Refresh();
            dataGridView2.Refresh();
        }
        private void EditWorkLogButton_Click(object sender, EventArgs e)
        {
            var selectedWorkLog = getSelectedWorkLog();

            EditWorkLogForm editWorkLogForm = new EditWorkLogForm(dataSet.Tables["worker"], selectedWorkLog, dataPath);
            editWorkLogForm.ShowDialog(this);

            dataGridView1.Refresh();
            dataGridView2.Refresh();
        }
        private void DeleteWorkLogButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись выполненной работы для удаления!");
                return;
            }

            var selectedWorkLog = getSelectedWorkLog();
            var res = MessageBox.Show($"Вы действительно хотите удалить запись о выполненной работе с id {selectedWorkLog.id}?", "Подтверждение", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                selectedWorkLog.Delete();
                dataSet.WriteXml(dataPath);
                MessageBox.Show("Информация о выполенной работе успешно удалена!");
            }
        }
    }
}
